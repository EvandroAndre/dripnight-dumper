using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public static class UINavigationUtil
{
	public enum UINavigationFrom
	{
		None = 0,
		Lobby = 1,
		DeepLink = 2,
		Activity = 3,
		IAP = 4,
		LobbyAds = 5,
		LobbyExtraAds = 6,
		MallAds = 7,
		Announcement = 8,
		SplashBanner = 9,
		RollNotice = 10,
		FriendReunionReward = 11,
		ActivityReward = 12,
		Debt = 13,
		ElitePass = 14,
		FirstTimePayment = 15,
		MatchAfterLottery_OpenAll = 16,
		MatchAfterLottery_OpenOne = 17,
		Clan = 18,
		UnlockSkill = 19,
		SendGift = 20,
		SendGift_Fast = 21,
		Mall = 22,
		Gacha_OneTime = 23,
		Gacha_TenTimes = 24,
		ModifyClanName = 25,
		ModifyNickname = 26,
		ActivityReward_Festival = 27,
		Forge = 28,
		PreviewCgShow = 29,
		DeleteAccount = 30,
		AnnouncementReward = 31,
		CommonReward = 32,
		AvatarProfile_GainAvatar = 33,
		AvatarProfile_GainBundle = 34,
		AvatarProfile_Vault = 35,
		ElitePass_BadgePurchase = 36,
		ElitePass_Challenge = 37,
		ElitePass_Reward = 38,
		Friend = 39,
		Gacha_ExchangeActivity = 40,
		IAPBundle_Preview = 41,
		Inventory = 42,
		Lobby_VideoTutorial = 43,
		Lobby_WebTutorial = 44,
		Login_TermsOfService = 45,
		LotteryReward = 46,
		Pet_ModifyName = 47,
		Policy = 48,
		ProfileTrendItem = 49,
		LadderMatch_SeasonStats = 50,
		LadderMatch_SeasonStatsDetail = 51,
		Setting_TermsOfService = 52,
		Setting_PrivacyPolicy = 53,
		Setting_CustomerService = 54,
		AutoPopup = 55,
		PopupMenu = 56,
		LadderMatch_LeaderboardItem = 57,
		Chat_MessageItem = 58,
		Clan_Item = 59,
		Group_Invite = 60,
		Player_LeaderboardItem = 61,
		LeaderboardItem = 62,
		FriendSearchItem = 63,
		FriendApplyItem = 64,
		LadderMatch_Rules = 65,
		LadderLobby = 66,
		PVEPrepare = 67,
		PVEWeaponSelection = 68,
		PaymentActivity = 69,
		PaymentTotal = 70,
		PaymentBundle = 71,
		PaymentRebateCard = 72,
		Pet_Mall = 73,
		ActivityGW_Token = 74,
		PveLuckyDraw = 75,
		GoogleEngagementRewards = 76,
		LiveTv = 77,
		LiveTver = 78,
		LobbyExtraAds_1 = 79,
		LobbyExtraAds_2 = 80,
		Championship = 81,
		ChampionshipTeamProfile = 82,
		ChampionshipGameStats = 83,
		ManualWeapon = 84,
		MallWebBtn = 86,
		PaymentShop = 87,
		PaymentDiamondEvent = 88,
		LinkActivity = 89,
		GameModeMain = 90,
		ChampionshipLobby = 91,
		VeteranTask = 92,
		Veteran = 93,
		Gacha_BuyBuff = 94,
		UpgradeCard = 95,
		DownloadCenter = 96,
		PaymentFirstTimeWindow = 97,
		InviteGroupBox = 98,
		IAPDiamondPurchase = 100,
		EPQuest = 101,
		EPUpgradeReward = 102,
		CDKeyPopUp = 103,
		AnniversaryEnter = 105,
		MysteryMallLuckyDraw = 106,
		MysteryMall = 107,
		PaymentGrowthFund = 109,
		GrowthFundAd = 110,
		WeaponSkinMainEnter = 113,
		WeaponSkinUpgrader = 115,
		Gacha_WeaponSkin = 117,
		PreviewItem = 118,
		Loadout = 120,
		ChampionshipNoticeItem = 122,
		InvitationTipsBox = 125,
		GameFriendItem = 126,
		PlatformFriendItem = 127,
		RoomObserverItem = 129,
		RoomPlayerItem = 130,
		HDVehicleDisplay = 135,
		HDWeaponRack = 136,
		Login_Main = 137,
		AvatarAwaken = 138,
		CupTeamProfile = 139,
		HDIceWallDisplay = 140,
		MallOtherChannelBtn = 142,
		TopUpEvent = 145,
		DailySignIn = 150,
		LegendClothVaultPick = 151,
		ClanLuckyBag = 152,
		HDSkyboardDisplay = 153,
		ProfileHistoryMatchResult = 155,
		Setting = 156,
		NewVault = 157,
		CreateRoom = 158,
		Gacha = 159,
		AvatarLink = 160,
		MatchResultReward = 161,
		HyperBookContent = 162,
		FlashStore = 163,
		FlashStoreActivity = 164,
		VirtualBrand = 165,
		LabEntrance = 166,
		VirtualBrandShowCase = 167,
		VirtualBrandStory = 168,
		RankRewardDetail = 169,
		RankExchangeStore = 170,
		PreVeteran = 171,
		Achievement = 172,
		BigEvent_DigitaluniverseB_Main = 188,
		BigEvent_DigitaluniverseB_RoleDoorDialog = 189,
		BigEvent_DigitaluniverseB_RoleDoor = 190,
		BigEvent_DigitaluniverseB_GunDoor = 191,
		BigEvent_DigitaluniverseB_ActivityDoor = 192,
		BigEvent_DigitaluniverseB_ClothDoor = 193,
		BigEvent_DigitaluniverseB_MapDoor = 194,
		BigEvent_DigitaluniverseB_ExchangeStore = 195,
		BigEvent = 197,
		BigEvent_GlobalProgress = 198,
		SurveyEntry = 199,
		Mail = 200,
		UGCWorkshopCreate = 201,
		WeaponSkinPokedex = 202,
		DebugConsole = 203,
		GachaLegendBooyahDay = 204,
		GachaRampage4C = 205,
		GachaLegendNew = 206,
		HyperBookshelf = 207,
		TopButton = 208,
		BigEvent_MatchNpc = 209,
		BooyahPassMain = 210,
		BooyahPassUpgrade = 211,
		TailorEntrance = 212,
		NewAgeBBasicMissionItem = 213,
		NewAgeBEggMissionItem = 214,
		BigEvent_PersonalProcess = 215,
		TailorMainPage = 216,
		WeaponProficiency = 217,
		MileStone = 218,
		UGCCenter = 219,
		UGCUserCenter = 220,
		NewageBMain = 221,
		RoomList = 222,
		WorkshopDetail = 223,
		NewPlayer = 224,
		NewPlayerLevelUpReward = 225,
		BigEvent_CustomCard = 228,
		LuckyBuffBattle = 229,
		LadderLeaderBoard = 230,
		LobbyExtraAds_Hideout = 231,
		Profile = 232,
		LeaderBoard = 233,
		ClanSearch = 234,
		Build = 235,
		AvatarInfoNavi = 236,
		AvatarInfoKeyart = 237,
		EvoGun = 238,
		AchievementTipsBox = 239,
		LobbyV2 = 240,
		ShoppingMall = 241,
		MatchFeedBack = 242,
		RecentVisitor = 243,
		ProfilePlayerPreferenceSetting = 244,
		ClanActive = 245,
		ClanBriefBox = 246,
		SeasonYearMain = 247,
		BigEvent_CustomTC = 248,
		GameAssistantIntroduction = 249,
		GameModeCasual = 250,
		ClanEdit = 251,
		ClanWarLeaderBoardMini = 252,
		GoposChatMessage = 253,
		WishList = 254,
		BigEvent_Milestone = 255,
		CLPlatform_Recommended = 256,
		CLPlatform_Explore = 257,
		Craftland_Room = 258,
		CLPlatform_Profile = 259,
		CLPlatform_Studio = 260,
		CLPlatform_Mission = 261,
		Craftland_MapPopup = 262,
		MatchMaking = 263,
		CustomRoom = 264,
		MatchResult = 265,
		MatchResult_OutGame = 266,
		Clipboard = 267,
		BriefBox = 268,
		ProfileCustomCell = 269,
		NewBieOfferRemind = 270,
		LadderLeaderBoardEnterWnd = 271,
		NewBieOffer = 272,
		SceneEdit = 274,
		SceneEditSearchMap = 275,
		Craftland_MapShare = 276,
		Craftland_Membership = 277,
		Craftland_Search = 278,
		HippoCrisisLobby = 279,
		IAPBundleV2Preview = 280,
		HippoCrisisPreStart = 281,
		HippoCrisisInventory = 282,
		Craftland_CreateNewMap = 283,
		QRCode = 284,
		Prime = 285,
		TakePhoto = 286,
		GrowthFundAnnounce = 287,
		QRScan = 288,
		SeasonReplay = 289,
		GameModeCraftland = 290,
		SoloPlay = 291,
		SelectMap = 292,
		GachaCouponInsufficientPopUp = 293,
		NColor25BCollection = 294,
		SquadTreasureTeamInfo = 295,
		SquadTreasure = 296,
		IPCollab = 297,
		CsPeak = 298,
		EvoPass = 299,
		Payment = 300,
		TakePhotoGroup = 301,
		PreviewImageShare = 302,
		Craftland_MapLeaderboard = 303,
		LobbyV2Payment = 304,
		UGCTimelineEditor = 305,
		RelayMart = 306,
		RecommendKolHud = 307,
		RelayMartDiscountCodeShareItem = 308,
		OfflinePlayPage = 309,
		VersionCheck_OfflinePlay = 310,
		FFLogin_OfflinePlay = 311,
		NetworkConnectionError_OfflinePlay = 312,
		HighPing_OfflinePlay = 313,
		CLPlatform_Explore_FeedPage = 314,
		DrawShop = 315,
		SparkPetProfile = 316,
		NearbyPlayerProfile = 317,
		CLPlatform_Recommended_NewbieRecs = 318,
		Login_AppleLoginHint = 319,
		Craftland_Creator_Level = 320,
		PhotoWall = 321,
		Craftland_ResourceShop = 322,
		CLPlatform_Ranking = 323,
		CLPlatform_Activity = 324,
		UGCCenterCreateLv = 325
	}

	public enum UINavigationPageType
	{
		None = 0,
		Profile = 1,
		Group = 2,
		Mall = 3,
		Vault = 4,
		Clan = 5,
		Recharge = 6,
		Activity = 7,
		Friends = 8,
		Loadout = 9,
		Setting = 10,
		Tutorial = 11,
		RebateCard = 12,
		AvatarProfile = 13,
		ElitePass = 14,
		Gacha = 15,
		IAPBundle = 16,
		Chat = 17,
		Forge = 18,
		RewardedVideo = 19,
		GainItemPreview = 20,
		Leaderboard = 21,
		LadderMatch = 22,
		IngameDrop = 23,
		Payment = 25,
		Pet = 26,
		ActivityGW = 27,
		GoogleEngagementRewards = 28,
		LiveTv = 29,
		MemberShip = 30,
		Championship = 31,
		ChampionshipTeamProfile = 32,
		ChampionshipNormalGameStats = 33,
		ChampionshipTeamOtherProfile = 34,
		ChampionshipGameWinnerDetail = 35,
		Task = 36,
		ChampionshipLobby = 37,
		Veteran = 38,
		PaymentFirstTimeWindow = 41,
		EPTask = 43,
		Mail = 46,
		AnniversaryAct = 47,
		MystertyMall = 48,
		SceneEdit = 49,
		GotoMapMode = 53,
		WeaponSkinMain = 54,
		ChampionshipWarmUp = 56,
		ChampionshipDefault = 57,
		DownloadCenter = 58,
		LadderMatchDetail = 59,
		PortraitCloseup = 64,
		AvatarAwaken = 69,
		DressUpMain = 70,
		CupMatch = 76,
		CupMatchTeamOtherProfile = 77,
		LuckyWheel = 78,
		BigEventTemplate = 79,
		VeteranGuideance = 80,
		VeteranDailyMission = 81,
		WeaponProficiency = 82,
		BigEvent = 98,
		WebView = 99,
		MAX = 100
	}

	public enum UINavagationProfileType
	{
		ProfileDefault,
		profileRankHistory,
		ProfileStreamer,
		ProfileChampionshipHistory,
		ProfileCredit,
		ProfileReplayKit,
		ProfileReplay,
		ProfileWeaponTitle,
		ProfileLeaderBoardTitle,
		ProfileCraftland,
		ProfileWishList,
		ProfileOccupation,
		ProfileSettingWndFromPrime
	}

	public enum UINavigationMallExType
	{
		FFEx = 800000301,
		DrawCardEx = 800000302,
		RankEx = 800000303,
		GachaEx = 800000304,
		FriendShipEx = 801001846
	}

	public enum UINavigationGroupType
	{
		GroupDuo = 1,
		GroupSquad
	}

	public enum UINavigationMallType
	{
		MallTypeNone,
		MallTypeNormal,
		MallTypeWeapon,
		MallTypeBox,
		MallTypeGift,
		MallTypeExchange
	}

	public enum UINavigationMallTabType
	{
		MallTabTypeNone = 0,
		MallTabTypeAll = 1,
		MallTabTypeExclusive = 2,
		MallTabTypeAds = 3,
		MallTabTypeNewItem = 4,
		MallTabTypeTreasureBox = 5,
		MallTabTypeBundle = 6,
		MallTabTypeAvatar = 7,
		MallTabTypeClothes = 8,
		MallTabTypeWeapon = 9,
		MallTabTypeProps = 10,
		MallTabTypeCollection = 11,
		MallTabTypePet = 12,
		MallTabTypeOther = 13,
		MallTabTypeDiscount = 14,
		MallTabTypeSpecialViewStart = 50,
		MallTabTypeGiftLeadBoard = 51,
		MallTabHide = 99
	}

	public enum UINavigationMallV2Type
	{
		MallTypeNone,
		MallTypeNormal,
		MallTypeGift
	}

	public enum UINavigationMallV2TabType
	{
		None = 0,
		Fashion = 1,
		Collection = 2,
		Weapon = 3,
		Build = 4,
		Other = 5,
		Exchange = 6,
		Discount = 7,
		VeteranDiscount = 8,
		ShoppingMall = 9,
		NewBieOffer = 10,
		GiftFashion = 101,
		GiftCollection = 102,
		GiftWeapon = 103,
		GiftBuild = 104,
		GiftOther = 105,
		PrimeTab = 106,
		PrimeGift = 107,
		GiftWishList = 108
	}

	public enum UINavigationMallV2SubTabType
	{
		None = 0,
		NewBie = 60000,
		Discount = 70000,
		VeteranDiscount = 80000,
		ShoppingMall = 90000,
		Prime = 110000,
		Prime_Gift = 110001,
		Fashion_Bundle = 10702,
		Fashion_Box = 10402,
		Chest = 10203,
		Legs = 10204,
		Feet = 10205,
		Face = 10208,
		Hair = 10211,
		Set = 10212,
		HeadAdditive = 10214,
		Banner = 20901,
		HeadPic = 20902,
		LootBox = 20903,
		BackPack = 20904,
		Parachute = 20905,
		Skyboard = 20906,
		VehicleSkin = 20908,
		Emote = 20909,
		Pin = 20910,
		Flight = 20911,
		GroupAnim = 20912,
		Music = 20913,
		Transformer = 20914,
		HyperBook = 20915,
		QuickMessage = 20916,
		ActionJump = 20917,
		ActionUseMedkit = 20918,
		ActionCrossWindow = 20919,
		ActionFallingHigh = 20920,
		SkillEffect = 20921,
		FinalShot = 20922,
		HorseVehicle = 20924,
		Weapon_Token = 30800,
		Weapon_Token_Box = 30408,
		Weapon = 30907,
		Weapon_Melee = 3090706,
		Weapon_Grenade = 3090707,
		Weapon_Box = 30409,
		Avatar = 40100,
		Pet_Bundle = 40713,
		Pet_Box = 40413,
		Pet = 41300,
		Pet_Anim = 41309,
		Pet_Skin = 41310,
		Bundle = 50700,
		Box = 50400,
		Bonus_Card = 51100,
		Other_Item = 50000,
		Props = 50500,
		Error_Item = 50001,
		Gift_Fashion_Bundle = 1010702,
		Gift_Fashion_Box = 1010402,
		Gift_Chest = 1010203,
		Gift_Legs = 1010204,
		Gift_Feet = 1010205,
		Gift_Face = 1010208,
		Gift_Hair = 1010211,
		Gift_Set = 1010212,
		Gift_HeadAdditive = 1010214,
		Gift_Banner = 1020901,
		Gift_HeadPic = 1020902,
		Gift_LootBox = 1020903,
		Gift_BackPack = 1020904,
		Gift_Parachute = 1020905,
		Gift_Skyboard = 1020906,
		Gift_VehicleSkin = 1020908,
		Gift_Emote = 1020909,
		Gift_Pin = 1020910,
		Gift_Flight = 1020911,
		Gift_GroupAnim = 1020912,
		Gift_Music = 1020913,
		Gift_Transformer = 1020914,
		Gift_HyperBook = 1020915,
		Gift_QuickMessage = 1020916,
		Gift_SkillEffect = 1020917,
		Gift_Weapon_Token = 1030800,
		Gift_Weapon_Token_Box = 1030408,
		Gift_Weapon = 1030907,
		Gift_Weapon_Melee = 103090706,
		Gift_Weapon_Grenade = 103090707,
		Gift_Weapon_Box = 1030409,
		Gift_Avatar = 1040100,
		Gift_Pet_Bundle = 1040713,
		Gift_Pet_Box = 1040413,
		Gift_Pet = 1041300,
		Gift_Pet_Anim = 1041309,
		Gift_Pet_Skin = 1041310,
		Gift_Bundle = 1050700,
		Gift_Box = 1050400,
		Gift_Bonus_Card = 1051100,
		Gift_Props = 1050500,
		Gift_Other_Item = 1050000,
		Gift_Wish_List = 1060000
	}

	public enum UINavigationVaultType
	{
		ChangeClothes = 1,
		ChangeApperance,
		SelectBundle
	}

	public enum UINavigationBooyahPassType
	{
		BooyahPassMain = 1,
		BooyahPassChallenge = 2,
		BooyahPassPurchaseBadge = 3,
		BooyahPassUpgrade = 4,
		BooyahPassPreorder = 5,
		BooyahPassSubscription = 6,
		BooyahPassSendExperience = 7,
		BooyahPassRewardPreview = 8,
		BooyahPassSendFriend = 9,
		BooyahPassVideo = 10,
		Fallback = 999
	}

	public enum UINavigationElitePassType
	{
		ElitePass = 1,
		ElitePassChallenge,
		ElitePassPurchaseBadge,
		ElitePassUpgrade,
		ElitePassPreorder,
		ElitePassSubscription
	}

	public enum UINavigationFriendType
	{
		PlatformFriends = 1,
		GameFriends,
		Requests,
		Search,
		Reunion,
		Relationship,
		TrainingCamp
	}

	public enum UINavigationFriendWndType
	{
		None,
		FriendRequest,
		BlackList
	}

	public enum UINavigationClanType
	{
		Clan = 1,
		SrarchClanById,
		SearchAssistClan
	}

	public class GotoParams
	{
		public ulong SubType1;

		public ulong SubType2;

		public ulong SubType3;

		public string Param;

		public object Extra;

		public string SpecialFromLogName;
	}

	public class ShowRewardsParams
	{
		public uint ItemID;

		public uint Count;

		public ExchangeChangeData Data;

		public bool needRemoveDeleteItem;
	}

	public class WebViewOptions
	{
		public enum WebViewStyle
		{
			Normal,
			Lite,
			Tutorial
		}

		public WebViewStyle Style;

		public bool PrefersExternal;

		public bool RecordTime;

		public string Title;

		public Action CloseCallBack;

		public string ActivityName;
	}

	public enum UINavigationLadderMatchType
	{
		LadderMatch,
		CSLadderMatch,
		PeriodicLadderMatch,
		HippoCrisisLadderMatch,
		CSPeakTournament
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__223_0;

		internal CommonRewardItemInfo _003CShowRewards_003Eb__223_0(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public UIModelSceneEdit modelSceneEdit;

		public UINavigationFrom ugcFrom;

		public string fromInfo;

		internal void _003CGoToV2SceneEditShare_003Eb__0(bool succeed)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass204_0
	{
		public ulong accountId;

		public UINavagationProfileType subType;

		internal void _003CGotoProfilePage_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public ShowRewardsParams param;

		public UIModelMall mall;

		internal void _003CShowRewards_003Eb__1()
		{
		}

		internal void _003CShowRewards_003Eb__2()
		{
		}

		internal void _003CShowRewards_003Eb__3()
		{
		}

		internal void _003CShowRewards_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass224_0
	{
		public ExchangeChangeData data;
	}

	private sealed class _003C_003Ec__DisplayClass224_1
	{
		public int j;

		public _003C_003Ec__DisplayClass224_0 CS_0024_003C_003E8__locals1;

		internal bool _003CAssembleRewardsList_003Eb__0(Item x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIModelSceneEdit modelSceneEdit;

		public int scene;

		public EOpenWorkshopDetailFrom from;

		public int rankIndex;

		public string workshopCode;

		public UINavigationFrom uiTo;

		public string toInfo;

		public UINavigationFrom ugcFrom;

		public string fromInfo;

		public bool isBlockRoom;

		public int openCL;

		internal void _003CGoToV2WorkshopDetail_003Eb__0(bool succeed)
		{
		}
	}

	private static string[] V2NaviDataArray;

	public static Dictionary<int, OtherChannelInfo> CommercialChannelInfo;

	private const int m_RandomMapId = 99;

	private static UINavigationFrom _003CFrom_003Ek__BackingField;

	public static UINavigationFrom From
	{
		get
		{
			return _003CFrom_003Ek__BackingField;
		}
		private set
		{
			_003CFrom_003Ek__BackingField = value;
		}
	}

	public static bool IsPhotoWallOpen()
	{
		return false;
	}

	public static void GoToV2Navigation(string specialFromName, uint gopos, string param)
	{
	}

	public static void GoToV2Navigation(UINavigationFrom from, uint gopos, string param, string specialFromName = null, object extra = null)
	{
	}

	public static void GetV2NaviDataArray(string param)
	{
	}

	private static void CustomSplitV2NaviData(string param)
	{
	}

	private static void LogNavigate(string from, EV2NavigationPageType gopos, string specialFromName)
	{
	}

	private static void TryGoToV2Navigation(uint gopos, string from, object extra = null)
	{
	}

	public static object GetV2NaviDataValue<T>(string dataKey, T dataValue)
	{
		return null;
	}

	private static void GoToV2LegendClothVault()
	{
	}

	private static void GoToV2RankExchangeMall()
	{
	}

	private static void GoToV2RoomList()
	{
	}

	private static void GoToV2CSBanPick(object extra)
	{
	}

	private static void GoToV2TournamentList()
	{
	}

	private static void GoToV2TrainingCenter()
	{
	}

	private static void GoToV2PhotoWall()
	{
	}

	private static void GoToV2LobbyLWObserve(string from)
	{
	}

	private static void GoToV2PhotoWallFriend(object extra)
	{
	}

	private static void GoToV2CustomRoom()
	{
	}

	private static void GoToHippoCrisisLobby()
	{
	}

	private static void GoToHippoCrisisBlackMarket()
	{
	}

	private static void GoToV2QuickMsgSetting(string from)
	{
	}

	private static void GoToV2SceneEditUGCCenter(string from)
	{
	}

	private static void GoToV2UGCCenter(string from)
	{
	}

	private static void GoToV2UGCUserCenter(string uiFrom)
	{
	}

	private static void GoToV2UGCCreateNew(string from)
	{
	}

	private static void GoToV2UGCCreateMap(string from)
	{
	}

	private static void GoToV2MysteryMall()
	{
	}

	private static void GoToV2Profile()
	{
	}

	private static void GoToV2Group()
	{
	}

	private static void GoToV2Mall()
	{
	}

	private static void GoToV2MallV2(string from)
	{
	}

	private static void GoToV2Gift()
	{
	}

	private static void GoToV2SeasonReplay(string from)
	{
	}

	private static void GoToV2ClanActiveExchangeMall()
	{
	}

	private static void GoToV2SeasonYearMain()
	{
	}

	private static void GoToV2PeakWeekLeaderboard()
	{
	}

	private static void GoToV2CsPeakTournamentHallOfFame()
	{
	}

	private static void GoToV2WeaponSkinCustom()
	{
	}

	private static void GoToV2Vault()
	{
	}

	private static void GoToV2Clan()
	{
	}

	private static void GoToV2Activity(object extra = null)
	{
	}

	private static void GoToV2Friends()
	{
	}

	private static void GoToV2AvatarProfile()
	{
	}

	private static void GoToV2Pet()
	{
	}

	private static void GoToV2Gacha()
	{
	}

	private static void GoToV2Chat()
	{
	}

	private static void GoToV2Forge()
	{
	}

	private static void GoToV2TokenExchange()
	{
	}

	private static void GoToV2DrawShopExchange()
	{
	}

	private static void GoToV2LeaderBoard()
	{
	}

	private static void GotoV2LadderMatch()
	{
	}

	private static void GoToV2Payment()
	{
	}

	private static void GoToV2MemberShip()
	{
	}

	private static void GotoV2NewBieCharge()
	{
	}

	private static void GoToV2EvoGunMembership()
	{
	}

	private static void GotoV2GrowthFund()
	{
	}

	private static void GotoV2GrowthFundV2()
	{
	}

	private static void GotoV2SquadTreasure()
	{
	}

	private static void GoToV2Championship()
	{
	}

	private static void GotoV2ChampionshipOtherTeam()
	{
	}

	private static void GoToV2Task()
	{
	}

	private static void GoToV2WeaponProficiency()
	{
	}

	private static void GoToV2PreVeteran()
	{
	}

	private static void GoToV2WeaponPowerLeaderBoard()
	{
	}

	private static void GoToV2Veteran()
	{
	}

	private static void GoToV2Mail()
	{
	}

	private static void GoToV2AvatarAwaken()
	{
	}

	private static void GoToV2CupMatch()
	{
	}

	private static void GoToV2CupMatchOtherTeam()
	{
	}

	private static void GotoV2MapMode()
	{
	}

	private static void GotoV2WeaponSkinMain()
	{
	}

	private static void GoToV2BigEvent(string from)
	{
	}

	private static void GoToV2BigEventTemplate()
	{
	}

	private static void GoToV2WevView(object extra = null)
	{
	}

	private static void GoToV2Achievement()
	{
	}

	private static void GoToV2VirtualBrand()
	{
	}

	private static void GoToV2VirtualBrandShowCase()
	{
	}

	private static void GoToV2VirtualBrandStory()
	{
	}

	private static void GoToV2WorkshopDetail(string uiFrom, object extra)
	{
	}

	private static void GoToV2NewVault()
	{
	}

	private static void GoToV2MileStone()
	{
	}

	private static void GoToV2DownloadCentre()
	{
	}

	public static void GotoNewPlayer()
	{
	}

	public static string BuildAvatarKeyartGoParam(uint GoType)
	{
		return null;
	}

	private static void GoToV2AvatarKeyart()
	{
	}

	public static string BuildGachaGoParam(uint GoType, uint GachaID, bool ActivePlay)
	{
		return null;
	}

	private static void GoToV2GachaVideo()
	{
	}

	private static void PushLabNavigation()
	{
	}

	private static void GotoHyperBookshelf()
	{
	}

	private static void PushHyperBookshelfNavigation()
	{
	}

	public static string BuildHyperBookContentGoParam(uint bookID, int sortID = -1, bool waitForAnimation = false)
	{
		return null;
	}

	private static void GotoHyperBookContent()
	{
	}

	private static void PushHyperBookContentNavigation(List<object> data = null)
	{
	}

	private static void GotoSecretMessageRedeem()
	{
	}

	private static void GotoSecretMessageGenerate()
	{
	}

	public static string BuildFlashStoreGoParam(uint flashStoreActivityID, UIFlashStoreNavigation.NavigationType navType = UIFlashStoreNavigation.NavigationType.NotSpecific, uint itemID = 0u, uint groupID = 0u, uint activityID = 0u)
	{
		return null;
	}

	private static void GotoFlashStore()
	{
	}

	private static void PushFlashStoreNavigation(List<object> data)
	{
	}

	public static string BuildFlashStoreActivityGoParam(uint flashStoreActivityID, uint groupID = 0u, uint activityID = 0u)
	{
		return null;
	}

	private static void GotoFlashStoreActivity()
	{
	}

	private static void GoToV2WeaponSkinPokedex()
	{
	}

	private static void GotoV2BindAccount()
	{
	}

	private static void PushFlashStoreActivityNavigation(List<object> data)
	{
	}

	public static string GetBooayhPassSubGopos(UINavigationBooyahPassType subGopos)
	{
		return null;
	}

	private static void GoToV2BooyahPassRewardPreview()
	{
	}

	private static bool GoToV2BooyahPassVideo()
	{
		return false;
	}

	private static void GotoV2BooyahPass()
	{
	}

	private static void GotoBooyahPassController(UINavigationBooyahPassType type, uint level, uint ItemID)
	{
	}

	private static bool LastNavigationIsBpMain()
	{
		return false;
	}

	private static void GoToV2BooyahPassMain(UINavigationBooyahPassType bpType = UINavigationBooyahPassType.BooyahPassMain, uint level = 0u, uint itemID = 0u)
	{
	}

	private static bool GotoV2BooyahPassUpgrade()
	{
		return false;
	}

	private static bool GotoV2BooyahPassSubscription(UINavigationBooyahPassType bpType)
	{
		return false;
	}

	private static bool GotoV2BooyahPassDuoShare(UINavigationBooyahPassType bpType)
	{
		return false;
	}

	private static void GotoV2TailorEntrance()
	{
	}

	public static void GotoTailorMainPageWithParam(UINavigationFrom from, uint tailorID)
	{
	}

	public static void GotoTailorMainPageWithParam(string from, uint tailorID)
	{
	}

	private static void GotoV2TailorMainPage()
	{
	}

	private static void GotoV2AntiHackWindow()
	{
	}

	private static void GotoV2UGCRoomList()
	{
	}

	private static void GotoLobbyChat()
	{
	}

	private static void GotoUGCRankReward()
	{
	}

	private static void GotoSPReplayList()
	{
	}

	private static void GotoV2LuckyBuffBattle()
	{
	}

	private static void ShowDuoVersionConfirmWnd()
	{
	}

	private static void GotoV2Build()
	{
	}

	private static void GoToV2GlobalExchangeStore()
	{
	}

	private static void GotoV2EvoGun()
	{
	}

	private static void GotoV2ShoppingMall()
	{
	}

	private static void GotoV2RecommendPreset()
	{
	}

	public static void GotoV2LiveTv()
	{
	}

	private static void GoToV2ProfileCustom()
	{
	}

	private static void GoToV2SecondRecharge()
	{
	}

	private static void GoToV2SceneEditSearchMap()
	{
	}

	private static void GoToV2SceneEditShare(string uiFrom)
	{
	}

	private static void GoToV2HippoCrisisInventory()
	{
	}

	private static void GoToV2HippoCrisisPreStart()
	{
	}

	private static void GoToHippoCrisisRecommendLoadout()
	{
	}

	private static void GoToGachaDoubleWheelRewardPreview()
	{
	}

	private static void GoToRankMapSelectAndCheckDownLoad()
	{
	}

	private static void GoToPortraitCloseup(object extra)
	{
	}

	private static void GoToGroupPhoto(object extraData)
	{
	}

	private static void GoToPrime()
	{
	}

	private static void GoToIPCollab()
	{
	}

	private static void GoToV2RelayMartMainPage()
	{
	}

	private static void GoToV2CloseFriend(string from)
	{
	}

	private static void GoToV2DrawShop()
	{
	}

	private static void GotoDrawShop(int chestId = -1, int itemId = 0)
	{
	}

	public static void GotoHDLobbyYard()
	{
	}

	public static void GotoHDLobbyWeaponRack()
	{
	}

	public static void GotoHDLobbyVehicle()
	{
	}

	public static void GotHDLobbyIceWall()
	{
	}

	public static void GotoHDLobbySkyboard()
	{
	}

	private static void SendBigEventFirstViewLog(string from, EV2NavigationPageType gopos, uint eventId, uint entranceId)
	{
	}

	private static void GoToV2BRMatchReview()
	{
	}

	public static void GotoNavigation(UINavigationFrom from, UINavigationPageType to, GotoParams gotoParams = null, UINavigationData navigationData = null)
	{
	}

	public static void GoToBigEventTemplate(uint tempLateUseType, uint entranceType, uint param1 = 0u, uint param2 = 0u)
	{
	}

	public static void GoToBigEvent(string from, proto.ELimitedEvent.EventID eventID, UIModelBigEvent.EBigEventEntranceID entranceId, string param, ulong subType3, object extra)
	{
	}

	public static void GotoTermsOfService()
	{
	}

	public static void GotoPrivacyPolicy()
	{
	}

	public static void GotoManageSubscription()
	{
	}

	public static void GotoCustomerService()
	{
	}

	public static void GotoBugReport()
	{
	}

	public static void GotoCustomerDelAccount()
	{
	}

	public static void GotoWebView(UINavigationFrom from, string url, object extra = null)
	{
	}

	private static string ResolveV2SubGoposUrl(string subgopos)
	{
		return null;
	}

	public static void GotoTutorialWebView(UINavigationFrom from, string url, object extra = null, Action callback = null)
	{
	}

	public static void GotoNavigation(UINavigationFrom from, uint gotoPos, string param = null, object extra = null, string specialFromName = "")
	{
	}

	public static bool GotoNavigationByConfig(UINavigationFrom from, GoPos goPosObject)
	{
		return false;
	}

	public static string GetBigEventLogName(proto.ELimitedEvent.EventID bigEventId, UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return null;
	}

	public static string GetGachaNavigateLogName(uint chestID)
	{
		return null;
	}

	public static string GetLadderMatchDetailNavigationlogName(string gameName)
	{
		return null;
	}

	public static string GetVeteranNavigateLogName()
	{
		return null;
	}

	public static uint MakeGoPos(UINavigationPageType mainType, uint subType1 = 0u, uint subType2 = 0u, uint subType3 = 0u)
	{
		return 0u;
	}

	public static uint GetMainType(uint gotoPos)
	{
		return 0u;
	}

	public static uint GetSubType1(uint gotoPos)
	{
		return 0u;
	}

	private static uint GetSubType2(uint gotoPos)
	{
		return 0u;
	}

	private static uint GetSubType3(uint gotoPos)
	{
		return 0u;
	}

	private static void SetPendingGotoMapModeSubGopos(GotoParams gotoParams)
	{
	}

	private static bool FixedReturnToLobby(GotoParams gotoParams = null)
	{
		return false;
	}

	public static void ReturnToLobby()
	{
	}

	private static void GotoProfilePage(ulong accountId, UINavagationProfileType subType, ulong subtype3, bool reuseCache = false)
	{
	}

	private static void GotoGroup(UINavigationGroupType groupType)
	{
	}

	public static void GotoMall(UINavigationFrom from, UINavigationMallType mallType, uint mallTabType = 0u, uint subType = 0u, List<uint> itemIDList = null, List<FriendInfo> lobbySeletFriendList = null, EGiftStore_BuddyType type = EGiftStore_BuddyType.BT_NONE, CollectionDataManager.ECollectionWeaponType weaponPageFilterType = CollectionDataManager.ECollectionWeaponType.all, uint weaponPageFilterId = 0u, uint weaponClickId = 0u)
	{
	}

	public static void GotoMallV2(UINavigationFrom from, UINavigationMallV2Type mallType, uint firstTab = 0u, uint secondTab = 0u, List<uint> itemIDList = null, List<FriendInfo> lobbySeletFriendList = null, EGiftStore_BuddyType type = EGiftStore_BuddyType.BT_NONE, uint weaponPageFilterType = 99u, uint weaponPageFilterId = 0u, uint weaponClickId = 0u, EGiftSendSource source = EGiftSendSource.GiftMall)
	{
	}

	private static void GotoVault(UINavigationVaultType vaultType, uint bundleItemID)
	{
	}

	private static void GotoPet(uint petId)
	{
	}

	private static void GotoClan(UINavigationClanType subType, string clanId, int clanTab = 0, int clanWnd = 0, int clanWarSubTab = 0)
	{
	}

	private static void GotoClanSearch()
	{
	}

	private static void GotoV2ClanEdit()
	{
	}

	private static void GotoPayment(UIPaymentController.Tab tab, UIPaymentController.EBundleType type = UIPaymentController.EBundleType.Default, uint groupId = 0u, uint lupUnlockId = 0u, UIPaymentController.Tab returnType = UIPaymentController.Tab.None, bool autoPopupInviteWnd = false, bool checkGotoSquadTreasure = false)
	{
	}

	public static bool TryProcessGotoIAPOrMshop(UIPaymentController.Tab tab, out UIPaymentController.Tab resultTab)
	{
		resultTab = default(UIPaymentController.Tab);
		return false;
	}

	private static void GotoPaymentFirstTimeWindow()
	{
	}

	private static void GotoHuntingGround()
	{
	}

	private static void GotoHuntingGroundSnowDifficultySelection()
	{
	}

	private static void GotoHuntingGroundSnowTalent()
	{
	}

	private static void GotoRebateCard()
	{
	}

	private static void GotoIAPBundle(IAPBundleStoreData data = null)
	{
	}

	private static void GotoV2IAPBundleV2(IAPBundleStoreData data = null)
	{
	}

	public static void ShowRewards(ShowRewardsParams param)
	{
	}

	public static List<BaseItemInfo> AssembleRewardsList(ExchangeChangeData data, bool needRemoveDeleteItem = true)
	{
		return null;
	}

	private static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	private static void OpenWebView(string url, WebViewOptions options = null)
	{
	}

	public static string GetActivityNameByGroupId(uint groupId)
	{
		return null;
	}

	private static void _OpenWebView(string url, WebViewOptions options)
	{
	}

	private static void GotoGainItemPreview()
	{
	}

	private static void GotoLadderMatch(uint subType1 = 0u)
	{
	}

	private static void GotoActivityByTabtype(uint tabType, uint id = 0u, object extra = null)
	{
	}

	private static void GotoActivity(UIActivityMasterController.ActivityCategory actvType, uint id = 0u, object extra = null)
	{
	}

	private static void GotoMail(uint id = 0u)
	{
	}

	private static void GotoFriends(UINavigationFriendType subType, uint friendWnd = 0u)
	{
	}

	private static void GotoLoadout()
	{
	}

	private static void GotoSettings(int subType = 0, int subType2 = 0)
	{
	}

	private static void GotoTutorial()
	{
	}

	private static void GotoAvatarProfile(uint avatarid)
	{
	}

	private static void GotoTask(int tab, int leftTab, uint selectedRewardPoints = 0u)
	{
	}

	public static void GotoVeteran()
	{
	}

	public static void GotoDownloadCenter(uint tab = 0u)
	{
	}

	public static void GotoChampionshipWarmUp()
	{
	}

	public static void GotoChampionshipDefault()
	{
	}

	public static void GoToMysteryMall(uint shopId)
	{
	}

	public static void GoToSceneEditUGCCenter(uint tabType, int seriesID = -1, bool restore = false)
	{
	}

	public static void GoToUGCCenter(uint tabType, int seriesID = -1, bool restore = false, bool premium = false)
	{
	}

	public static void GoToUGCUserCenter(uint tabType, string uiFrom)
	{
	}

	public static void GoToUGCCreateNew(uint slotId, int mode, int map, int template, string from)
	{
	}

	public static void GoToUGCCreateMap(int mode, int map, int template, string from, string fromInfo)
	{
	}

	public static void GotoWeaponSkinMain()
	{
	}

	public static void GotoDressUpMain()
	{
	}

	public static void GotoWeaponProficiency(uint weaponId)
	{
	}

	private static void GotoChampionshipLobby()
	{
	}

	private static void GotoChampionship(uint championshipType)
	{
	}

	private static void GotoChampionshipOtherTeam(UIChampionshipOtherFormController.NavArgs cpNavArgs)
	{
	}

	private static void GotoChampionshipNormalGameStats(UIChampionshipGameStatsController.NavArgs args = null)
	{
	}

	private static void GotoCupMatch(int cupMatchKey, int gotoPage = 0)
	{
	}

	private static void GotoCupMatchOtherTeam(UICupMatchOtherFormController.NavArgs cpNavArgs)
	{
	}

	private static void GotoGacha(int chestId = -1, int itemId = 0)
	{
	}

	private static void GotoDrawshop(int chestId = -1, int itemId = 0)
	{
	}

	private static void GotoForge(uint tabType = 0u, uint itemId = 0u)
	{
	}

	private static void GotoChat(EChannel.ChannelType channelType, ulong channelID = 0uL)
	{
	}

	private static void GotoLeaderboard(string deepLink)
	{
	}

	public static void GotoLiveTv(string url)
	{
	}

	public static string MakeGoToMapModeParam(DLBMPCCFKKM matchModeId, NIKKALKPIBO gameModeId, EMapName mapId = EMapName.EMapParadise, int groupPlayerNum = 0)
	{
		return null;
	}

	private static void PickMapMode()
	{
	}

	private static void GotoMapMode(string mapModeIDStr)
	{
	}

	private static void GoToMapMode2(uint GroupMode, uint MatchMode, uint MapMode, uint GameMode, int Difficulty, bool needAutoExpandGroup = false)
	{
	}

	private static void CheckAndGoToMode(uint GroupMode, uint MatchMode, uint MapMode, uint GameMode, int Difficulty = -1, bool needAutoExpandGroup = false)
	{
	}

	private static void GotoLuckyWheel()
	{
	}

	public static uint GetGoposByPreviewType(FrontendPreviewType previewType)
	{
		return 0u;
	}
}
