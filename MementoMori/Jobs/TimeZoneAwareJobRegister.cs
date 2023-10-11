﻿using System.Reflection;
using MementoMori.Option;
using Microsoft.Extensions.Options;
using Quartz;

namespace MementoMori.Jobs;

public class TimeZoneAwareJobRegister
{
    private readonly ISchedulerFactory _schedulerFactory;
    private readonly TimeManager _timeManager;
    private readonly IWritableOptions<GameConfig> _gameConfig;

    public TimeZoneAwareJobRegister(ISchedulerFactory schedulerFactory, TimeManager timeManager, IWritableOptions<GameConfig> gameOptions)
    {
        _schedulerFactory = schedulerFactory;
        _timeManager = timeManager;
        _gameConfig = gameOptions;
    }

    public async Task RegisterJobs()
    {
        var scheduler = await _schedulerFactory.GetScheduler();
        if (_gameConfig.Value.AutoJob.DisableAll)
        {
            RemoveJob<DailyJob>(scheduler);
            RemoveJob<HourlyJob>(scheduler);
            RemoveJob<PvpJob>(scheduler);
            RemoveJob<GuildRaidBossReleaseJob>(scheduler);
            return;
        }

        AddJob<DailyJob>(scheduler, _gameConfig.Value.AutoJob.DailyJobCron);
        AddJob<HourlyJob>(scheduler, _gameConfig.Value.AutoJob.HourlyJobCron);
        AddJob<PvpJob>(scheduler, _gameConfig.Value.AutoJob.PvpJobCron);
        AddJob<GuildRaidBossReleaseJob>(scheduler, _gameConfig.Value.AutoJob.GuildRaidBossReleaseCron);
    }

    private void RemoveJob<T>(IScheduler scheduler) where T : IJob
    {
        var type = typeof(T);
        var jobKey = new JobKey(type.FullName!);
        scheduler.DeleteJob(jobKey);
    }

    private void AddJob<T>(IScheduler scheduler, string cron) where T : IJob
    {
        var type = typeof(T);
        var jobKey = new JobKey(type.FullName!);
        var jobDetail = JobBuilder.Create<T>().WithIdentity(jobKey).Build();

        var customTimeZone = TimeZoneInfo.CreateCustomTimeZone(_timeManager.DiffFromUtc.ToString(), _timeManager.DiffFromUtc, null, null);
        var trigger = TriggerBuilder.Create()
            .ForJob(jobKey)
            .WithIdentity($"{type.FullName}-trigger")
            .WithCronSchedule(cron, builer => builer.InTimeZone(customTimeZone))
            .Build();
        scheduler.UnscheduleJob(trigger.Key);
        scheduler.AddJob(jobDetail, true);
        scheduler.ScheduleJob(jobDetail, trigger);
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class CronAttribute : Attribute
{
    public CronAttribute(string cron)
    {
        Cron = cron;
    }

    public string Cron { get; set; }
}