﻿namespace MementoMori.Battle;

public class RewardAutoBattle
{
    public class Req
    {
    }

    public class Resp
    {
        public AutoBattleRewardResult AutoBattleRewardResult { get; set; }
        public UserSyncData UserSyncData { get; set; }
    }

    public class AutoBattleRewardResult
    {
        public int BattleCountAll { get; set; }
        public int BattleCountWin { get; set; }
        public BattleRewardResult BattleRewardResult { get; set; }
        public int BattleTotalTime { get; set; }
        public int GoldByPopulation { get; set; }
        public int PotentialJewelByPopulation { get; set; }
    }

    public class BattleRewardResult
    {
        public int CharacterExp { get; set; }
        public DropItemList[] DropItemList { get; set; }
        public int ExtraGold { get; set; }
        public object[] FixedItemList { get; set; }
        public int PlayerExp { get; set; }
        public int RankUp { get; set; }
    }

    public class DropItemList
    {
        public int ItemCount { get; set; }
        public int ItemId { get; set; }
        public int ItemType { get; set; }
    }

    public class UserSyncData
    {
        public object BlockPlayerIdList { get; set; }
        public object ClearedTutorialIdList { get; set; }
        public object CreateUserIdTimestamp { get; set; }
        public DataLinkageMap DataLinkageMap { get; set; }
        public object[] DeletedCharacterGuidList { get; set; }
        public object[] DeletedEquipmentGuidList { get; set; }
        public object ExistVipDailyGift { get; set; }
        public object[][] GivenItemCountInfoList { get; set; }
        public object GuildJoinLimitCount { get; set; }
        public object IsDataLinkage { get; set; }
        public object IsJoinedGlobalGvg { get; set; }
        public object IsJoinedLocalGvg { get; set; }
        public object IsReceivedSnsShareReward { get; set; }
        public object IsValidContractPrivilege { get; set; }
        public object LegendLeagueClassType { get; set; }
        public object LocalRaidChallengeCount { get; set; }
        public object PresentCount { get; set; }
        public object PrivacySettingsType { get; set; }
        public long ReceivedAutoBattleRewardLastTime { get; set; }
        public ShopCurrencyMissionProgressMap ShopCurrencyMissionProgressMap { get; set; }
        public object[] ShopProductGuerrillaPackList { get; set; }
        public object TimeServerId { get; set; }
        public TreasureChestCeilingCountMap TreasureChestCeilingCountMap { get; set; }
        public object UserBattleBossDtoInfo { get; set; }
        public object UserBattleLegendLeagueDtoInfo { get; set; }
        public object UserBattlePvpDtoInfo { get; set; }
        public object UserBoxSizeDtoInfo { get; set; }
        public object[] UserCharacterBookDtoInfos { get; set; }
        public object[] UserCharacterCollectionDtoInfos { get; set; }
        public object[] UserCharacterDtoInfos { get; set; }
        public UserDeckDtoInfos[] UserDeckDtoInfos { get; set; }
        public object[] UserEquipmentDtoInfos { get; set; }
        public UserItemDtoInfo[] UserItemDtoInfo { get; set; }
        public object UserLevelLinkDtoInfo { get; set; }
        public object[] UserLevelLinkMemberDtoInfos { get; set; }
        public object[] UserMissionActivityDtoInfos { get; set; }
        public object[] UserMissionDtoInfos { get; set; }
        public object UserMissionOccurrenceHistoryDtoInfo { get; set; }
        public object[] UserFriendMissionDtoInfoList { get; set; }
        public object UserNotificationDtoInfoInfos { get; set; }
        public object[] UserOpenContentDtoInfos { get; set; }
        public object[] UserSettingsDtoInfoList { get; set; }
        public object[] UserShopAchievementPackDtoInfos { get; set; }
        public object UserShopFirstChargeBonusDtoInfo { get; set; }
        public object[] UserShopFreeGrowthPackDtoInfos { get; set; }
        public object[] UserShopMonthlyBoostDtoInfos { get; set; }
        public object UserShopSubscriptionDtoInfos { get; set; }
        public UserStatusDtoInfo UserStatusDtoInfo { get; set; }
        public object[] UserTowerBattleDtoInfos { get; set; }
        public object[] UserVipGiftDtoInfos { get; set; }
    }

    public class DataLinkageMap
    {
    }

    public class ShopCurrencyMissionProgressMap
    {
    }

    public class TreasureChestCeilingCountMap
    {
    }

    public class UserDeckDtoInfos
    {
        public int DeckNo { get; set; }
        public int DeckUseContentType { get; set; }
        public int DeckBattlePower { get; set; }
        public string UserCharacterGuid1 { get; set; }
        public int CharacterId1 { get; set; }
        public string UserCharacterGuid2 { get; set; }
        public int CharacterId2 { get; set; }
        public string UserCharacterGuid3 { get; set; }
        public int CharacterId3 { get; set; }
        public string UserCharacterGuid4 { get; set; }
        public int CharacterId4 { get; set; }
        public string UserCharacterGuid5 { get; set; }
        public int CharacterId5 { get; set; }
    }

    public class UserItemDtoInfo
    {
        public int ItemCount { get; set; }
        public int ItemId { get; set; }
        public int ItemType { get; set; }
        public long PlayerId { get; set; }
    }

    public class UserStatusDtoInfo
    {
        public long CreateAt { get; set; }
        public bool IsFirstVisitGuildAtDay { get; set; }
        public bool IsReachBattleLeagueTop50 { get; set; }
        public bool IsAlreadyChangedName { get; set; }
        public int Birthday { get; set; }
        public string Comment { get; set; }
        public long PlayerId { get; set; }
        public int MainCharacterIconId { get; set; }
        public int FavoriteCharacterId1 { get; set; }
        public int FavoriteCharacterId2 { get; set; }
        public int FavoriteCharacterId3 { get; set; }
        public int FavoriteCharacterId4 { get; set; }
        public int FavoriteCharacterId5 { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int BoardRank { get; set; }
        public int Exp { get; set; }
        public int Vip { get; set; }
        public long LastLoginTime { get; set; }
        public long PreviousLoginTime { get; set; }
        public long LastLvUpTime { get; set; }
        public int VipExp { get; set; }
    }
}