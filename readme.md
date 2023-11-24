﻿[ [Zh](readme.md) | [En](readme.en.md) ]

# MementoMori 游戏助手


![GitHub all releases](https://img.shields.io/github/downloads/moonheart/mementomori-helper/total)
![GitHub release (with filter)](https://img.shields.io/github/v/release/moonheart/mementomori-helper)
![GitHub Release Date - Published_At](https://img.shields.io/github/release-date/moonheart/mementomori-helper)

施工中 

[反馈和交流](https://t.me/+gTRe8AxKxIdkOTg9)

## **免责声明**

使用本辅助工具的用户（以下简称“用户”）请注意以下几点：

1. 本辅助工具仅供个人娱乐和教育目的使用。使用本工具可能违反特定游戏或应用的使用政策，请自行承担风险。

2. 开发者（以下简称“我们”）不对用户在游戏中使用本工具所产生的任何后果负任何法律或道德责任。用户应自行承担使用工具可能带来的风险。

3. 用户需明白，游戏或应用的开发者可能会采取措施来检测并阻止辅助工具的使用，这可能导致用户的账户被封禁或受到其他制裁。

4. 使用本辅助工具可能违反适用法律。用户需确保自己的使用遵守所有适用法律和法规。

5. 我们保留随时更改或停止本辅助工具的权利，无需提前通知。

通过下载、安装和使用本辅助工具，用户表明已详细阅读并理解此免责声明，并同意自行承担使用本工具所带来的一切风险。如不同意本声明的任何部分，请停止使用本辅助工具。

## 预览
<table>
<tbody>
<tr><td> 

![](images/intro1.png) </td><td>![](images/intro2.png)</td></tr>
<tr><td>

![](images/intro3.png)</td><td>![](images/intro4.png)</td></tr>
<tr><td>

![](images/intro5.png)</td><td>![](images/intro6.png)</td></tr>
<tr><td>

![](images/intro7.png)</td><td>![](images/intro8.png)</td></tr>
</tbody>
</table>


## Todos

<!-- prettier-ignore -->
<table>
  <tbody>
  <tr >
      <td>

- [x] 多账号支持
    - [x] 账号密码直接登录
- [ ] 主页
    - [x] 用户登陆
    - [x] 领取每日登陆奖励
    - [x] 领取每日 VIP 礼物
    - [x] 一键发送/接收友情点
    - [x] 一键领取礼物箱
    - [x] 一键领取任务奖励
    - [x] 一键领取徽章奖励
    - [x]  一键使用固定物品
    - [x]  月卡奖励自动领取
- [ ] 交换商店
    - [x] 普通物品购买
    - [x] 符石购买
    - [x] 自动购买商品
- [ ] 角色
	- [x] 角色列表
	- [x] 角色属性
	- [x] 角色装备详细
	- [ ] 升级
	- [ ] 突破
    - [ ] 编组

</td>
<td>

- [ ] 储物箱
	- [x] 自动使用物品
	- [x] 自动精炼魔装并继承到D级别装备
	- [x] 神装自动继承到D装
	- [x] 装备自动打磨
	- [ ] 手动使用物品
- [ ] 冒险
    - [x] 领取自动战斗奖励
    - [x] 一键高速战斗
    - [x] 首领一键扫荡
    - [x] 自动刷关
      - [x] 通过指定关卡后停止
- [ ] 试炼
    - [x] 无穷之塔一键扫荡
    - [x] 无穷之塔自动刷关
      - [x] 通过指定关卡后停止
    - [x] 幻影神殿一键挑战
      - [x] 蹭车模式
      - [ ] 自己开房间模式
      - [x] 配置报酬权重
    - [x] 古竞技场一键挑战5次
    - [x] 祈愿之泉一键全部领取
    - [x] 祈愿之泉一键远征
      - [x] 可选仅派遣指定奖励物品的任务
    - [x] 时空洞窟一键自动执行
      - [x] 可选自动购买指定商品
      - [x] 有宝箱节点时优先选择宝箱节点
      - [x] 自动使用恢复道具
</td>
<td>

- [ ] 抽卡
    - [x] 每日免费/金币抽卡
    - [x] 卡池列表
    - [x] 手动抽卡
- [ ] 公会
    - [x] 公会签到
    - [x] 公会讨伐战自动扫荡
    - [x] 自动开启讨伐战
    - [x] 公会战奖励收取
- [ ] 其他
    - [x] 刷关时在支持其他自动任务并行 
    - [x] 刷关配置请求频率限制 

</td>
</tr>

  </tbody>
</table>

## 使用

进入到发布页面：https://github.com/moonheart/mementomori-helper/releases, 然后下载 `publish-win-x64.zip` 解压。

### 方式1 直接运行

要运行的话,你需要配置好你的账号信息. 然后就可以运行 `MementoMori.WebUI.exe` 了, 找到类似 `Now listening on: http://0.0.0.0:5000` 的日志, 打开这个地址就可以了.

### 方式2 用 Docker 运行

```yaml
version: '3'
services:
  mementomori:
    image: moonheartmoon/mementomori-webui:v1
    container_name: mementomori
    restart: unless-stopped
    privileged: false
    ports:
      - "5290:8080"
    environment:
      - TZ=Asia/Shanghai
    volumes:
      - ./Master/:/app/Master/
      - ${PWD}/appsettings.user.json:/app/appsettings.user.json:rw
```

- 启动或更新: `docker compose up -d --pull always`
- 停止: `docker compose down`
- 查看日志: `docker compose logs -f`


进入网页之后, 先点击一次登录, 之后就可以随意操作了.

## 自动任务

程序会在特定时间执行特定操作

### 每日任务 (服务器时间 4:10)
- 收取每日登录奖励
- 收取每日 VIP 奖励
- 收取自动战斗奖励
- 收取发送友情点
- 收取礼物箱
- 强化一次装备 (自动选择当前有角色装备的等级最低的装备, 用于完成每日任务) 
- 主线扫荡 3 次
- 无穷之塔扫荡 3 次
- 免费高速战斗 (免费一次, 月卡一次)
- 公会签到
- 公会讨伐战
- 祈愿之泉收取奖励
- 祈愿之前自动派遣
- 时空洞窟自动执行
- 收取每日/每周任务奖励
- 使用固定道具
- 消耗道具抽卡
- 自动进阶角色 (R->R+, SR->SR+)

### 奖励定时收取 (服务器时间 0:30,4:30,8:30,12:30,16:30,20:30)

- 收取每日登录奖励
- 收取自动战斗奖励
- 祈愿之泉派遣+收取
- 公会讨伐
- 友情点收取			
- 任务奖励收取
- 公会战奖励收取
- 自动抽卡
- 使用固定物品

### 竞技场 (服务器时间 20:00)

- 竞技场 5 次 (自动选择列表战力最低作为对手)

## 帐号配置

启动程序后，进入设置，添加账号，输入账号名称，引继ID，引继密码即可。

## 功能说明

### 签到奖励

自动领取每日签到奖励、累计签到天数奖励、限时签到奖励

### VIP 每日福利

自动领取 VIP 每日免费礼物

### 每月强化组合包

自动领取每月强化组合包

### 自动战斗报酬

自动领取自动战斗报酬

### 友情点数

自动赠送和领取友情点数

### 强化一次装备

用于完成每日任务 “進行武具強化1次”

装备选择策略：有角色装备的且等级最低的且等级未达到上限的装备

### 挑战首领 3 次

自动使用每日 3 次的免费挑战首领的次数。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 无穷之塔 3 次

自动使用每日 3 次的免费挑战无穷之塔的次数。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 古竞技场自动战斗 5 次

自动进行 5 次古竞技场的战斗。

对手选择策略：列表中战斗力最低的玩家

### 巅峰竞技场自动战斗 10 次

自动进行 10 次巅峰竞技场的战斗。

对手选择策略：列表中战斗力最低的玩家

### 免费高速战斗

自动使用免费的 2 小时高速战斗次数。

### 免费召唤

自动使用道具进行抽卡。

道具配置：选项 - 召唤 - 自动抽卡消耗物品

### 公会签到

自动领取每日公会签到奖励。

### 公会讨伐战

自动进行公会讨伐战的战斗。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 公会讨伐战开放

自动开放光士公会讨伐战。

### 公会战部署防御

自动在公会战中的本公会据点上部署防御。

部署策略：从大据点到小据点依次部署，部署时第一次为 5 角色一队，后续为三次 3 角色一队，剩余未 1 角色一队。

角色选择策略：战斗力从高到低。

### 公会战领取奖励

自动领取公会战和跨服公会战的奖励

### 幻影神殿

自动进行幻影神殿的战斗。战斗方式为随机加入已有的房间。

#### 任务选择策略：

有活动时：选择活动道具报酬数量（首次奖励 + 固定奖励）最高的任务。
无活动时：按照选项中配置的报酬权重进行选择。

#### 报酬权重

进入 选项 - 欢迎神殿 可以设置报酬权重，计算方法如下：

假如设置是这样的：

- 符石兑换券：5
- 潜能宝珠：3

有两个任务：
- 任务 A 报酬为符石兑换券x10，加上权重可得 50
- 任务 B 为潜能宝珠x30，加上权重可得 90

最终会选择任务 B 进行战斗。

### 祈愿之泉全部领取

自动领取祈愿之泉的奖励。

### 祈愿之泉自动远征

自动派遣角色进行远征任务。

可以在 选项 - 祈愿之泉 中设置仅包含指定报酬的任务。

可以打开 强制派遣 以忽略此设置。

可以点击 刷新（钻石x20） 来刷新常规任务。

### 自动购买商城物品

可以自动购买商城物品。可以设置消耗的道具、购买的物品、最低折扣。

默认购买的物品可以在选项中找到，默认如下，可以点击 重置为默认 进行恢复：
- 用任意物品购买生命树之露 20%OFF
- 用金币购买任意物品 0%OFF

添加自动购买的物品请到左侧栏-商城，点击消耗道具旁边的闹钟按钮，会弹出一个自动购买的对话框，可以设置

- 要购买的物品，清空表示购买所有物品
- 商品打折幅度，0%OFF 表示不需要打折
- 消耗的物品，清空表示可以消耗任意物品
- 必须至少指定购买物品和消耗物品其中一个

### 使用固定物品

自动使用道具类型为“宝箱”且奖励类型为“固定”或者“随机”的道具，如宝箱、未鉴定符石。

### 批次进化

自动将 R 卡合成为 R+，将 SR 卡合成为 SR+。

### 回忆

自动阅读所有未阅读的角色回忆，可以获取钻石。

### 任务-全部领取

领取完成任务的奖章。

### 任务-奖章奖励

领取每日任务和每周任务的奖章奖励。

### 角色

从左侧边栏可以进入到角色页面。在这里可以浏览所有角色的基础信息和装备信息。

### 储物箱

从左侧边栏可以进入到储物箱页面。在这里可以浏览所有的道具和道具的信息。

### 商城

从左侧边栏可以进入到商城页面。这里和游戏中的商城是一样的，可以购买道具或符石，可以设置自动购买道具。

### 召唤

从左侧边栏可以进入到召唤页面。这里和游戏中的召唤是一样的，可以进行抽卡，可以查看抽卡详情和保底进度。

### 战斗记录

从左侧边栏可以进入到战斗记录页面。这里可以查看主线冒险和无穷之塔的战斗记录，可以直接观看战斗详细信息，也可以下载 json 文件以供分享或备份。

### 选项

从左侧边栏可以进入到选项页面。这里可以查看所有的设置，也可以查看自动任务的信息。


## 常见问题

### 如何多开?

多开需要修改修改端口号, 在 `appsettings.user.json` 里面修改, 比如下面是把端口修改为 5700

```json5
{
  "Kestrel": {
    "Endpoints": {
      "Http": {
        "Url": "http://localhost:5700"
      }
    }
  }
}
```
