﻿using System.ComponentModel;

namespace MementoMori.Ortega.Share;

[Description("エラーコード")]
public enum ErrorCode
{
    [Description("エラー無し")] None,

    [Description("サーバー側でハンドリングされていない例外が発生した")]
    UncaughtException,
    [Description("Headerが不正です")] InvalidRequestHeader,

    [Description("アプリバージョンデータに異常が検出されました。")]
    InvalidDataAppVersionMB,
    [Description("メンテナンス")] CommonMaintenance = 100,
    [Description("部分メンテナンス")] CommonSectionMaintenance,
    [Description("ハードメンテナンス")] CommonHardMaintenance,
    [Description("強制アップデート")] CommonRequireClientUpdate,
    [Description("セッションがありません")] CommonNoSession = 111,
    [Description("別の端末でログインされました")] CommonLoggedInAnotherDevice,
    [Description("NGワードが含まれます")] CommonContainsNgWord = 201,
    [Description("不正なAPI Requestです")] CommonApiInvalidRequest = 301,
    [Description("マスターデータが見つかりません。")] CommonNotFoundMasterData = 401,

    [Description("アプリアセットバージョンマスターデータが見つかりません。")]
    CommonNotFoundAppAssetVersionMasterData,
    [Description("新規ユーザー生成禁止")] CommonUnableToCreateUser = 998,
    [Description("新規プレイヤー生成禁止")] CommonUnableToCreatePlayer,
    [Description("付与可能なワールドに接続が必要です。")] CommonBuyProductDifferentGameServer,
    [Description("存在しないプレイヤーです。")] CommonDeletedPlayer,
    [Description("Dtoデータが存在しません。")] CommonNotFoundDto,
    [Description("Dtoタイプが存在しません。")] CommonNotFoundDtoType,
    [Description("Maxクリアクエスト情報がありません。")] CommonNotFoundCurrentMaxClearQuestId,
    [Description("プレイヤー生成日の情報がありません。")] CommonNotFoundCreatePlayerTimestamp,
    [Description("ユーザーデータがありません")] AuthNotFoundUserAccountDto = 10001,
    [Description("ユーザーのプレイヤーデータが存在しません")] AuthNotFoundUserPlayerDto,
    [Description("プレイヤーデータの取得に失敗しました")] AuthNotFoundPlayerDto,
    [Description("リクエストが不正です")] AuthAddSnsAccountInvalidRequest = 10101,

    [Description("パスワードは数字、大文字、小文字を組み合わせた8文字以上16文字以内です")]
    AuthAddSnsAccountInvalidPasswordFormat,
    [Description("既に連携済みのアカウントです。")] AuthAddSnsAccountAlreadyLinkedUserData,
    [Description("ユーザー作成に失敗しました")] AuthCreateUserFailed = 10201,
    [Description("リクエストが不正です。")] AuthInvalidCountryCode = 10301,
    [Description("国情報の識別に失敗しました。")] AuthTimeServerDecisionFailed,

    [Description("野良APK版で利用できない国コードが含まれています。")]
    AuthInvalidCountryCodeOnApk = 10310,
    [Description("リクエストが不正です")] AuthLoginInvalidRequest = 10401,

    [Description("ログインしようとしているアカウントは既に削除されました。")]
    AuthLoginAlreadyDeletedUser,
    [Description("サーバーが満員です")] AuthJoinNewWorldMaxPlayerInWorld = 10501,
    [Description("リクエストが不正です")] AuthJoinNewWorldInvalidRequest,
    [Description("エラーが発生しました")] AuthJoinNewWorldAlreadyPlayer,
    [Description("国情報が不正です")] AuthJoinNewWorldInvalidTimeServer,
    [Description("ユーザーデータが存在しません")] AuthComebackUserNotFoundUserAccountDto = 10601,
    [Description("リクエストが不正です")] AuthComebackUserPasswordIsNull,

    [Description("パスワードは数字、大文字、小文字を組み合わせた8文字以上16文字以内です")]
    AuthComebackUserInvalidPasswordFormat,
    [Description("パスワードが正しくありません")] AuthComebackUserInvalidPassword,
    [Description("ユーザー情報の取得に失敗しました")] AuthComebackUserFailedToGetPlayerDataInfo,
    [Description("ユーザーの復帰情報の取得に失敗しました")] AuthComebackUserFailedToGetComebackUserInfo,
    [Description("IDまたはパスワードに誤りがあります")] AuthComebackUserAlreadyDeletedUser,
    [Description("国情報が不正です")] AuthGetServerHostInvalidTimeServer = 10701,
    [Description("設定タイプが範囲外です")] AuthSetUserSettingsUserSettingsTypeOutOfRange = 10801,
    [Description("別のユーザーのプレイヤーIDです")] AuthGiveSnsShareRewardNotSameUserId = 10901,
    [Description("既にSNSシェア報酬を受け取り済みです")] AuthGiveSnsShareRewardAlreadyReceived,
    [Description("報酬の付与に失敗しました")] AuthGiveSnsShareRewardFailedToGiveReward,
    [Description("アカウント削除が既に予約されています。")] AuthReserveAccountDeletionAsyncAlreadyReservedAccountDeletion = 11001,
    [Description("アカウント削除が予約されていません。")] AuthCancelReservedAccountDeletionNotReservedAccountDeletion = 11101,

    [Description("Twitterとの連携時にエラーが発生しました。")]
    AuthFailedToGetTwitterUserId = 12001,

    [Description("Twitterとの連携データが存在しません。")]
    AuthUserTwitterLinkageDtoNotFound,
    [Description("Appleとの連携に失敗しました。")] AuthFailedToVerifyAppleIdToken = 12101,
    [Description("Appleとの連携データが存在しません。")] AuthUserAppleLinkageDtoNotFound,

    [Description("GooglePlayとの連携時にエラーが発生しました。")]
    AuthFailedToGetGoogleUserId = 12201,

    [Description("GooglePlayとの連携データが存在しません。")]
    AuthUserGoogleLinkageDtoNotFound,
    [Description("キャラクターのデータがありません")] ItemEditorNotFoundCharacter = 80000,
    [Description("アイテムが不足しています")] ItemEditorNotEnoughItem,
    [Description("ダイヤが足りません。")] ItemEditorNotEnoughCurrency,
    [Description("有償ダイヤが足りません。")] ItemEditorNotEnoughPaidCurrency,
    [Description("消費できないアイテムです。")] ItemEditorNotConsumableItem,
    [Description("付与できないアイテムです。")] ItemEditorCanNotGiveItem,
    [Description("ユーザのボックスデータが存在しません。")] ItemEditorUserBoxSizeDtoNotFound = 82000,
    [Description("ユーザーのステータスデータが存在しません。")] ItemEditorUserStatusDtoNotFound,
    [Description("ユーザーのステータスデータがありません")] UserUserStatusDtoNotFound = 91000,
    [Description("ユーザーのアカウントデータがありません。")] UserUserAccountDtoNotFound = 91003,
    [Description("ユーザーの編成データがありません")] UserUserDeckDtoNotFound,
    [Description("ユーザのクリアパーティーが見つかりません")] UserClearPartyNotFound = 91007,

    [Description("ユーザのチュートリアルデータが見つかりません")]
    UserTutorialDtoNotFound,
    [Description("所持してないキャラーです")] UserNotHaveCharacter = 92000,
    [Description("無効な誕生日です。")] UserInvalidBirthday,
    [Description("誕生日は一度しか設定できません。")] UserCanOnlySetBirthdayOnce,

    [Description("重複したキャラクターIDが選択されています。")]
    UserSelectDuplicateCharacterId,
    [Description("認証に失敗しました")] UserFailedAuthentication,

    [Description("既に名前変更のチュートリアルを達成しています。")]
    UserAlreadyClearedChangeNameTutorial,
    [Description("ユーザーデータが見つかりません。")] UserNotFoundPlayerInfo,
    [Description("所持してないキャラクターです")] UserSetDeckNotFoundCharacter = 93101,
    [Description("デッキ内にキャラクターがいません。")] UserSaveDeckNobodyCharacter = 93104,
    [Description("重複しているキャラクターが存在します")] UserSaveDeckSameIdCharacter,
    [Description("パーティのキャラ上限数を超えています。")] UserSaveDeckOverMaxCharacterCount,
    [Description("パーティNoの値が不正です。")] UserSaveDeckInvalidDeckNo,
    [Description("ユーザーのステータスデータが存在しません。")] BattleCommonUserStatusDtoNotFound = 96000,

    [Description("例外ケースサブスキルの条件データが存在しません。")]
    BattleCommonNotFoundIrregularSubSkillConditionFormula = 97000,

    [Description("例外ケースサブスキルの値データが存在しません。")]
    BattleCommonNotFoundIrregularValueFormula,

    [Description("サブセットスキルの条件データが存在しません。")]
    BattleCommonNotFoundSubSetSkillConditionFormula,

    [Description("ダメージ系スキルの条件データが存在しません。")]
    BattleCommonNotFoundHpSubSkillConditionFormula,
    [Description("ダメージ系スキルの値データが存在しません。")] BattleCommonNotFoundHpSubSkillPowerValueFormula,
    [Description("効果系スキルの条件データが存在しません。")] BattleCommonNotFoundStatusSubSubSkillConditionFormula,
    [Description("効果系スキルの命中率データが存在しません。")] BattleCommonNotFoundStatusSubSubSkillHitValueFormula,

    [Description("効果系スキルの効果ターンデータが存在しません。")]
    BattleCommonNotFoundStatusSubSubSkillEffectTurnFormula,
    [Description("効果系スキルの効果値データが存在しません。")] BattleCommonNotFoundStatusSubSubSkillEffectValueFormula,

    [Description("アクティブスキルの条件データが存在しません。")]
    BattleCommonNotFoundActiveSkillConditionFormula,
    [Description("ユーザーの放置バトルデータがありません")] BattleAutoUserBattleAutoDtoNotFound = 101000,
    [Description("ユーザーのボスバトルデータがありません")] BattleAutoUserBattleBossDtoNotFound,
    [Description("ユーザーのステータスデータがありません")] BattleAutoUserStatusDtoNotFound,

    [Description("ユーザーのオートバトルの報酬データがありません")]
    BattleAutoUserBattleAutoRewardDtoNotFound,
    [Description("ユーザーのチュートリアルデータがありません")] BattleAutoUserTutorialDtoNotFound,
    [Description("次のクエスト情報がありません")] BattleAutoNextQuestNotFound = 102000,
    [Description("バトルクエスト変更ができません")] BattleAutoInvalidChangeBattleQuest,
    [Description("石で高速周回できません")] BattleAutoInvalidCurrencyBattleQuick,
    [Description("特典回数が足りません")] BattleAutoNotEnoughPrivilegeCount,
    [Description("存在しない高速周回実行タイプです")] BattleAutoInvalidQuickExecuteType = 102005,
    [Description("特典がまだ残っています")] BattleAutoPrivilegeRemain,
    [Description("高速周回の最大値を超えました。")] BattleAutoOverQuickMaxCount,
    [Description("ユーザーのボスバトルデータがありません")] BattleBossUserBattleBossDtoNotFound = 111000,
    [Description("ユーザーのステータスデータがありません")] BattleBossUserStatusDtoNotFound,
    [Description("ユーザーのチュートリアルデータがありません")] BattleBossUserTutorialDtoNotFound,
    [Description("ユーザーの放置バトルデータがありません")] BattleBossUserBattleAutoDtoNotFound,
    [Description("クリアしていないボスには浸透できません")] BattleBossNotYetBossBattleClear = 112000,
    [Description("ボス挑戦回数が足りません")] BattleBossNotEnoughBossChallengeCount,
    [Description("ボス挑戦できません")] BattleBossImpossibleBossChallenge,
    [Description("次のクエスト情報がありません")] BattleBossNextQuestNotFound,
    [Description("ボス挑戦最大回数を超えました")] BattleBossOverBossChallengeMaxCount,
    [Description("石でボス挑戦券を購入できません")] BattleBossInvalidBuyBossBattleTicket,

    [Description("Vipレベルが足りなくて、ボス浸透できません。")]
    BattleBossNotEnoughVipLevelOrMaxQuestIdBossQuick,
    [Description("ユーザーのキャラクターデータがありません")] DungeonBattleCharacterDtoNotFound = 121000,
    [Description("ユーザーの見逃し回数データがありません")] DungeonBattleMissedCountDtoNotFound,
    [Description("ユーザの放置バトルデータがありません")] DungeonBattleUserBattleAutoDtoNotFound,
    [Description("ユーザのショップデータがありません")] DungeonBattleUserDungeonBattleShopDtoNotFound,
    [Description("ユーザの商品データがありません")] DungeonBattleUserShopItemDataNotFound,
    [Description("時空の洞窟のマップ情報がありません")] DungeonBattleDungeonBattleMapDtoNotFound,
    [Description("ユーザーの時空の洞窟敵情報がありません")] DungeonBattleUserDungeonBattleEnemyDtoNotFound,
    [Description("ユーザーの時空の洞窟敵情報がありません")] DungeonBattleUserDungeonBattleSkipRewardDtoNotFound,
    [Description("開催期間内のタームが無い")] DungeonBattleNoActiveTerm = 122001,
    [Description("開催期間外(※時間経過で期間外になった)")] DungeonBattleOutOfTerm,
    [Description("有効期間内のユーザーデータが見つからない")] DungeonBattleUserDataNotFound,
    [Description("マス種別とAPIが異なる")] DungeonBattleInvalidGrid,

    [Description("指定されたマスと現在位置が異なる（データ不整合）")]
    DungeonBattleInvalidGridRequest = 122006,
    [Description("最初の階層が見つからない")] DungeonBattleFirstLayerNotFound = 122010,
    [Description("最初のマスが見つからない")] DungeonBattleFirstGridNotFound,
    [Description("現在の階層が見つからない")] DungeonBattleCurrentLayerNotFound,
    [Description("現在のマスが見つからない")] DungeonBattleCurrentGridNotFound,

    [Description("ゲストキャラクターが不足しているのでMAP生成できない")]
    DungeonBattleGuestCharacterNotEnough,
    [Description("まだ層をクリアしていません")] DungeonBattleNotClearedLayerYet,
    [Description("次の層がありません")] DungeonBattleNextLayerNotFound,
    [Description("現在のマスは未完了です")] DungeonBattleCurrentGridIsNotDone = 122020,
    [Description("選択された遺物は強化できません")] DungeonBattleCanNotReinforceRelic,
    [Description("バトルはマスを事前に指定してください")] DungeonBattleBattleNotSelected = 122031,
    [Description("行商人はマスを事前に指定してください")] DungeonBattleShopNotSelected = 122040,
    [Description("行商人から購入しようとしたIDが存在しない")] DungeonBattleShopItemNotFound,
    [Description("行商人から購入しようとしたIDは購入済み")] DungeonBattleShopItemAlreadyBought,
    [Description("加護IDが不正です。")] DungeonBattleInvalidRelicId,
    [Description("強化可能なレアリティの加護ではありません。")] DungeonBattleInvalidReinforceRelicRarity,
    [Description("バトルマスではありません。")] DungeonBattleNotBattleGrid,
    [Description("バトル結果データが存在しません。")] DungeonBattleBattleResultNotFound,
    [Description("全キャラクター体力が最大です。")] DungeonBattleAllCharacterHPFull,

    [Description("編成キャラにHPが0のキャラクターがいます。")]
    DungeonBattleDeckContainCharacterHPZero,
    [Description("クリア報酬取得済みです。")] DungeonBattleAlreadyGetClearLayerReward,
    [Description("カロン敵データが設定されていません。")] DungeonBattleCharonInfoNotSetting,
    [Description("強化後の加護を既に持っています。")] DungeonBattleAlreadyHaveRelic,
    [Description("取得可能な加護がありません。")] DungeonBattleNotEnoughRelic,
    [Description("期間中の使用制限を超えています。")] DungeonBattleAlreadyMaxHealedByItem,
    [Description("ハードモードの解放条件を満たしていません。")] DungeonBattleNotEnoughHardModeCondition,
    [Description("時空の洞窟の解放条件を満たしていません。")] DungeonBattleNotOpen,
    [Description("ミステリーショップの商品が売り切れです。")] DungeonBattleMysteryShopBuyLimitCount,

    [Description("敵データが不足しているのでMAP生成できない")]
    DungeonBattleDungeonEnemyNotEnough = 122067,
    [Description("既に実行済みのマスです。")] DungeonBattleAlreadyDoneGrid,
    [Description("移動できないマスです。")] DungeonBattleCanNotMoveGrid,

    [Description("イベント特殊バトルマスが選択されていません。")]
    DungeonBattleNotSelectedEventSpecialBattleGrid,

    [Description("現在のマスがイベント特殊バトルマスではありません。")]
    DungeonBattleCurrentGridIsNotEventSpecialBattleGrid,
    [Description("まだイベント特殊マスで敗北していません。")] DungeonBattleNotLostBattleYet,
    [Description("時空の洞窟のマップ情報を更新しています。")] DungeonBattleUpdatingMap,
    [Description("選択できないマスです。")] DungeonBattleCanNotSelectGrid,
    [Description("バトル報酬が存在しません。")] DungeonBattleNotFoundBattleReward,
    [Description("時空の洞窟をスキップできません。")] DungeonBattleCanNotSkip,
    [Description("移動先のマスが見つからない。")] DungeonBattleSkipGridNotFound,
    [Description("ユーザーのバトルリーグデータがありません")] BattlePvpUserBattlePvpDtoNotFound = 131000,
    [Description("ユーザーのステータスデータがありません")] BattlePvpUserStatusDtoNotFound,

    [Description("ユーザーのレジェンドリーグデータがありません")]
    BattlePvpUserBattleLegendLeagueDtoNotFound,

    [Description("ユーザーのレジェンドリーグアイコン報酬データがありません")]
    BattlePvpUserLegendLeagueIconRewardDtoNotFound,
    [Description("石でPVP挑戦券を購入できません")] BattlePvpInvalidBuyPvpTicket = 132000,
    [Description("PVP挑戦最大回数を超えました")] BattlePvpOverPvpChallengeMaxCount,

    [Description("レジェンドリーグランキングデータがありません")]
    BattlePvpNotFoundLegendLeagueData,
    [Description("レジェンドリーグの開催日ではありません")] BattlePvpNotOpenLegendLeague,

    [Description("レジェンドリーグの参加メンバーではありません")]
    BattlePvpNotFoundLegendLeagueMember,
    [Description("レジェンドリーグ挑戦最大回数を超えました")] BattlePvpOverLegendLeagueChallengeMaxCount,
    [Description("購入挑戦券の購入数が足りません")] BattlePvpNotEnoughBuyCount,

    [Description("一日購入できるレジェンドリーグ挑戦回数を超えました")]
    BattlePvpOverBuyLegendLeagueChallengeCount,
    [Description("プレイヤーIDが無効です。")] BattlePvpInvalidPlayerId,
    [Description("本日の参加条件を満たしていません。")] BattlePvpNotEnoughTodayLegendLeagueRequired,
    [Description("レジェンドリーグが解放されていません。")] BattlePvpLegendLeagueNotOpen,
    [Description("バトルリーグのランキング集計中です。")] BattlePvpWaitingBattleLeagueBatch,

    [Description("このプレイヤーのアカウントは削除されたため、挑戦できません")]
    BattlePvpDeletedAccount,
    [Description("バトルログの有効期限が切れています。")] BattlePvpNotFoundBattleLog,
    [Description("プレイヤーのランキング情報が存在しません。")] BattlePvpPlayerRankingNotFound,
    [Description("ランキングデータの更新に失敗しました。")] BattlePvpFailedToUpdateRankingData,

    [Description("レジェンドリーグのランキングデータの更新に失敗しました。")]
    BattlePvpFailedToUpdateLegendLeagueRankingData,
    [Description("プレイヤー情報の取得に失敗しました。")] BattlePvpFailedToGetPlayerInfo,
    [Description("レジェンドリーグの開催期間外です。")] BattlePvpNotBattleTimeLegendLeague,
    [Description("アイコン報酬は解放されていません。")] BattlePvpLegendLeagueIconRewardNotOpen,
    [Description("アイコン報酬購入可能な時間が過ぎました。")] BattlePvpLegendLeagueIconRewardLimitTimeOver,
    [Description("アイコン報酬購入済みです")] BattlePvpLegendLeagueIconRewardAlreadyBuy,
    [Description("ユーザーのボスバトルデータがありません")] BattleBossUserBountyQuestDtoNotFound = 141000,
    [Description("ユーザーデータがありません")] BountyQuestUserStatusDtoNotFound,
    [Description("ユーザーのチュートリアルデータがありません")] BountyQuestUserTutorialDtoNotFound,
    [Description("派遣可能な人数を超えました")] BountyQuestOverDispatchMember = 142000,
    [Description("所持してないキャラーが選択されました")] BountyQuestNotHaveCharacter,
    [Description("出発できない懸賞カウンタークエストです")] BountyQuestInvalidBountyQuest,
    [Description("進行中のクエストは出発できません")] BountyQuestNotEndBountyQuest,
    [Description("受け取り前のクエストは出発できません")] BountyQuestNotYetRewardBountyQuest,
    [Description("派遣人数が異常です。")] BountyQuestInvalidMemberCount,
    [Description("存在しない派遣条件タイプです")] BountyQuestInvalidBountyQuestConditionType,
    [Description("職業条件を満たす人数が足りません")] BountyQuestNotEnoughElementCondition,
    [Description("レアリティ条件を満たす人数が足りません")] BountyQuestNotEnoughRarityCondition,

    [Description("他のソロクエストで使われているキャラーが含まれています")]
    BountyQuestAlreadyUsedOtherSoloQuest,

    [Description("他のチームクエストで使われているキャラーが含まれています")]
    BountyQuestAlreadyUsedOtherTeamQuest,

    [Description("共有メンバーにないキャラーが選択されています")]
    BountyQuestNotDispatchShareCharacter,

    [Description("他のクエストで使われているキャラーが含まれています")]
    BountyQuestAlreadyUsedOtherQuest,
    [Description("受け取りできないクエストです")] BountyQuestInvalidRewardBountyQuest,
    [Description("ほかのユーザーのキャラーが必要です")] BountyQuestNotEnoughOtherUserCharacter,

    [Description("同一キャラクターを同じクエストに編成することはできません。")]
    BountyQuestCanNotAssignDuplicateIdCharacter,
    [Description("抽選グループが存在しません。")] BountyQuestInvalidLotteryGroup,
    [Description("存在しない属性です。")] BountyQuestNotDefinedElementType,
    [Description("一括派遣機能は使えません。")] BountyQuestUnavailableMultipleBountyQuest,
    [Description("一括受け取り機能は使えません。")] BountyQuestUnavailableRewardsBountyQuest,
    [Description("キャラクターレアリティ合計が不正です。")] BountyQuestInvalidCharacterRarityPoint,
    [Description("祈りの泉が解放されていません。")] BountyQuestNotOpen,

    [Description("アカウント削除されたプレイヤーのサポートキャラが含まれています")]
    BountyQuestContainsDeletedAccountSupportCharacter,

    [Description("ユーザーキャラクターサブデータが存在しません。")]
    CharacterUserCharacterSubDtoNotFound = 161000,
    [Description("ユーザーのステータスデータが存在しません。")] CharacterUserStatusDtoNotFound = 161003,
    [Description("ユーザキャラクターデータが存在しません。")] CharacterUserCharacterDtoNotFound,
    [Description("ユーザのボックスデータが存在しません。")] CharacterUserBoxSizeDtoNotFound,

    [Description("ユーザキャラクターの図鑑データが存在しません。")]
    CharacterUserCharacterBookDtoNotFound,
    [Description("レベルリンクデータが存在しません。")] CharacterUserLevelLinkDtoNotFound,
    [Description("レベルアップ機能は使えません。")] CharacterCannotUseLevelUp,
    [Description("レベルリセット機能は使えません。")] CharacterCannotUseLevelReset,

    [Description("ユーザーのチュートリアルデータが存在しません。")]
    CharacterUserTutorialDtoNotFound,
    [Description("エピソードIDが不正です。")] CharacterInvalidEpisodeId = 162000,
    [Description("強化に必要なランクに達していません。")] CharacterNotReachRequiredRank = 162008,
    [Description("Nレアリティではないものが含まれています")] CharacterNotRarityN = 162017,

    [Description("ロックされているキャラクターが含まれています")]
    CharacterLocked,
    [Description("指定したレベルが不正です。")] CharacterLevelInvalid,
    [Description("ベースキャラのレベルが不足しています。")] CharacterNotEnoughBaseCharactersLevel,
    [Description("これ以上拡張できません")] CharacterAlreadyCharacterBoxMaxSize,

    [Description("レベルリンクに登録されているキャラクターはレベルアップできません")]
    CharacterCannotLevelUpWithInLevelLinkCharacters,

    [Description("レベル1のキャラクターはリセットできません。")]
    CharacterResetCharacterLevelAlreadyOne,
    [Description("初期レアリティの条件を満たしていません。")] CharacterNotEnoughInitialRarity,

    [Description("ランクリセット可能なレアリティに到達していません。")]
    CharacterNotReachCanResetRarity,
    [Description("キャラクター所持数制限を超えてしまいます。")] CharacterCharacterBoxIsOverfull,

    [Description("SSR以上の同名キャラクターが一体しか存在しません。")]
    CharacterHigherSSRCharacterIsOnlyOne,

    [Description("レアリティ最大のキャラクターは選択できません。")]
    CharacterMaxRarityCharacterIsOnlyOne,

    [Description("同レアリティ内で最大のレベルのキャラクターはランクリセットできません。")]
    CharacterCanNotResetRankMaxLevelInSameRarity,
    [Description("キャラクターIDが異なります。")] CharacterIdDifferent,
    [Description("キャラクターelementが異なります。")] CharacterElementDifferent,
    [Description("キャラクターランクが最大値")] CharacterRankMaximum,

    [Description("放置バトルのキャラクターは対象にできません。")]
    CharacterExistsAutoBattleDeck,
    [Description("アルカナ解放条件がありません。")] CharacterNotEnoughCharacterCollectionCondition,
    [Description("アルカナ解放ができません。")] CharacterCannotOpenCharacterCollection,

    [Description("LR+5以上のレアリティのキャラクターを獲得したことがありません。")]
    CharacterNotEverExistOverRarityLRPlus5,

    [Description("レアリティがSR、SR+以外のキャラクターが含まれています。")]
    CharacterNotRaritySROrSRPlus,

    [Description("LR+5以上のレアリティのキャラクターを所持していません。")]
    CharacterNotExistOverRarityLRPlus5,
    [Description("メモリー機能が開放されていません")] CharacterGetCharacterStoryRewardNotOpen,
    [Description("ランクアップ条件を満たしていません。")] CharacterNotEnoughRankUpRarityCondition,
    [Description("進化機能が解放されていません。")] CharacterRankUpNotOpen,
    [Description("解放されてないアルカナです。")] CharacterCollectionNotOpen,
    [Description("バトル結果が見つかりません。")] LocalRaidBattleResultNotFound = 172000,
    [Description("幻影の神殿がまだ解放されてありません。")] LocalRaidNotOpenLocalRaid,
    [Description("デッキデータが存在しません。")] LocalRaidNotFoundPlayerDeckData,
    [Description("レベルリンクデータが存在しません。")] LocalRaidNotFoundLevelLinkData,
    [Description("このバトルのデータは削除されました")] LocalRaidDeletedAccount,
    [Description("ユーザの訓練所データが存在しません")] TowerBattleTowerBattleDtoNotFound = 181000,
    [Description("ユーザ情報データが存在しません")] TowerBattleUserStatusDtoNotFound,
    [Description("購入回数上限を超えています")] TowerBattleOverPurchaseLimit = 182000,
    [Description("挑戦できないクエストです")] TowerBattleNotClearPreQuest,
    [Description("訓練所掃討条件を満たしていません")] TowerBattleNotEnoughQuestCondition,
    [Description("訓練所挑戦回数が足りません")] TowerBattleNotEnoughChallengeCount,
    [Description("存在しない塔の種類です")] TowerBattleNotFoundTowerType,
    [Description("キャラの属性が不正です。")] TowerBattleCharacterElementTypeIsInvalid,

    [Description("属性の塔の一日に進行できる階層の回数を超えています。")]
    TowerBattleLimitOverClearNewFloorPerDay,
    [Description("無窮の塔が解放されていません。")] TowerBattleNotOpen,
    [Description("属性の塔は解放されていません。")] TowerBattleElementTowerNotOpen,
    [Description("属性の塔はクリア済みの階に挑戦出来ません。")] TowerBattleElementTowerNotEnterAlreadyClearedFloor,
    [Description("無効な塔の種類です。")] TowerBattleInvalidTowerType,
    [Description("塔の層が存在しません。")] TowerBattleNotOpenQuest,
    [Description("ユーザーのギルドデータがありません")] GuildRaidUserGuildDtoNotFound = 191000,
    [Description("ギルドデータがありません")] GuildRaidGuildDtoNotFound,
    [Description("ユーザーステータスデータがありません")] GuildRaidUserStatusDtoNotFound,
    [Description("ユーザーのギルドレイドデータが存在します")] GuildRaidExistUserGuildRaidDto,
    [Description("ユーザーの放置バトルデータが存在しません。")] GuildRaidUserBattleAutoDtoNotFound,
    [Description("ギルドレイドデータが存在しません")] GuildRaidGuildRaidDtoNotFound,
    [Description("ユーザーのギルドレイドデータが存在しません")] GuildRaidUserGuildRaidDtoNotFound,
    [Description("操作権限がありません")] GuildRaidNotHavePermission = 192001,
    [Description("開始中のギルドレイドボスが存在します")] GuildRaidAlreadyOpenGuildRaid,
    [Description("ギルドレイド挑戦回数を超えています")] GuildRaidOverChallengeCount,
    [Description("開始中のギルドレイドボスが存在しません")] GuildRaidNotExistGuildRaidBoss,
    [Description("ギルドレイド開始に必要な名声が足りません。")] GuildRaidNotEnoughGuildFame,
    [Description("掃討機能は利用不可です。")] GuildRaidNotAvailableQuickStart,
    [Description("現在解放ボスに挑戦できません。")] GuildRaidNotAllowedChallengeReleasableBoss,
    [Description("ギルドから除名されています。")] GuildRaidRemovedGuildMember,
    [Description("個人報酬の情報が見つかりません。")] GuildRaidNormalDamageBarInfoNotFound = 192010,
    [Description("既にボスは解放済みです")] GuildRaidAlreadyOpened,
    [Description("ギルド設立後24時間は解放できません")] GuildRaidNotOpenYet,
    [Description("対象ワールド報酬のデータが存在しません。")] GuildRaidNotFoundGoalDamageWorldReward,
    [Description("目標ダメージが足りません。")] GuildRaidNotEnoughGoalDamage,
    [Description("受け取りずみのワールド報酬です。")] GuildRaidAlreadyRewardWorldItem,
    [Description("ギルドレイドの期限外です。")] GuildRaidNotOpenGuildRaid,
    [Description("ガチャ開催中です。")] GachaAlreadyBeenOpened = 200110,
    [Description("既にその聖遺物が選択されています。")] GachaAlreadySelectedGachaRelic = 200120,

    [Description("セレクトリストに設定するキャラクター数が多すぎます。")]
    GachaOverMaxCountSelectList = 200130,

    [Description("セレクトリスト対象外のキャラクターが選択されています。")]
    GachaOtherCharacterSelectList,

    [Description("セレクトリストに設定する同属性のキャラクター数が多すぎます。")]
    GachaOverMaxCountSameElementTypeSelectList,
    [Description("ガチャ期間外です。")] GachaOutOfDate = 200201,
    [Description("ガチャが解放されていません。")] GachaNotOpen,
    [Description("条件を満たしていません。")] GachaInvalidButton,
    [Description("キャラクター所持枠上限です。")] GachaHaveMaxCharacter,
    [Description("運命ガチャの解放条件を満たしていません。")] GachaNotEnoughVipLevelOrMaxQuestIdDestinyGacha,
    [Description("チュートリアルの条件を満たしていません。")] GachaInvalidTutorialGacha,
    [Description("武具ガチャの解放条件を満たしていません。")] GachaNotEnoughMaxQuestIdEquipmentGacha,
    [Description("ガチャを引く回数が足りません。")] GachaInvalidDrawCount,
    [Description("ガチャチケットの使用期限外です。")] GachaInvalidGachaTicketPeriod,

    [Description("運命のガチャのセレクトリスト対象外のキャラクターが選択されています。")]
    GachaOtherCharacterDestinySelectList,

    [Description("運命のガチャのセレクトリスト対象外のキャラクターが選択されています。")]
    GachaOtherCharacterStarsGuidanceSelectList,

    [Description("星の導きガチャの解放条件を満たしていません。")]
    GachaNotEnoughVipLevelOrMaxQuestIdStarsGuidanceGacha,

    [Description("選択ピックアップの対象外のキャラクターが選択されています。")]
    GachaOtherCharacterPickupSelectList,

    [Description("ピックアップの対象のキャラクターが選択されていません。")]
    GachaNotSelectedPickupCharacter,
    [Description("不正なセレクトリスト種別です。")] GachaInvalidSelectListType,
    [Description("ユーザーのステータスデータが存在しません。")] GachaUserStatusDtoNotFound = 200500,
    [Description("ユーザーの放置バトルデータが存在しません。")] GachaUserBattleAutoDtoNotFound,

    [Description("ユーザーのチュートリアルデータが存在しません。")]
    GachaUserTutorialDtoNotFound,

    [Description("ユーザーのセレクトリストデータが存在しません。")]
    GachaUserGachaSelectListDtoNotFound,
    [Description("バトルログが見つかりません。")] BattleCommonBattleLogNotFound = 220000,
    [Description("ユーザの装備データが存在しません。")] EquipmentUserEquipmentDtoNotFound = 231000,
    [Description("ユーザのステータスデータが存在しません。")] EquipmentUserStatusDtoNotFound,

    [Description("ユーザーのキャラクターデータが存在しません。")]
    EquipmentUserCharacterDtoNotFound = 231005,

    [Description("ユーザーのレベルリンクデータが存在しません。")]
    EquipmentUserLevelLinkDtoNotFound,

    [Description("ユーザーのチュートリアルデータが存在しません。")]
    EquipmentUserTutorialDtoNotFound,
    [Description("ユーザーの放置バトルデータが存在しません。")] EquipmentUserBattleAutoDtoNotFound,

    [Description("ユーザーの固定キャラクターデータが存在しません。")]
    EquipmentUserLockCharacterDtoNotFound,
    [Description("同じ種類の宝石は装備できません。")] EquipmentCanNotEquipSameKindSpheres = 232000,
    [Description("その部位には装備できません。")] EquipmentCanNotEquipOnThisPart,
    [Description("宝石スロットが存在しません。")] EquipmentMissingSphereSlot,
    [Description("宝石スロットはすべて解放されています。")] EquipmentSphereSlotAlreadyUnlockedAll,
    [Description("スロットの種類が違います。")] EquipmentDifferentSlotType,
    [Description("対象の装備がありません。")] EquipmentMissingEquipment,
    [Description("無効な神器融合のパターンです。")] EquipmentInvalidMergeSacredTreasurePattern,
    [Description("吸収に使用する素材がありません。")] EquipmentMissingAbsorbedMaterial,
    [Description("神器は消費できません。")] EquipmentCanNotConsumeSacredTreasure,
    [Description("装備不可能なキャラタイプです。")] EquipmentCharacterTypeCanNotBeEquipped,
    [Description("装備可能レベルを超えています。")] EquipmentExceedCanEquipLevel,
    [Description("他のキャラクターが装備しています。")] EquipmentEquippedByOtherCharacters,
    [Description("宝石が装着されている装備は選択できません。")] EquipmentCanNotSelectEquipmentWithSphere,
    [Description("限界まで強化済みです。")] EquipmentReinforcementLvAlreadyUpperLimit,
    [Description("通常武具は分解できません。")] EquipmentCanNotTakeApartNormalEquipment,
    [Description("通常武具以外は選択できません。")] EquipmentCanNotSelectSetAndExclusiveEquipment,
    [Description("装備中のアイテムは選択できません。")] EquipmentCanNotSelectEquippedItem,
    [Description("その武具は進化できません。")] EquipmentEquipmentCanNotEvolve = 232018,
    [Description("進化後装備情報が見つかりません。")] EquipmentEquipmentEvolutionInfoNotFound,

    [Description("指定した武具レアリティの付加パラメータ数が見つかりません。")]
    EquipmentAdditionalParameterCountNotFound,
    [Description("同一の武具IDを指定しています。")] EquipmentSpecifySameEquipmentGuid,
    [Description("VIPレベルが不足しています。")] EquipmentVipLvNotEnough,
    [Description("要求アイテムが存在しません。")] EquipmentRequiredItemIsNull,
    [Description("再分配する追加効果が存在しません。")] EquipmentNotFoundAdditionalParameterType,
    [Description("強化素材が不足しています。")] EquipmentReinforcementItemNotEnough,
    [Description("武具を装備してない部位です。")] EquipmentNotExistEquipment,
    [Description("装備できないスロットタイプです。")] EquipmentNotEqualEquipmentSlotType,
    [Description("宝石が不足しています。")] EquipmentGetComposeLackSphereResultFailed,
    [Description("強化レベルが上限を超えてしまいます。")] EquipmentInheritanceEquipmentFailed,

    [Description("セット武具進化に必要な強化レベルを満たしていません。")]
    EquipmentEvolutionSetPossibleLevel,

    [Description("専用武具進化に必要な強化レベルを満たしていません。")]
    EquipmentEvolutionExclusivePossibleLevel,

    [Description("装備中キャラクターのレアリティが条件を満たしていません。")]
    EquipmentEvolutionNotEnoughEquippingCharacterRarity,

    [Description("装備に必要なキャラクターレアリティを満たしていません。")]
    EquipmentEquipLREquipmentPossibleCharacterRarity,
    [Description("スフィア装着が解放されていません。")] EquipmentNotOpenSphereSetContent,
    [Description("宝石スロット開放数が異常です。")] EquipmentUnlockSphereSlotCountInvalid,
    [Description("武具進化機能の解放条件を満たしていません。")] EquipmentNotEnoughMaxQuestIdEvolution,
    [Description("神装強化機能の解放条件を満たしていません。")] EquipmentNotEnoughMaxQuestIdAscend,
    [Description("武具強化機能の解放条件を満たしていません。")] EquipmentNotEnoughMaxQuestIdStrength,
    [Description("武具研磨機能の解放条件を満たしていません。")] EquipmentNotEnoughMaxQuestIdRefine,
    [Description("無効なデッキ保存種別です。")] EquipmentInvalidLockEquipmentDeckType,
    [Description("装備固定のクールダウン中です。")] EquipmentLockEquipmentCooldownNow,
    [Description("装備固定機能が解放されていません。")] EquipmentLockEquipmentNotOpen,
    [Description("装備固定された武具データが存在しません。")] EquipmentLockEquipmentDtoNotFound,
    [Description("装備固定されたキャラクターが存在しません。")] EquipmentNotFoundLockCharacter,
    [Description("無効な装備固定誘導ダイアログ種別です。")] EquipmentInvalidLeadLockEquipmentDialogType,

    [Description("選択されたキャラクター数が登録可能数を超過しています。")]
    EquipmentOverMaxRegisterLockCharacterCount = 232048,
    [Description("ユーザのフレンドデータが存在しません。")] FriendUserFriendDtoNotFound = 241000,
    [Description("ユーザのステータスデータが存在しません。")] FriendUserStatusDtoNotFound,
    [Description("ユーザの放置バトルデータが存在しません。")] FriendUserBattleAutoDtoNotFound,

    [Description("ユーザーのフレンドミッションデータが存在しません。")]
    FriendUserFriendMissionDtoNotFound,
    [Description("ユーザーのアカウントデータが存在しません。")] FriendUserAccountDtoNotFound,
    [Description("ユーザデータが見つかりません。")] FriendUserDataNotFound = 242000,
    [Description("自分自身のIDを検索しようとしています。")] FriendCanNotSearchOwnPlayerId,
    [Description("ブロック可能人数上限に達しています。")] FriendBlockListFull,
    [Description("これ以上フレンドを増やすことはできません。")] FriendFriendsFull,
    [Description("指定したプレイヤーはブロックしていません。")] FriendNotBlockTargetPlayer,
    [Description("相手のフレンド数が一杯です")] FriendTargetPlayerFriendsFull,
    [Description("申請可能数上限です。")] FriendFriendApplyingFull,
    [Description("既にフレンドになっています。")] FriendAlreadyFriend,
    [Description("承認待ちのプレイヤーです。")] FriendAwaitingApprovalPlayer,
    [Description("対象プレイヤーをブロックしています。")] FriendTargetPlayerBlocked,
    [Description("対象プレイヤーはフレンドです。")] FriendTargetPlayerIsFriend,
    [Description("自身のIDを対象にしています。")] FriendTargetPlayerIdIsMine,
    [Description("FriendInfoTypeが無効です。")] FriendInvalidFriendInfoType,
    [Description("相手の申請待ち件数が一杯です。")] FriendTargetPlayerReceivedFriendsFull,
    [Description("既にフレンドポイントを送信しています。")] FriendAlreadySentFriendPoint,
    [Description("本日送信されていないかまたは受取済です。")] FriendNotSendOrAlreadyReceivedFriendPoint,
    [Description("一日の受取上限に達しています。")] FriendAlreadyMaxReceived,
    [Description("フレンドポイントの上限に達しています。")] FriendAlreadyMaxOwned,
    [Description("フレンドキャンペーンが開催されてないです。")] FriendNotOpenFriendCampaign,
    [Description("存在しないフレンドミッションです。")] FriendNotContainFriendCampaignMission,
    [Description("存在しないフレンドコードです。")] FriendNotExistFriendCode,

    [Description("条件が足りなくフレンドコードは入力できないです。")]
    FriendNotOpenFriendCode,

    [Description("コード入力できる新規ユーザーではありません。")]
    FriendUnusableAccount,
    [Description("コード入力可能な時間が過ぎました。")] FriendOverTimeFriendCode,
    [Description("もう招待コードを使用しました。")] FriendAlreadyUseFriendCode,
    [Description("自分のコードは使用できません。")] FriendCannotUseSelfFriendCode,
    [Description("違う国のコードは使用できません。")] FriendCannotUseAnotherTimeServerFriendCode,

    [Description("同じアカウントのコードは一回しか使用できません。")]
    FriendCannotUseSameUserFriendCode,
    [Description("コードの使用制限を超えました。")] FriendOverUseLimitFriendCode,
    [Description("ギルド申請のデータがありません。")] GuildJoinRequestDtoNotFound = 251000,
    [Description("ギルドデータがありません。")] GuildGuildDtoNotFound,
    [Description("ユーザーのギルドデータがありません。")] GuildUserGuildDtoNotFound,
    [Description("ギルドオプションデータがありません。")] GuildSystemChatOptionNotFound,
    [Description("標準化ギルド名データがありません。")] StandardGuildNameDtoNotFound,
    [Description("ギルドIDが無効です。")] GuildInvalidGuildId = 252000,
    [Description("権限が不足しています。")] GuildUserHasNoAuthority,
    [Description("既に存在するギルド名です。")] GuildAlreadyExistName,
    [Description("既にギルドに所属しています。")] GuildAlreadyBelong,
    [Description("申請が取り消されています。")] GuildCancelJoinRequest = 252005,
    [Description("ギルドのメンバーが満員です。")] GuildGuildMemberFull,
    [Description("ギルドに加入していないプレイヤーです。")] GuildInvalidTargetPlayer,
    [Description("リーダーは除名できません。")] GuildCanNotRemoveLeader,
    [Description("リーダー以外にギルドメンバーがいます。")] GuildExistMemberOtherThanLeader,
    [Description("戦闘力が不足しています。")] GuildNotEnoughBattlePower,
    [Description("ギルドへの申請数がいっぱいです。")] GuildApplyCountMax,
    [Description("クエスト進行が不足しています。")] GuildNotEnoughQuestId,
    [Description("一日に加入可能回数を超過しました。")] GuildDailyJoinedExceeded,
    [Description("既に加入申請しました")] GuildAlreadyApply,
    [Description("申請数がいっぱいです。")] GuildUserApplyCountMax,
    [Description("ギルド機能が開放されていません")] GuildGetGuildIdNotOpen,
    [Description("ギルドのメンバーが満員です。")] GuildApplyGuildGuildMemberFull,
    [Description("既にギルドに所属しています。")] GuildApplyGuildAlreadyBelong,
    [Description("ギルドに所属していません。")] GuildChangeLeaderNotBelongToGuild,
    [Description("ギルド名が入力されていません。")] GuildEmptyGuildName,
    [Description("ギルド名は10文字まで入力できます。")] GuildOverMaxLengthGuildName,
    [Description("使用できない単語が含まれています。")] GuildExistNgWordInGuildName,
    [Description("ギルド名保存処理に失敗しました。")] GuildFailToSaveGuildName,
    [Description("プレイヤーが見つかりません。")] RecruitGuildMemberNotFoundPlayer = 253000,
    [Description("ギルドメンバー数が上限です。")] RecruitGuildMemberUpperLimitMember,
    [Description("勧誘数が上限です。")] RecruitGuildMemberUpperLimitRecruitCount,
    [Description("プレイヤー側の勧誘数が上限です。")] RecruitGuildMemberUpperLimitRecruitCountOnPlayerSide,
    [Description("勧誘条件を満たしていません。")] RecruitGuildMemberNotMeetRequired,
    [Description("同じギルドに所属しているプレイヤーです。")] RecruitGuildMemberSameGuildPlayer,

    [Description("ギルド機能が開放されていないプレイヤーです。")]
    RecruitGuildMemberNotOpenGuild,
    [Description("プレイヤーが見つかりません。")] RecruitGuildMemberSearchNotFoundPlayer = 253010,

    [Description("サブマスターは1ギルドに1名のみ任命可能です。")]
    GuildAlreadyExistSubLeader,
    [Description("指揮官は1ギルドに1名のみ任命可能です。")] GuildAlreadyExistCommander,
    [Description("勧誘コメントの最大文字数を超過しています。")] RecruitGuildMemberOverMessageMaxLength,
    [Description("既に勧誘済みです。")] RecruitGuildMemberAlreadyRecruited,
    [Description("ユーザーデータが見つかりません。")] ShopCurrencyMissionDtoNotFound = 261000,
    [Description("ゲリラパックのデータが見つかりません。")] ShopGuerrillaPackDtoNotFound,
    [Description("ユーザデータが見つかりません。")] ShopFirstChargeBonusDtoNotFound,

    [Description("日付更新によりプレゼントボックスへ送られたか存在していない。")]
    ShopUserShopChargeBonusMissionDtoNotFound,
    [Description("ユーザデータが見つかりません。")] ShopUserAccountDtoNotFound,
    [Description("ユーザデータが見つかりません。")] ShopUserCurrencyMissionDtoNotFound,
    [Description("ユーザデータが見つかりません。")] ShopMonthlyBoostDtoNotFound,
    [Description("ユーザデータが見つかりません。")] ShopAchievementPackDtoNotFound,
    [Description("不正なリクエストです。")] ShopBuyProductInvalidRequest = 262000,
    [Description("VIPレベルが不足しています。")] ShopBuyProductNotEnoughVip,
    [Description("販売期間ではありません。")] ShopBuyProductNotOpen,
    [Description("上限回数購入済みです。")] ShopBuyProductBuyCountLimit,
    [Description("購入済みです。")] ShopBuyProductAlready,
    [Description("解放条件を満たしていません。")] ShopBuyProductNotEnoughChapterId,
    [Description("レシート検証に失敗しました。")] ShopInvalidReceipt,
    [Description("使用ずみのレシートです。")] ShopAlreadyUsedReceipt,
    [Description("補填ずみのレシートです。")] ShopAlreadyRecoveredReceipt,
    [Description("不正なリクエストです。")] ShopReceiveRewardInvalidRequest,
    [Description("必要条件を満たしていません。")] ShopReceiveAchievementPackRewardNotEnoughChapterId,
    [Description("必要条件を満たしていません。")] ShopReceiveAchievementPackRewardAlreadyReceive,
    [Description("期限が切れています。")] ShopMonthlyBoostExpired,
    [Description("既に受取済みです。")] ShopMonthlyBoostDailyRewardAlreadyGet,
    [Description("受取出来ません。")] ShopFirstChargeBonusNotReceived,
    [Description("不正なリクエストです。")] ShopFirstChargeBonusInvalidDay,
    [Description("不正な条件タイプです。")] ShopChargeBonusMissionTypeInvalid,
    [Description("ミッション情報が見つかりません。")] ShopChargeBonusMissionInfoNotFound,
    [Description("取得上限です。")] ShopLimitGetChargeBonus,
    [Description("不正なリクエストです。")] ShopEndChargeBonus,
    [Description("IOSレシート検証に失敗しました。")] ShopFailVerifyIOSReceipt,
    [Description("不正なリクエストです。")] ShopGrowthPackIsNotFree,
    [Description("レアリティ条件を満たしていません。")] ShopGrowthPackNotEnoughMaxRarity,
    [Description("コンテンツが解放されていません。")] ShopNotOpen,
    [Description("ダイヤが不足しています。")] ShopCurrencyNotEnough,
    [Description("既に受取済みです。")] ShopCurrencyMissionRewardAlreadyReceived,
    [Description("既に登録済です。")] ShopConfirmAgeAlreadyRegister = 262028,
    [Description("無料ではありません。")] ShopRewardIsNotFree,
    [Description("データが見つかりません。")] ShopGuerrillaPackInfoNotFound,
    [Description("アイテム情報が見つかりません。")] ShopCurrencyMissionItemInfoNotFound,
    [Description("アイテム情報が見つかりません。")] ShopAchievementPackItemInfoNotFound,
    [Description("課金情報と一致しないアカウントです。")] ShopInvalidAccount,
    [Description("購入条件を満たしてありません。")] ShopBuyProductNotEnoughCondition,
    [Description("表示期間条件が不正です。")] ShopInvalidDisplayPeriodType,

    [Description("IOS側の一時的な問題で復元処理を利用してください。")]
    ShopIosVerifyReceiptProblem,
    [Description("レシートデータが見つかりません。")] ShopNotFoundReceipt,
    [Description("課金処理セッションが切れました。")] ShopNotFoundSession,
    [Description("支払いが完了されてないです。")] ShopNotPaid,
    [Description("使用可能なクーポンデータが存在しません。")] ShopNotFoundCouponData,
    [Description("使用済みのクーポンです。")] ShopAlreadyUsedCoupon,

    [Description("ユーザーのステータスデータが見つかりません。")]
    ChatUserStatusDtoNotFound = 271000,

    [Description("ユーザーのアカウントデータが見つかりません。")]
    ChatUserAccountDtoNotFound,
    [Description("ユーザーのギルドデータが見つかりません。")] ChatUserGuildDtoNotFound,
    [Description("対象ユーザにブロックされています。")] ChatBlockedByTargetPlayer = 272000,
    [Description("時間の指定が無効です。")] ChatInvalidRequestTimeStamp,
    [Description("自分自身に送信することはできません。")] ChatPlayerCanNotSendChatToHimself,
    [Description("チャットの間隔が短すぎます。")] ChatSendMessageRestriction,
    [Description("チャット禁止中です")] ChatSendMessageBanChat,
    [Description("ギルドに参加していません。")] ChatNotBelongToGuild,
    [Description("指定されたチャット情報が存在しません。")] ChatNotFoundChatInfo,
    [Description("チャットを投稿した本人ではありません。")] ChatNotSendPlayer,
    [Description("無効なリアクション種別です。")] ChatNotDefinedReactionType,

    [Description("リアクションを付けることができないチャットです。")]
    ChatCanNotReact,
    [Description("既にアナウンスチャットに登録されています。")] ChatAlreadyRegistered,
    [Description("権限あるメンバーのみ使用可能です。")] ChatAnnounceHasNoAuthority,

    [Description("アナウンスに登録可能な最大数を超過しています。")]
    ChatOverMaxRegisterAnnounceChatCount,
    [Description("アナウンスチャットのインターバル中です。")] ChatGuildChatAnnounceInterval,
    [Description("未受け取りのプレゼントは削除できません。")] PresentDeleteNotReceivedPresent = 282001,
    [Description("削除済みのプレゼントは受け取れません。")] PresentReceiveDeletedPresent,
    [Description("プレゼントアイテムデータが存在しません。")] PresentItemListDataIsNull,

    [Description("プレゼントの受け取り期限を過ぎたため、受け取れませんでした。")]
    PresentReceiveExpiredPresent,

    [Description("アイテムが所持数上限に達しているため受け取れません。")]
    PresentReceiveOverLimitCountPresent,
    [Description("プレゼント機能が解放されていません。")] PresentNotOpen,
    [Description("受け取り済みのプレゼントは受け取れません。")] PresentReceiveAlreadyReceivedPresent,
    [Description("ユーザーのギルドデータが見つかりません。")] LocalGvgUserGuildDtoNotFound = 291000,

    [Description("ユーザーの放置バトルデータが見つかりません。")]
    LocalGvgUserBattleAutoDtoNotFound,
    [Description("ユーザーはギルドに入っていません。")] LocalGvgUserNotJoinGuild = 292000,
    [Description("報酬受け取りに失敗しました。")] LocalGvgReceiveRewardInvalidRequest,
    [Description("マッチング処理中です。")] LocalGvgNotMatchingYet,
    [Description("受け取れる報酬が見つかりませんでした。")] LocalGvgNotFoundReceivableReward,
    [Description("指定されたパーティが存在しません。")] LocalGvgNotFoundParty,
    [Description("ユーザーのギルドデータが見つかりません。")] GlobalGvgUserGuildDtoNotFound = 301000,
    [Description("ギルドデータが見つかりません。")] GlobalGvgGuildDtoNotFound,
    [Description("ユーザーはギルドに入っていません。")] GlobalGvgUserNotJoinGuild = 302000,
    [Description("報酬受け取りに失敗しました。")] GlobalGvgReceiveRewardInvalidRequest,
    [Description("受け取れる報酬が見つかりませんでした。")] GlobalGvgNotFoundReceivableReward = 302003,
    [Description("指定されたパーティが存在しません。")] GlobalGvgNotFoundParty,
    [Description("ユーザのレベルリンクデータが見つかりません")] LevelLinkUserLevelLinkDtoNotFound = 311000,
    [Description("ユーザのキャラクターデータが見つかりません")] LevelLinkUserCharacterDtoNotFound,

    [Description("ユーザのレベルリンクメンバーデータが見つかりません")]
    LevelLinkUserLevelLinkMemberDtoNotFound,
    [Description("ユーザの情報データが見つかりません")] LevelLinkUserStatusDtoNotFound,
    [Description("セットずみのキャラクターが含まれています")] LevelLinkAlreadySetCharacter = 312000,
    [Description("セットできるメンバー数を超えました")] LevelLinkOverMember,
    [Description("パーティーレベルがもう最大です")] LevelLinkAlreadyMaxPartyLevel,

    [Description("条件を満たしているベースメンバー数が足りません")]
    LevelLinkNotEnoughMaxLevelBaseMember,
    [Description("メンバー枠の最大数を超えました")] LevelLinkOverMemberCount,

    [Description("パーティーレベルモードが開放されていません。")]
    LevelLinkNotPartyLevelModeOpen = 312008,
    [Description("通話での開放限度数を超過しました。")] LevelLinkOverOpenSlotCountWithCurrency,
    [Description("すでに パーティーモードです。")] LevelLinkAlreadyPartyMode,
    [Description("レベルリンク機能が開放されていません")] LevelLinkNotOpen,
    [Description("VipLvが不足しています")] VipBuyVipGiftNotEnoughVipLv = 322000,
    [Description("購入済みです")] VipBuyVipGiftAlreadyBuy,
    [Description("商品データが存在しません")] VipBuyVipGiftInvalidRequestVipGiftId,
    [Description("取得済みです")] VipGetDailyGiftAlreadyGet,
    [Description("ユーザーのステータスデータが存在しません。")] LoginBonusUserStatusDtoNotFound = 331000,

    [Description("ユーザーの月間ログインボーナス情報が存在しません。")]
    LoginBonusUserMonthlyLoginBonusDtoNotFound,

    [Description("ユーザーの期間限定ログインボーナス情報が存在しません。")]
    LoginBonusUserLimitedLoginBonusDtoNotFound,
    [Description("既に受け取り済みの日別報酬です。")] LoginBonusAlreadyReceivedDailyReward = 332000,
    [Description("未来の報酬は受け取れません。")] LoginBonusReceiveFutureReward,
    [Description("過去受取可能数が不足しています。")] LoginBonusReceivablePastRewardCountNotEnough,
    [Description("日別報酬情報が存在しません。")] LoginBonusDailyRewardInfoIsNull,
    [Description("既に受け取り済みの合計ログイン報酬です。")] LoginBonusAlreadyReceivedLoginCountReward,
    [Description("合計ログイン日数が不足しています。")] LoginBonusLoginCountNotEnough,
    [Description("合計ログイン報酬情報が存在しません。")] LoginBonusLoginCountRewardInfoIsNull,

    [Description("期間限定ログインボーナスが解放されていません。")]
    LoginBonusLimitedLoginBonusNotOpen = 332101,

    [Description("期間限定ログインボーナスが開催されていません。")]
    LoginBonusLimitedLoginBonusNotHeld,
    [Description("特別報酬が存在しません。")] LoginBonusNotExistSpecialReward,
    [Description("既に特別報酬は受け取り済みです。")] LoginBonusAlreadyReceivedSpecialReward,
    [Description("ユーザーデータが存在しません。")] NoticeUserAccountDtoNotFound = 341001,

    [Description("指定のお知らせアクセス種別が定義されていません")]
    NoticeNotDefinedNoticeAccessType = 342001,

    [Description("指定のお知らせカテゴリーが定義されていません。")]
    NoticeNotDefinedNoticeCategoryType,

    [Description("指定のお知らせカテゴリーはタイトルから取得できません。")]
    NoticeCanNotGetNoticeAccessCategoryInTitle,
    [Description("指定の言語種別が定義されていません。")] NoticeNotDefinedLanguageType,
    [Description("ユーザーのミッションデータが存在しません。")] MissionUserMissionDtoNotFound = 351000,
    [Description("ユーザーのミッションデータが存在しません。")] MissionUserMissionActivityDtoNotFound,
    [Description("ユーザーの放置バトルデータが存在しません。")] MissionUserBattleAutoDtoNotFound,

    [Description("ユーザーのチュートリアルデータが存在しません。")]
    MissionUserTutorialDtoNotFound,

    [Description("ユーザーのミッション履歴データが存在しません。")]
    MissionUserMissionOccurrenceHistoryDtoNotFound,
    [Description("ユーザーのボスバトルデータが存在しません。")] MissionUserBattleBossDtoNotFound,
    [Description("未解放のミッションです。")] MissionNotOpenMission = 352000,
    [Description("報酬が受け取れません。")] MissionNotReceivedMission,
    [Description("要求値を満たしていません。")] MissionNotEnoughRequireCount,
    [Description("存在しない報酬タイプです。")] MissionNotExistRewardType,
    [Description("購入できないミッションです。")] MissionMBNotAchievementType,
    [Description("通貨が不足しています。")] MissionNotEnoughCurrency,
    [Description("存在しないミッショングループタイプです。")] MissionNotExistMissionGroupType,
    [Description("MBがない、または達成済です。")] MissionActivityMBNotFoundOrAlreadyAchieved,
    [Description("受取出来ません。")] MissionActivityRewardNotReceived,
    [Description("存在しないシート番号です。")] MissionNotExistSheetNo = 352021,
    [Description("存在しないビンゴ種別です。")] MissionNotExistBingoType,
    [Description("受け取り済みのビンゴ報酬です。")] MissionAlreadyReceivedBingoReward,
    [Description("ビンゴが達成出来ていません。")] MissionNotCompletedBingo,
    [Description("ビンゴ報酬が存在しません。")] MissionNotFoundBingoReward,
    [Description("前のシートをクリアしていません。")] MissionNotClearedPrevSheetMission,

    [Description("ギルドツリーイベント終了後にギルドに加入したためミッションを開けません。")]
    MissionJoinGuildAfterEndEvent = 352030,
    [Description("ユーザーの放置バトルデータが存在しません。")] TradeShopUserBattleAutoDtoNotFound = 361000,
    [Description("ユーザーの放置バトルデータが存在しません。")] TradeShopUserStatusDtoNotFound,
    [Description("ユーザーの交換所データが存在しません。")] TradeShopUserTradeShopDtoNotFound,
    [Description("購入できない景品です。")] TradeShopInvalidTradeShopItem = 362000,
    [Description("購入可能な時間が過ぎました。")] TradeShopLimitTimeOver,
    [Description("購入制限を超えました。")] TradeShopOverLimitBuyCount,
    [Description("手動更新できないタブです。")] TradeShopInvalidResetType,
    [Description("利用できないタブです。")] TradeShopIsHideTab,
    [Description("有効期間ではありません。")] TradeShopNotOpen,

    [Description("受け取り可能なランキング到達報酬データが存在しません。")]
    RankingWorldReceivableRankingRewardDtoNotFound = 371000,
    [Description("ランキングが解放されていません。")] RankingNotOpenRankingContent = 372000,
    [Description("受け取り出来ないランキング到達報酬です。")] RankingCanNotReceiveReward,
    [Description("既に受け取り済みのランキング到達報酬です。")] RankingAlreadyReceivedRankingReward,
    [Description("ランキング到達報酬が解放されていません。")] RankingNotOpenAchieveRankingReward,
    [Description("パネル図鑑表示期間外です。")] PanelNotStarted = 382000,
    [Description("無条件で解放されているパネルです。")] PanelUnlockFreePanel,
    [Description("既に解放しているパネルです。")] PanelAlreadyUnlocked,
    [Description("ユーザーの楽曲データが存在しません。")] MusicUserMusicDtoNotFound = 391000,

    [Description("ユーザーのプレイリストデータが存在しません。")]
    MusicUserPlaylistDtoNotFound,
    [Description("楽曲再生が解放されていません。")] MusicNotOpenMusicContent = 392000,
    [Description("プレイリストの上限を超えています。")] MusicOverMaxPlaylistCount,
    [Description("プレイリスト名が入力されていません。")] MusicEmptyPlaylistName,
    [Description("プレイリストは15文字まで入力できます。")] MusicOverMaxLengthPlaylistName,
    [Description("使用できない単語が含まれています。")] MusicExistNgWordInPlaylistName,
    [Description("購入済みです。")] MusicAlreadyBuyMusic,
    [Description("不正な楽曲IDです。")] MusicInvalidMusicId,
    [Description("プレイリストの曲数上限を超えています。")] MusicOverMaxPlaylistMusicCount,
    [Description("ユーザーのアカウント情報が存在しません")] TutorialAccountDtoNotFound = 401000,
    [Description("ユーザーのステータス情報が存在しません")] TutorialUserStatusDtoNotFound,
    [Description("ユーザーの放置バトル情報が存在しません")] TutorialUserBattleAutoDtoNotFound,
    [Description("ユーザーのデッキ情報が存在しません")] TutorialUserDeckDtoNotFound,
    [Description("不正なリクエストです")] TutorialOpenContentInvalidRequest = 402000,
    [Description("演出再生済みです")] TutorialOpenContentAlready,
    [Description("不正なチュートリアルIDです")] TutorialClearTutorialInvalidTutorialId,
    [Description("既に達成済みのチュートリアルです")] TutorialClearTutorialAlreadyCleared,
    [Description("スキップ対象のチュートリアルが存在しません")] TutorialSkipTutorialIdIsNullOrEmpty,
    [Description("スキップの条件を満たしていません")] TutorialNotEnoughSkipCondition,
    [Description("ユーザーのギルドツリー情報が存在しません。")] GuildTowerUserGuildTowerDtoNotFound = 410000,
    [Description("ユーザーのキャラ情報が存在しません。")] GuildTowerUserCharacterDtoNotFound,
    [Description("ユーザーのギルド情報が存在しません。")] GuildTowerUserGuildDtoNotFound,
    [Description("ユーザー情報が存在しません。")] GuildTowerUserStatusDtoNotFound,
    [Description("ギルドツリー情報が存在しません。")] GuildTowerGuildTowerDtoNotFound,
    [Description("ギルドツリー前勝利データが存在しません。")] GuildTowerUserGuildTowerPreviousEntryInfoDtoNotFound,
    [Description("ギルドツリーギルドデータが存在しません。")] GuildTowerGuildDtoNotFound,
    [Description("ギルドツリーイベントが開催されていません。")] GuildTowerNotOpenEvent = 412000,
    [Description("ユーザーがギルドに所属していません。")] GuildTowerNotBelongToGuild,
    [Description("ギルドツリーの挑戦回数が足りません。")] GuildTowerNotEnoughChallengeCount,
    [Description("存在しないキャラが含まれています。")] GuildTowerNotFoundCharacter,
    [Description("エントリータイプが不正です。")] GuildTowerInvalidGuildTowerEntryType,
    [Description("持ってないキャラが含まれています。")] GuildTowerInvalidCharacter,
    [Description("登録キャラリストが空いています。")] GuildTowerEmptyEntryCharacter,
    [Description("日付が変わるまでは使えません。")] GuildTowerNotChangeDay,
    [Description("挑戦できる階層ではありません。")] GuildTowerInvalidChallengeFloor,
    [Description("選択できない難易度です。")] GuildTowerInvalidDifficulty,
    [Description("不正な職業種別です。")] GuildTowerInvalidJobFlags = 412100,
    [Description("次の職業レベルデータが存在しません。")] GuildTowerNotFoundNextJobLevelData,
    [Description("職業強化に失敗しました。")] GuildTowerFailedToReinforceJob,
    [Description("レベルキャップ制限により強化出来ません。")] GuildTowerLimitReinforcementJobLevelCap,
    [Description("最大レベルのためこれ以上強化できません。")] GuildTowerReachedMaxReinforcementJobLevel,
    [Description("登録してないキャラが含まれています。")] GuildTowerInvalidEntryCharacter,

    [Description("ほかのギルドメンバーのバトルが終わっていません。")]
    GuildTowerNotYetEndBattle,

    [Description("ギルドツリーのギルド全体の挑戦回数が足りません。")]
    GuildTowerNotEnoughGuildChallengeCount,
    [Description("ギルドに参加した日は挑戦できません。")] GuildTowerCannotChallengeOnJoinGuildDate,

    [Description("タイプ強化を行ったプレイヤーが存在しません。")]
    GuildTowerNotFoundReinforceJobPlayer,
    [Description("クリアされた階層です。")] GuildTowerAlreadyClearFloor,

    [Description("まだクリアされていない階層の報酬は受け取れません。")]
    GuildTowerCanNotReceiveNotClearedFloorReward = 412200,
    [Description("既に受け取り済みの階層報酬です。")] GuildTowerAlreadyReceivedFloorReward,

    [Description("イベント終了後にギルドに加入したため階層報酬を受け取ることができません。")]
    GuildTowerJoinedGuildAfterEndEvent,
    [Description("個別通知キャッシュ情報が存在しません")] IndividualNotificationCacheDtoNotFound = 421000,
    [Description("ユーザーの個別通知情報が存在しません")] IndividualNotificationDtoNotFound,
    [Description("星導交換所情報が存在しません")] StarsGuidanceTradeShopDtoNotFound = 431000,
    [Description("星導交換所が開催されていません。")] StarsGuidanceTradeShopNotOpen = 432000,
    [Description("星導交換所機能は使えません。")] StarsGuidanceTradeShopUnavailable,
    [Description("交換元アイテム情報が不正です。")] StarsGuidanceTradeShopConsumeItemInvalid,
    [Description("交換制限を超えました。")] StarsGuidanceTradeShopOverLimitTradeCount,
    [Description("存在しないTreasureChestです。")] ItemOpenTreasureChestIdNotFound = 602004,
    [Description("存在しないTreasureChestです。")] ItemOpenTreasureChestItemNotFound,
    [Description("開ける数が少なすぎます。")] ItemOpenTreasureChestCountTooLittle,
    [Description("この宝箱は報酬を選択できません。")] ItemOpenTreasureChestCanNotSelect,
    [Description("この宝箱は報酬を選択してください。")] ItemOpenTreasureChestNotSelected,
    [Description("変換する数が足りません")] ItemNotEnoughChangeItemCount,
    [Description("抽選タイプが不正です。")] ItemNotMatchLotteryType,
    [Description("アイテムの終了日が不正です。")] ItemInvalidEndTime,
    [Description("宝箱の抽選アイテムが存在しません。")] ItemGetLotteryItemListGachaLotteryItemListInfoListIsEmpty = 602014,

    [Description("宝箱の抽選リストタイプが定義されていません。")]
    ItemOpenTreasureChestTreasureChestItemListTypeNotDefined,
    [Description("宝箱の抽選タイプが定義されていません。")] ItemOpenTreasureChestTreasureChestLotteryTypeNotDefined,
    [Description("リクエストの値が範囲外です。")] ItemOpenTreasureChestIndexOutOfRange,
    [Description("宝箱の抽選アイテムが存在しません。")] ItemOpenTreasureChestStaticItemIsNull,
    [Description("天井対象のアイテムが存在しません。")] ItemOpenTreasureChestCeilingTargetItemNotFound,
    [Description("特別アイコンアイテムが存在しません。")] ItemSpecialIconItemNotFound,
    [Description("ゴールド交換は解放されていません。")] ItemGoldExchangeNotOpen,
    [Description("不正なリクエストです")] ItemUsingInvalidItems,
    [Description("LocalRaidで解散に失敗した")] MagicOnionLocalRaidDisbandRoomFailed = 900102,

    [Description("LocalRaidで他の部屋に参加しているので参加に失敗した")]
    MagicOnionLocalRaidJoinRoomAlreadyJoinedOtherRoom,

    [Description("LocalRaidで残り挑戦回数が不足していて参加に失敗した")]
    MagicOnionLocalRaidJoinRoomNoRemainingChallenges,

    [Description("LocalRaidで部屋が存在してなくて参加に失敗した")]
    MagicOnionLocalRaidJoinRoomNotExistRoom,

    [Description("LocalRaidでチームが満員で参加に失敗した")]
    MagicOnionLocalRaidJoinRoomMembersAreFull,

    [Description("LocalRaidで戦闘力不足で参加に失敗した")]
    MagicOnionLocalRaidJoinRoomNotEnoughBattlePower,

    [Description("LocalRaidでパスワードが不正で参加に失敗した")]
    MagicOnionLocalRaidJoinRoomWrongPassword,

    [Description("LocalRaidでRedis処理エラーで参加に失敗した")]
    MagicOnionLocalRaidJoinRoomRedisError,
    [Description("LocalRaidで脱退に失敗した")] MagicOnionLocalRaidLeaveRoomFailed,

    [Description("LocalRaidで部屋が存在してなくて脱退に失敗した")]
    MagicOnionLocalRaidLeaveRoomNotExistRoom,

    [Description("LocalRaidでリーダーなので脱退に失敗した")]
    MagicOnionLocalRaidLeaveRoomIsLeader,

    [Description("LocalRaidでデータの取得に失敗して脱退に失敗した")]
    MagicOnionLocalRaidLeaveRoomNotFoundData,

    [Description("LocalRaidでRedis処理エラーで脱退に失敗した")]
    MagicOnionLocalRaidLeaveRoomRedisError,

    [Description("LocalRaidで他の部屋に参加しているので作成に失敗した")]
    MagicOnionLocalRaidOpenRoomAlreadyJoinedOtherRoom,

    [Description("LocalRaidで開催していないクエストを参照したので作成に失敗した")]
    MagicOnionLocalRaidOpenRoomQuestNotHeld,

    [Description("LocalRaidで残り挑戦回数が不足していて作成に失敗した")]
    MagicOnionLocalRaidOpenRoomNoRemainingChallenges,
    [Description("LocalRaidでバトル開始に失敗した")] MagicOnionLocalRaidStartBattleFailed,

    [Description("LocalRaidでデータの取得に失敗してバトル開始に失敗した")]
    MagicOnionLocalRaidStartBattleNotFoundData,

    [Description("LocalRaidで開催期間が終了していてバトル開始に失敗した")]
    MagicOnionLocalRaidStartBattleExpiredLocalRaidQuest,
    [Description("LocalRaidで追放に失敗した")] MagicOnionLocalRaidRefuse,

    [Description("LocalRaidでデータの取得に失敗して追放に失敗した")]
    MagicOnionLocalRaidRefuseNotFoundData,

    [Description("LocalRaidでRedis処理エラーで追放に失敗した")]
    MagicOnionLocalRaidRefuseRedisError,

    [Description("LocalRaidで部屋が存在してなくて追放に失敗した")]
    MagicOnionLocalRaidRefuseNotExistRoom,

    [Description("LocalRaidでフレンド以外を誘って勧誘に失敗した")]
    MagicOnionLocalRaidInviteNotFriend,

    [Description("LocalRaidでデータの取得に失敗して勧誘に失敗した")]
    MagicOnionLocalRaidInviteNotFoundData,

    [Description("LocalRaidでデータの取得に失敗してフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomNotFoundData,

    [Description("LocalRaidで他の部屋に参加しているのでフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomAlreadyJoinedOtherRoom,

    [Description("LocalRaidで残り挑戦回数が不足していてフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomNoRemainingChallenges,

    [Description("LocalRaidでチームが満員でフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomMembersAreFull,

    [Description("LocalRaidでRedis処理エラーでフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomRedisError,

    [Description("LocalRaidで部屋が存在してなくてフレンドの部屋への参加に失敗した")]
    MagicOnionLocalRaidJoinFriendRoomNotExistRoom,

    [Description("LocalRaidで他の部屋に参加しているのでランダム参加に失敗した")]
    MagicOnionLocalRaidJoinRandomRoomAlreadyJoinedOtherRoom,

    [Description("LocalRaidで残り挑戦回数が不足していてランダム参加に失敗した")]
    MagicOnionLocalRaidJoinRandomRoomNoRemainingChallenges,

    [Description("LocalRaidで部屋が存在してなくてランダム参加に失敗した")]
    MagicOnionLocalRaidJoinRandomRoomNotExistRoom,

    [Description("LocalRaidでRedis処理エラーでランダム参加に失敗した")]
    MagicOnionLocalRaidJoinRandomRoomRedisError,

    [Description("LocalRaidで開催期間が終了していて解散された")]
    MagicOnionLocalRaidExpiredLocalRaidQuest,

    [Description("LocalRaidで残り挑戦回数が不足していて勧誘に失敗した")]
    MagicOnionLocalRaidInviteNoRemainingChallenges,

    [Description("LocalRaidで開催されているクエストないので失敗しました")]
    MagicOnionLocalRaidNotOpenQuest,

    [Description("LocalRaidでリーダーなので準備変更に失敗した")]
    MagicOnionLocalRaidReadyIsLeader,

    [Description("LocalRaidで準備完了ではないユーザがいる")]
    MagicOnionLocalRaidAllNotReady,
    [Description("LocalRaidで準備完了に失敗した")] MagicOnionLocalRaidReadyFailed,

    [Description("LocalRaidで部屋が存在してなくて準備完了に失敗した")]
    MagicOnionLocalRaidReadyNotExistRoom,

    [Description("LocalRaidでデータの取得に失敗して準備完了に失敗した")]
    MagicOnionLocalRaidReadyNotFoundData,

    [Description("LocalRaidでRedis処理エラーでフ準備完了に失敗した")]
    MagicOnionLocalRaidReadyRedisError,

    [Description("LocalRaidでルーム参加条件変更に失敗した")]
    MagicOnionLocalRaidUpdateRoomConditionFailed,

    [Description("LocalRaidでリーダーではないのでルーム参加条件変更に失敗した")]
    MagicOnionLocalRaidUpdateRoomConditionIsNotLeader,

    [Description("LocalRaidでRedis処理エラーでフルーム参加条件変更に失敗した")]
    MagicOnionLocalRaidUpdateRoomConditionRedisError,
    [Description("LocalRaidで戦闘力更新に失敗した")] MagicOnionLocalRaidUpdateBattlePowerFailed = 900150,

    [Description("LocalRaidで部屋が存在してなくて戦闘力更新に失敗した")]
    MagicOnionLocalRaidUpdateBattlePowerNotExistRoom,

    [Description("LocalRaidでデータの取得に失敗して戦闘力更新に失敗した")]
    MagicOnionLocalRaidUpdateBattlePowerNotFoundData,

    [Description("LocalRaidでRedis処理エラーでフ戦闘力更新に失敗した")]
    MagicOnionLocalRaidUpdateBattlePowerRedisError,

    [Description("LocalRaidで戦闘力不足でバトル開始に失敗した")]
    MagicOnionLocalRaidStartBattleNotEnoughBattlePower,

    [Description("LocalRaidで違うワールドのルームに入ろうとして失敗した")]
    MagicOnionLocalRaidJoinRoomNotSameWorld,

    [Description("LocalRaidでバトルデータが足りなくてバトル開始を失敗した")]
    MagicOnionLocalRaidNotEnoughBattleData,

    [Description("GlobalGvgで不正なリクエストによってパーティ追加に失敗した")]
    MagicOnionGlobalGvgAddCastlePartyInvalidRequest = 900302,

    [Description("GlobalGvgでデータの不整合によってパーティ追加に失敗した")]
    MagicOnionGlobalGvgAddCastlePartyInvalidData,

    [Description("GlobalGvgで配置できない城に配置しようとしてパーティ追加に失敗した")]
    MagicOnionGlobalGvgAddCastlePartyNotOwnCastle,

    [Description("GlobalGvgで行動力が不足してパーティ追加に失敗した")]
    MagicOnionGlobalGvgAddCastlePartyNotEnoughActionPoint,

    [Description("GlobalGvgで同じユニットを配置しようとしてパーティ追加に失敗した")]
    MagicOnionGlobalGvgAddCastlePartySameCharacter,

    [Description("GlobalGvgで先頭のパーティを操作しようとしてパーティ並び替えに失敗した")]
    MagicOnionGlobalGvgOrderCastlePartyFirst,

    [Description("GlobalGvgでデータの不整合によってパーティ並び替えに失敗した")]
    MagicOnionGlobalGvgOrderCastlePartyInvalidData,

    [Description("GlobalGvgでデータの不整合によって宣戦に失敗した")]
    MagicOnionGlobalGvgCastleDeclarationInvalidData,

    [Description("GlobalGvgで隣接していない城に宣戦しようとして宣戦に失敗した")]
    MagicOnionGlobalGvgCastleDeclarationDistant,

    [Description("GlobalGvgですでに他のギルドに宣戦されている城に宣戦しようとして宣戦に失敗した")]
    MagicOnionGlobalGvgCastleDeclarationByOtherGuild,

    [Description("GlobalGvgで宣戦の上限数を超えて宣戦しようとして宣戦に失敗した")]
    MagicOnionGlobalGvgCastleDeclarationMaxCount,

    [Description("GlobalGvgでデータの不整合によって反撃に失敗した")]
    MagicOnionGlobalGvgCastleDeclarationCounterInvalidData,

    [Description("GlobalGvgでギルドに加入してないエラー")]
    MagicOnionGlobalGvgCheckCanJoinBattleAndNoticeNotJoinGuild,

    [Description("GlobalGvgでギルドに加入した日は参加できないエラー")]
    MagicOnionGlobalGvgCheckCanJoinBattleAndNoticeJoinGuildToDay,

    [Description("GlobalGvgで権限がないメンバーは操作できないエラー")]
    MagicOnionGlobalGvgCheckCanJoinBattleAndNoticeHasNoPermission,
    [Description("GlobalGvgが開放されていない")] MagicOnionGlobalGvgNotOpen,

    [Description("GlobalGvgでキャラクターのキャッシュデータが存在しないためパーティ追加に失敗しました。")]
    MagicOnionGlobalGvgAddCastlePartyNotFoundCharacterCache,
    [Description("認証に失敗しました。")] MagicOnionAuthenticationFail = 1000000,
    [Description("プレイヤーの情報を見つけません。")] MagicOnionNotFoundPlayerInfo,
    [Description("ユーザーIDの取得に失敗しました。")] MagicOnionFailedToGetUserId,
    [Description("ギルドに入ってないです。")] MagicOnionNotJoinGuild = 1001000,
    [Description("チャットの内容が長すぎです。")] MagicOnionChatLimitOver,
    [Description("チャットは連投できません。")] MagicOnionRepeatTimeOver,
    [Description("メッセージの送信に失敗しました。")] MagicOnionFailSendMessage,
    [Description("チャット禁止中です")] MagicOnionBanChat,
    [Description("不正な城のIdです。")] MagicOnionInvalidCastleId = 1002000,
    [Description("配置できない城です。")] MagicOnionCannotSetCastle,
    [Description("行動力が足りません。")] MagicOnionNotEnoughActionPoint,

    [Description("同じキャラクターを1つの城に2回以上配置できません。")]
    MagicOnionAlreadySetCharacter,
    [Description("先頭のパーティは操作できません。")] MagicOnionCannotControllFirstParty,
    [Description("データが不正です。")] MagicOnionInvalidData,
    [Description("キャッシュデータが存在しません。")] MagicOnionNotFoundCache,
    [Description("隣接した城ではありません。")] MagicOnionNotNeighborCastle,
    [Description("すでに他のギルドに宣戦されています。")] MagicOnionAlreadySelectedOtherGuild,
    [Description("これ以上宣戦できません。")] MagicOnionCannotAttackOtherGuild,

    [Description("ギルドに加入した日はLocalGvgに参加できません。")]
    MagicOnionCannotPlayLocalGvgInFirstDay,

    [Description("この機能は権限あるメンバーのみ実行できます。")]
    MagicOnionHasNoPermission,

    [Description("ギルドバトルの参加条件を満たしていないです。")]
    MagicOnionNotJoinedGuildBattle,
    [Description("宣戦する条件を満たしていないです。")] MagicOnionCanNotDeclaration,

    [Description("キャラクターのキャッシュデータが存在しません。")]
    MagicOnionNotFoundCharacterCache,
    [Description("作戦時間前のためまだ布告できません。")] MagicOnionBeforeDeclarationTime,
    [Description("ギルドバトルが開催されていません。")] MagicOnionNotOpenGuildBattle,

    [Description("キャラクターのキャッシュデータが存在しないためパーティの配置に失敗しました。")]
    MagicOnionLocalGvgAddPartyNotFoundCharacterCache,
    [Description("拠点メモは設定できません。")] MagicOnionCanNotSetCastleMemo,
    [Description("拠点メモの設定の権限がありません。")] MagicOnionHasNoPermissionSetCastleMemo,

    [Description("拠点メモメッセージの最大文字数を超過しています。")]
    MagicOnionOverCastleMemoMessageMaxLength,

    [Description("既に他のメンバーにより、拠点メモがリセット済みです。")]
    MagicOnionAlreadyResetCastleMemo,
    [Description("プッシュ通知対象外の端末です。")] PushNotificationNotSupportedDeviceType = 4000000,

    [Description("プッシュ通知の登録に必要な情報が取得できません。")]
    InvalidDeviceToken,
    [Description("不正なリクエストです。")] InvalidRemoteNotificationIgnoreTypes,
    [Description("不正なリクエストです。")] NotSupportedRemoteNotificationIgnoreType,
    [Description("不正なリクエストです。")] PushNotificationNotDefinedLanguageType,

    [Description("DMM GAME PLAYERからゲームを起動しなおしてください。")]
    DmmOneTimeTokenExpired = 5000100,
    [Description("不正なリクエストです。")] DmmFailedToGetParamFromHeader,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmApiRequestFailedAuthCheckLogin,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmApiRequestFailed,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmApiRequestResultNotZero,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmApiRequestFailedIssueOneTimeToken,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmApiRequestFailedIdLinkage,

    [Description("DMM GAMESとの連携時にエラーが発生しました。")]
    DmmMultiViewerIdLinkageRequested,

    [Description("DMM GAMESとの連携機能がメンテナンス中です。")]
    DmmUnderMaintenance,

    [Description("DMM GAMESとの連携情報が見つかりません。")]
    DmmDataLinkageInfoNotFound,

    [Description("他のアカウントデータとDMMアカウントが連携しています。再度このアカウントデータとDMMアカウントを連携させてください。")]
    DmmDataLinkageNotActive,

    [Description("DMM GAMESとの連携情報が見つかりません。")]
    DmmFailedToGetViewerId,
    [Description("DMM ポイント確認に失敗しました。")] DmmApiRequestFailedAuthCheckPoint = 5000200,

    [Description("DMM月額課金サービスデータがそんざいしません。")]
    DmmApiRequestNotFoundDmmSubscription,
    [Description("DMMのデバイスではありません。")] DmmApiRequestNotDmmDeviceType,

    [Description("Stripe プレイヤーIDが存在しません。")]
    StripeNotFoundGivePlayerId = 5010000,
    [Description("Stripe MbIDが存在しません。")] StripeNotFoundMbId,

    [Description("Stripe ProductIdが存在しません。")]
    StripeNotFoundProductId,

    [Description("Stripe ShopProductTypeが存在しません。")]
    StripeNotFoundShopProductType,

    [Description("Stripe DeviceTypeが存在しません。")]
    StripeNotFoundDeviceType,

    [Description("Stripe InvoiceIdが存在しません。")]
    StripeNotFoundInvoiceId,
    [Description("Stripe 決済されてないです。")] StripeNotPaidPaymentStatus,

    [Description("Stripe 課金処理に問題が発生しました。")]
    StripeNotFoundCurrencyDataBase,
    [Description("Stripe 課金処理情報が存在しません。")] StripeNotFoundPaymentInfo,
    [Description("Stripe 存在しない国課金コードです。")] StripeNotFoundCurrencyCode,
    [Description("Stripe 決済できない金額です。")] StripeInvalidPrice,
    [Description("Stripe 顧客情報が存在しません。")] StripeNotFoundCustomerInfo,
    [Description("Stripe ポイントが足りません。")] StripeNotEnoughPoint,

    [Description("Stripe セッションデータがありません。")]
    StripeNotFoundSession
}