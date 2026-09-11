using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal static class UIUtils
{
	public enum TextureScaleType
	{
		None,
		WidthFixed,
		HeightFixed,
		Fit,
		Auto
	}

	public enum SpriteScaleType
	{
		WidthFixed,
		HeightFixed,
		Fit,
		BestFillBoarder,
		BestFillBoarderNoSpace,
		FillFitNoSpace,
		ShrinkFit,
		ShrinkFitNoSpace
	}

	public enum ResizedTexStyle
	{
		Ori,
		BaseOnWidth,
		BaseOnHeight,
		Auto
	}

	public enum ImageType
	{
		Null,
		Png,
		Jpg,
		Gif,
		Bmp
	}

	public enum ScreenshotType
	{
		None = 0,
		PlayerProfile = 1,
		GameHistory = 2,
		GachaReward = 3,
		GachaLuckyBag = 4,
		GainItem = 5,
		LeaderBoard = 6,
		RankLobby = 7,
		RankSeasonInfo = 8,
		PreviewCG = 9,
		Pet = 10,
		IAPBundle = 11,
		ChampionshipStats = 13,
		ElitePassShare = 14,
		RankComparison = 15,
		MatchResult = 16,
		MysteryMall = 18,
		WeaponSkinMain = 19,
		WeaponSkinUpgrader = 20,
		Bounty = 21,
		IngamePhotograph = 22,
		PortraitCloseup = 23,
		FriendGraph = 24,
		HDYard = 25,
		BR_MVP_Show = 26,
		CS_MVP_Show = 27,
		SplashBannerLiveTv = 28,
		CupMatch = 29,
		FourSymbols = 30,
		MusicFestAlbumMian = 31,
		MusicFestPhoto1 = 32,
		OBMatchResult = 53,
		WebViewCaptureScreenshot = 54,
		Winterfest = 55,
		SceneEdit = 56,
		HurricaneB = 57,
		BoybandB = 59,
		BigEventTemplate = 60,
		FFWS03 = 61,
		FFWS03Bill = 62,
		LadderMatchInfo = 63,
		AvatarLink = 64,
		SingersB = 65,
		PotentiaB = 66,
		WeaponSkinPokedex = 67,
		FootballGameMatchResult = 68,
		PotentiaBCompare = 69,
		WinStreak = 70,
		BooyahPassUnlock = 73,
		PersonalProgress = 75,
		NewageB = 76,
		VerticalPreviewColth = 77,
		VerticalPreviewCollection = 78,
		SystemScreenShot = 79,
		KitchenB = 82,
		LadderLeaderBoardAward = 83,
		LadderLeaderBoard = 84,
		MatchResultWinStreak = 87,
		MatchResultWinStreakSpecial = 88,
		ProfileWeapon = 89,
		SixthBCorePlay = 90,
		MatchResultNormalPage = 91,
		MatchResultDataPage = 92,
		MatchResultAvatarPage = 93,
		ClanWarV2RoundResult = 94,
		SeasonYear = 95,
		ClanWarV2Main = 96,
		LeaderBoard_GuildWar_Guild = 97,
		LeaderBoard_GuildWar_Individual = 98,
		ClanWeekReport = 99,
		ProfileOccupation = 100,
		ProfileHighestTitle = 101,
		GachaRewardWithLaunchTag = 102,
		HippoCrisisMatchIncome = 103,
		ClanWarTournament = 104,
		OutGameTakePhotoLobby = 105,
		GroupTakePhoto = 106,
		InGameTakePhoto = 107,
		OutGameTakePhotoProfile = 108,
		GroupTakePhotoVertical = 109,
		SeasonReplayTakePhoto = 110,
		GachaRewardGachaFeature = 111,
		Prime = 112,
		Album = 113,
		FullScreenPreview = 114,
		SquadTreasureTakePhoto = 115,
		Achievement = 1017,
		AchievementDetail = 1018,
		SeasonReplayOverview = 1019,
		SeasonReplayDestinyWeapon = 1020,
		SeasonReplaySocial = 1021,
		SeasonReplayBattleStyle = 1022,
		ClanWarEmblem = 1023,
		ClanPrivilege = 1024,
		AnniversaryRemind = 1025,
		MatchResultCSPeak = 1026,
		CsPeakWeek = 1027,
		CsPeakTournamentHallOfFame = 1028,
		CsPeakTournamentHallOfFameLeaderBoardExpand = 1029,
		OTPSavePassword = 1099,
		UGCMapShare = 1100,
		HightlightPhoto = 1122,
		UGCTakePhoto = 1126,
		InGameVerticalTakePhoto = 1127,
		SparkPetShare = 1128,
		PhotoWallShare = 1129,
		Ichis55Collection = 1130
	}

	public enum ShareUrlType
	{
		None = 1000,
		InviteFriend = 1001,
		InviteToGroup = 1002,
		ActivityFriendCallback = 1003,
		InviteToClan = 1005,
		InviteToRoom = 1006,
		SuperCarInvite = 1008,
		WorkShop = 1009,
		BigEventFriendCallback = 1010,
		LCDP2 = 1011,
		HurricaneB = 1012,
		LadderMatch = 1013,
		BigEventTemplate = 1014,
		DigitaluniverseB = 1015,
		WeaponProficiency = 1016,
		SecretMessage = 1101,
		ScreenShotMessageWindow = 1102,
		SixthBCorePlayShare = 1103,
		BigEvent = 1104,
		BigEvent_Warmup = 1105,
		NColor24BCollection = 1106,
		EigntnBSignet = 1107,
		InviteToJoinRoom = 1108,
		VideoPreview = 1109,
		NColor25BCollection = 1118,
		NColor25BKeepsake = 1119,
		NColor25BCombat = 1120,
		BigEventSpecial1 = 1123,
		BigEventSpecial2 = 1124,
		BigEventSpecial3 = 1125,
		SquadTreasure = 1201,
		HUDShare = 1202,
		RelayMart = 1203,
		FunResult = 1204
	}

	public enum EShareScreenType
	{
		LandScape,
		Portrait
	}

	public delegate void OnSavedScreenshot(bool result, Texture2D screenshot);

	public delegate void OnCreatedScreenshot(Texture2D screenshot);

	public delegate void OnSavedScreenshotRT(bool result, Texture2D screenshot);

	public delegate void OnCreatedScreenshotRT(Texture2D screenshot);

	private class ScreenshotRenderHandler : MonoBehaviour
	{
		public delegate void RenderedCallback(ScreenshotRenderHandler handler);

		public RenderedCallback OnRendered;

		public bool AllowHDR;

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}
	}

	private class ScreenshotRenderNewHandler : MonoBehaviour
	{
		public delegate void RenderedCallback(ScreenshotRenderNewHandler handler);

		public delegate void UpdateCallback(ScreenshotRenderNewHandler handler);

		public RenderedCallback OnRendered;

		public UpdateCallback OnUpdate;

		public bool AllowHDR;

		public PostEffectManager PostEffect;

		private Camera m_Cam;

		public bool NeedRenderToScreen;

		private void Update()
		{
		}

		private void OnPostRender()
		{
		}

		public void SetTargetTexture(RenderTexture rt)
		{
		}

		public RenderTexture GetTargetTexture()
		{
			return null;
		}
	}

	public enum EUpgradeGemIconState
	{
		Empty,
		One,
		Two,
		Three,
		Full
	}

	public static class SNS_Content
	{
		public const int TEXT = 0;

		public const int IMAGE = 1;

		public const int VIDEO = 2;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Camera> _003C_003E9__191_1;

		public static Comparison<RareProbability> _003C_003E9__194_0;

		public static Comparison<ItemProbabilityInfo> _003C_003E9__195_0;

		public static Comparison<RareProbability> _003C_003E9__195_2;

		public static Comparison<RareProbability> _003C_003E9__196_0;

		public static Comparison<ItemProbabilityInfo> _003C_003E9__197_0;

		internal int _003CRenderScreenshot_003Eb__191_1(Camera a, Camera b)
		{
			return 0;
		}

		internal int _003CGenerateProbabilityStringOnlyQuality_003Eb__194_0(RareProbability itemA, RareProbability itemB)
		{
			return 0;
		}

		internal int _003CGenerateProbabilityString_003Eb__195_0(ItemProbabilityInfo infoA, ItemProbabilityInfo infoB)
		{
			return 0;
		}

		internal int _003CGenerateProbabilityString_003Eb__195_2(RareProbability itemA, RareProbability itemB)
		{
			return 0;
		}

		internal int _003CGenerateRareTypeProbability_003Eb__196_0(RareProbability itemA, RareProbability itemB)
		{
			return 0;
		}

		internal int _003CGenerateItemProbability_003Eb__197_0(ItemProbabilityInfo infoA, ItemProbabilityInfo infoB)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public int key;

		public ResourceID InResID;

		public UISprite InSprite;

		public Action<UISprite> action;

		internal void _003CBindAtlasSpriteByResourceIDAsync_003Eb__0(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public int key;

		public ResourceID InResID;

		public Action<string, UIAtlas> callBack;

		internal void _003CGetAtlasSpriteByResourceIDAsync_003Eb__0(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UINetworkTexture cdnTex;

		public TextureScaleType scaleType;

		public Action callback;

		internal void _003CSetTextureUrl_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass153_0
	{
		public UISprite sprite;

		public SpriteScaleType scaleType;

		public bool makePixelPerfect;

		public Action callbackLoaded;

		internal void _003CSetSpriteName_003Eb__0(bool downloadSuccess)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public UISprite sprite;

		public SpriteScaleType scaleType;

		public bool makePixelPerfect;

		public Action loadedCallback;

		internal void _003CSetSpriteNameAsync_003Eb__0(string spriteName, UIAtlas atlas)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public RenderTexture renderTexture;

		public bool needRotationResultPic;

		public string filePath;

		public OnCreatedScreenshot created;

		public OnSavedScreenshot saved;

		internal void _003CSaveScreenshot_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public Action done;

		internal void _003CRenderToRT_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public bool isIgnoreUI;

		public bool needPostEffect;

		internal bool _003CRenderScreenshot_003Eb__0(Camera camera)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass195_0
	{
		public uint firstItemId;

		internal bool _003CGenerateProbabilityString_003Eb__1(ItemProbabilityInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass197_0
	{
		public uint firstItemId;

		internal bool _003CGenerateItemProbability_003Eb__1(ItemProbabilityInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass215_0
	{
		public UISprite bluePrintIcon;

		public bool isNeedSpecialModification;
	}

	private sealed class _003C_003Ec__DisplayClass215_1
	{
		public UISprite sprite;

		public _003C_003Ec__DisplayClass215_0 CS_0024_003C_003E8__locals1;

		internal void _003CAddIncubatorComposeIcon_003Eb__0(bool down_success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass215_2
	{
		public UISprite sprite;

		public _003C_003Ec__DisplayClass215_0 CS_0024_003C_003E8__locals2;

		internal void _003CAddIncubatorComposeIcon_003Eb__1(bool down_success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public UISprite boxIcon;

		public UISprite sprite;

		public Vector3 pos;

		public bool isGemOrCoin;

		internal void _003CChangeIcon_003Eb__0(bool downloadSuccess)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass313_0
	{
		public UINetworkTexture cdnSlotIcon;

		internal void _003CSetUGCMapBg_003Eb__0()
		{
		}

		internal void _003CSetUGCMapBg_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass314_0
	{
		public UINetworkTexture cdnSlotIcon;

		internal void _003CSetUGCMapBgEditor_003Eb__0()
		{
		}

		internal void _003CSetUGCMapBgEditor_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public Action action;

		internal void _003CPlayAnimAndCallFunWhenAnimEnds_003Eb__0()
		{
		}
	}

	public static string MicPressedIcon;

	public static string MicPressedTeamIcon;

	public static string MicTeamIcon;

	public static string MicOpenIcon;

	public static string MicCloseIcon;

	public static string PlatformIcon_Guest;

	public static string PlatformIcon_HW;

	public static string PlatformIcon_VK;

	public static string PlatformIcon_FB;

	public static string PlatformIcon_FF_VK;

	public static string PlatformIcon_Google;

	public static string PlatformIcon_Garena;

	public static string[] LevelSpirteNameArray;

	public static string[] ProfileTagLevel;

	public static string POSITIVE_DELTA_COLOR;

	public static string NEGATIVE_DELTA_COLOR;

	public static string WIN_STREAK_ICON;

	public static string WIN_STREAK_ICON_SPECIAL;

	public static uint DefaultBoxIconItemID;

	public static string[] LevelCommonSpirteNameArray;

	public const string NewBgSpriteName = "UI_Ingame_Hud_Common_Circle_bg";

	public const string PocketRevivePointPlacerSpriteName = "UI_btn_ResurrectionMachine";

	public const string AstrolGatePlacerSpriteName = "Hud_Trea25_Icon_Planetarium";

	public static Color NewBgActiveColor;

	public static Color NewIconActiveColor;

	public static Color NewIconCommonColor;

	private static FEKBCHODFLE m_AsyncLoadTickets;

	public static Rect SCREEN_MARGIN_RATIO;

	private const string SCREENSHOT_FILE_NAME = "Free Fire Screenshot.png";

	private const string TEMP_SCREENSHOT_FILE_NAME = "Free Fire Screenshot Temp.png";

	public static float MAP_WIDTH;

	public static string CLICK_FILTER_MAP;

	public static string CLICK_FILTER_GROUP;

	public static string CLICK_FILTER_PVE_MAP;

	public static string CLICK_FILTER_TEAM;

	public static string CLICK_FILTER_GIFTRECEIVERLIST;

	public static string CLICK_FILTER_TUTORIAL;

	public static string CLICK_FILTER_VOUCHERLIST;

	public static string CLICK_FILTER_TEAM_MODE_BTN;

	public static string CLICK_FILTER_HC_GROUP;

	public static string CLICK_FILTER_HC_TEAM_MODE_BTN;

	public static string CLICK_FILTER_HC_DIFFICULTY_BTN;

	public static string CLICK_FILTER_HC_DIFFICULTY_PANEL;

	public const float PERFECT_PROPROTION_TO_ICONBOXWIDTH = 1f;

	public const float PERFECT_PROPROTION_TO_ICONBOXHEIGHT = 0.5f;

	private static string HINDI_CULTURE_CODE;

	private static int[] HINDI_NUMBER_GROUP_SIZE;

	private static readonly Color[] MARKCOLOR;

	private static readonly Color[] MARKCOLOR_TEAM;

	private static readonly Color HP_COLOR_NORMAL;

	private static readonly Color HP_COLOR_WARNING;

	private static readonly Color HP_COLOR_DANGER;

	private static readonly Color SP_COLOR;

	public static readonly Color HP_COLOR_KNOCK_DOWN;

	public static readonly Color HP_COLOR_KNOCK_DOWN_NOBLOOD;

	private static readonly Color HP_COLOR_NORMAL_VEHICLE;

	private static readonly Color HP_COLOR_DANGER_VEHICLE;

	private static readonly Color HP_COLOR_WOUNDED_VEHICLE;

	private static readonly Color EP_COLOR_NORMAL;

	private static readonly Color EP_COLOR_DISABLE;

	private static readonly Color EP_COLOR_SKILL_BLOOD_POOL;

	private static readonly Color EP_COLOR_SKILL_BLOOD_POOL_SKIN;

	private static readonly Color EP_COLOR_SKILL_PERSONA;

	private static readonly Color EP_COLOR_SKILL_PERSONA_LABEL;

	private static readonly Color ELITEPASS_COLOR;

	public static readonly Color ITEM_COLOR_NEW;

	public static readonly Color ITEM_COLOR_DISCOUNT;

	public static readonly Color ITEM_COLOR_LIMIT;

	public static readonly Color ITEM_COLOR_HOT;

	public static readonly Color ITEM_COLOR_EXPIRE;

	public static readonly Color ITEM_COLOR_PREVIEW;

	public static readonly Color ITEM_COLOR_GRENADE_CHOOSE;

	public static readonly Color ITEM_COLOR_GRENADE_COMMON;

	public static readonly Color ITEM_COLOR_LOADOUT_CHARGE;

	public static readonly Color SKILL_COLOR_TYPE_G;

	public static readonly Color SKILL_COLOR_TYPE_Y;

	public static readonly Color SKILL_COLOR_TYPE_R;

	public static readonly Color STANDARD_FF_YELLOW;

	public static readonly Color HP_CHANGE_COLOR;

	public static readonly Color HP_CHANGE_COLOR_NO_BLOOD;

	private static Action _OnRenderedScreenshot;

	private static int _ScreenshotWaitingCameras;

	private static Color ColorHide;

	private static Color ColorShow;

	private static List<Color> TeamColorList;

	public static string[] UpgradeGemIconStateList;

	public static string DefaultScreenshotFilePath => null;

	public static string DefaultTempScreenshotFilePath => null;

	public static string TempHighlightPhotoFilePath => null;

	public static string PosterScreenshotSavePath => null;

	public static ResourceID DEFAULT_OPT_ATLASID => default(ResourceID);

	public static T GetRandomItem<T>(T[] ts)
	{
		return default(T);
	}

	public static int RandomWeight(uint[] weights)
	{
		return 0;
	}

	public static bool IsEquippedByID(uint id)
	{
		return false;
	}

	public static bool IsClothesSetEquipByID(uint id)
	{
		return false;
	}

	public static bool IsDefaultItemByID(uint id)
	{
		return false;
	}

	public static bool CheckIdFemaleInvalid(uint id)
	{
		return false;
	}

	public static bool IsCanEquipeByID(uint id)
	{
		return false;
	}

	public static string WrapText(UILabel label, string value)
	{
		return null;
	}

	public static string SeparateDigit(int number, string cultureCode)
	{
		return null;
	}

	public static string FormatCount(ulong count)
	{
		return null;
	}

	public static float GetAnimDuratin(Animation animation, string clipName = null)
	{
		return 0f;
	}

	public static void PauseResumeGameObjectAnim(GameObject go, bool pause)
	{
	}

	public static void ResetAnimation(Animation animation, string clipName = null)
	{
	}

	public static void SkipLastAnimation(Animation animation, string clipName = null)
	{
	}

	public static void SkipAnimation(Animation animation, string clipName = null)
	{
	}

	public static void ResetAllAnimation(Animation animation)
	{
	}

	public static uint PlayAnimAndCallFunWhenAnimEnds(Animation anim, string animName, Action action)
	{
		return 0u;
	}

	public static string GetPlatformIcon(PlatformType platform)
	{
		return null;
	}

	public static bool AdjustSlotSpriteSize(UISprite InSprite, Vector2 InMargin)
	{
		return false;
	}

	public static Color GetGradientLerpColorByRatio(int InMax, int InValue)
	{
		return default(Color);
	}

	public static Color GetColorByItemLevel(int level)
	{
		return default(Color);
	}

	public static Color GetColorByBuffLevel(int level)
	{
		return default(Color);
	}

	public static void UpdateMarkColorByTeamIndex(UISprite icon, int teamIndex)
	{
	}

	public static Color GetMarkColorByTeamIndex2(int teamIndex, bool loopFilter = true)
	{
		return default(Color);
	}

	public static Color GetMarkColorByTeamIndex(int teamIndex)
	{
		return default(Color);
	}

	public static Color GetMarkColorByTeamIndexRoom(int teamIndex)
	{
		return default(Color);
	}

	public static Color GetMarkColorByTeam(int teamIndex, byte teamId)
	{
		return default(Color);
	}

	public static Color GetRoomOBPlayerStateTeamColor(byte scTeamId)
	{
		return default(Color);
	}

	public static string GetMarkStrWithName(string name, int teamIndex, BHGGAEEHJCO targetId, string extraStr1 = "  ", string extraStr2 = "  ")
	{
		return null;
	}

	public static Color GetVehicleHPColor(float ratio)
	{
		return default(Color);
	}

	public static Color GetVehicleHPColorForHorse(float ratio)
	{
		return default(Color);
	}

	public static Color GetHPColor(bool isDieing, float ratio)
	{
		return default(Color);
	}

	public static Color GetHPColor(Player player, float ratio)
	{
		return default(Color);
	}

	public static Color GetSPColor()
	{
		return default(Color);
	}

	public static bool GetEPColor(Player player, out Color barColor1, out Color barColor2, out Color labelColor)
	{
		barColor1 = default(Color);
		barColor2 = default(Color);
		labelColor = default(Color);
		return false;
	}

	public static Color GetElitePassColor(bool isFirePass)
	{
		return default(Color);
	}

	public static Color GetHPChangedColor()
	{
		return default(Color);
	}

	public static void SetTagStyle(uint tagType, UISprite tagIcon, uint gameMode, uint matchMode)
	{
	}

	public static bool BindAtlasSpriteByResourceID(ResourceID InResID, UISprite InSprite, Action<bool> onCDNLoaded = null)
	{
		return false;
	}

	public static uint BindAtlasSpriteByResourceIDAsync(ResourceID InResID, UISprite InSprite, Action<UISprite> action = null)
	{
		return 0u;
	}

	public static void SetActive(GameObject go, bool state)
	{
	}

	public static string ToEnglishOrdinal(int number)
	{
		return null;
	}

	public static void SetActive(VFXCreateHelper go, bool state)
	{
	}

	public static bool GetAtlasSpriteByResourceID(ResourceID InResID, out string OutStrSprite, out UIAtlas OutAtlas)
	{
		OutStrSprite = null;
		OutAtlas = null;
		return false;
	}

	public static uint GetAtlasSpriteByResourceIDAsync(int spriteInstanceID, ResourceID InResID, Action<string, UIAtlas> callBack)
	{
		return 0u;
	}

	public static bool Vector3StringToVector3(string str, char splitChar, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public static bool Vector4StringToVector4(string str, char splitChar, out Vector4 result)
	{
		result = default(Vector4);
		return false;
	}

	public static bool Vector2StringToVector2(string str, char splitChar, out Vector2 result)
	{
		result = default(Vector2);
		return false;
	}

	public static void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	public static void SetHippoCrisisLevelIcon(UISprite sprite, uint level)
	{
	}

	public static string GetLevelSprite(int EquipmentLevel)
	{
		return null;
	}

	public static string GetLevelCommonSprite(int level)
	{
		return null;
	}

	public static void SetSpriteNameByString(UISprite sprite, string spriteName, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public static void SetSpriteNameByStringAsync(UISprite sprite, string spriteName, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public static void TryAddBluePrintComposeItem(UISprite bluePrintSprite, uint bluePrintItemID, bool makepixelPerfect = false)
	{
	}

	public static void ShowComposeIconSprite(UISprite sprite, bool isActive)
	{
	}

	public static Vector3[] CalcWigetCornerLocalPos(UIWidget target)
	{
		return null;
	}

	public static void SetTextureUrl(UINetworkTexture cdnTex, string url, TextureScaleType scaleType = TextureScaleType.None, Action callback = null, bool releaseUnused = false, bool needCache = true)
	{
	}

	public static bool SetSpriteNameWithId(UISprite sprite, ResourceID resourceID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true, uint id = 0u)
	{
		return false;
	}

	public static void SetSpriteName(UISprite sprite, ResourceID resourceID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true, Action callbackLoaded = null)
	{
	}

	public static void MakeTextureFit(UITexture texture, TextureScaleType scaleType, int w, int h)
	{
	}

	public static void MakeSpriteFit(UISprite sprite, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public static void SetSkinElement(UISprite sprite, string name, bool async, string defaultName = null, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = false)
	{
	}

	public static uint SetSpriteNameAsync(UISprite sprite, ResourceID resourceID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true, Action loadedCallback = null)
	{
		return 0u;
	}

	private static void OnAtlasSpriteLoaded(UISprite sprite, string spriteName, UIAtlas atlas, SpriteScaleType scaleType, bool makePixelPerfect)
	{
	}

	public static void CancelUIAtlasAsyncLoad(uint ticket)
	{
	}

	public static void SetSpriteTokenIcon(UISprite targetSprite, EInventory.AwardType tokenType, uint tokenID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, bool enableEnlarge = false)
	{
	}

	public static void GetIconValidContentPixSize(UISprite targetSprite, Vector2 maxSize, bool enableEnlarge = false)
	{
	}

	public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, UISprite Bg, Vector2 BgPending, bool BgFixedHeight = true)
	{
	}

	public static void UpdateWidgetColliderWithSpecialGameObject(BoxCollider box, GameObject go, bool considerInactive)
	{
	}

	public static void MoveScrollViewToBottom(UIScrollView scrollView)
	{
	}

	public static bool IsSameList<T>(List<T> list_a, List<T> list_b)
	{
		return false;
	}

	public static void SaveScreenshot(string filePath, OnSavedScreenshot saved, bool needRotationResultPic, int width = 0, int height = 0, bool isIgnoreUI = false, bool waitForOneFrame = false, Camera[] useCustomCameras = null, OnCreatedScreenshot created = null)
	{
	}

	public static RenderTexture RenderToRT(RenderTexture targetRT = null, Action done = null, int width = 0, int height = 0, bool isIgnoreUI = true, Camera[] useCustomCameras = null)
	{
		return null;
	}

	public static void SaveRTToFile(RenderTexture rt, string filePath, OnSavedScreenshotRT saved, bool needRotationResultPic, OnCreatedScreenshotRT created = null)
	{
	}

	public static Texture2D RotationTexture(Texture2D originalTexture, bool clockwise = true)
	{
		return null;
	}

	public static bool SaveImageToFile(Texture2D image, string filePath, bool tryDeleteFirst = true)
	{
		return false;
	}

	public static Texture2D ResizeTexture(Texture2D source, int width, int height, ResizedTexStyle style = ResizedTexStyle.Ori)
	{
		return null;
	}

	public static ImageType GetImageType(byte[] src)
	{
		return ImageType.Null;
	}

	private static void OnRenderedScreenshot()
	{
	}

	private static void OnCameraRenderedScreenshot(ScreenshotRenderHandler handler)
	{
	}

	private static void OnCameraUpdateScreenshot(ScreenshotRenderNewHandler handler)
	{
	}

	private static void OnCameraRenderedScreenshot(ScreenshotRenderNewHandler handler)
	{
	}

	private static void OnCameraUpdateScreenshoWithoutDestory(ScreenshotRenderNewHandler handler)
	{
	}

	private static void OnCameraRenderedScreenshotWithDestory(ScreenshotRenderNewHandler handler)
	{
	}

	public static void RenderScreenshot(RenderTexture screenshot, Action done, bool isIgnoreUI = false, bool waitForOneFrame = false, Camera[] useCustomCameras = null, bool destroyOnCameraRendered = false, bool renderToScreen = true)
	{
	}

	public static int GetRareTypeSortValueByItemID(uint id)
	{
		return 0;
	}

	public static int GetRareTypeSortValue(uint rare)
	{
		return 0;
	}

	public static List<string> GenerateProbabilityStringOnlyQuality(List<RareProbability> probabilityList, string content)
	{
		return null;
	}

	public static List<string> GenerateProbabilityString(List<RareProbability> rare_pr, List<ItemProbability> item_pr, List<AwardTypeProbability> award_type_pr, ESwitch.SwitchFunc probabilitySwitchDesc, uint firstItemId = 0u)
	{
		return null;
	}

	public static void GenerateRareTypeProbability(List<RareProbability> rare_pr, ESwitch.SwitchFunc probabilitySwitchDesc, out List<uint> rareList, out List<string> probabilityList)
	{
		rareList = null;
		probabilityList = null;
	}

	public static void GenerateItemProbability(uint gachaID, List<ItemProbability> item_pr, List<AwardTypeProbability> award_type_pr, ESwitch.SwitchFunc probabilitySwitchDesc, out List<UIGachaRulesPopUpRateItemData> itemInfoList, uint firstItemId = 0u)
	{
		itemInfoList = null;
	}

	public static float GenerateDecimalProbabilityNotString(string content, uint probability)
	{
		return 0f;
	}

	public static string GenerateDecimalProbability(string content, uint probability)
	{
		return null;
	}

	public static string ItemLimitTimeFormat(uint deltaTime)
	{
		return null;
	}

	public static void CalFullScreenSize(out float width, out float height)
	{
		width = default(float);
		height = default(float);
	}

	public static void CalcFullScreenUISize_ExcludeNotch(out float width, out float height)
	{
		width = default(float);
		height = default(float);
	}

	public static void SetCSFactionName(bool isTeamA, UILabel label)
	{
	}

	public static void SetCSFactionIntroduction(bool isTeamA, UILabel label)
	{
	}

	public static void SetCSFactionIcon(bool isTeamA, UISprite sprite, bool isLarge = true)
	{
	}

	public static void SetCSFactionIconNew(bool isTeamA, UISprite sprite, bool isLarge = true)
	{
	}

	public static string CSFactionIcon(bool isTeamA)
	{
		return null;
	}

	public static string CSFactionIconNew(bool isTeamA)
	{
		return null;
	}

	public static void SetFactionIcon(bool attack, UISprite sprite)
	{
	}

	public static string FactionIcon(bool attack)
	{
		return null;
	}

	public static void SetFactionDescription(bool isAttack, UILabel label)
	{
	}

	public static void FilterInput(UIInput input)
	{
	}

	public static CSSharedItemData GetNeedChangeItem(CSSharedItemData itemdata)
	{
		return null;
	}

	public static bool CheckNeedChangeIcon(CSSharedItemData itemdata, out ResourceID resid, out bool isGemOrCoin)
	{
		resid = default(ResourceID);
		isGemOrCoin = default(bool);
		return false;
	}

	public static void AddIncubatorComposeIcon(UISprite bluePrintIcon, ResourceID resID, bool isNeedSpecialModification)
	{
	}

	public static void AddIncubatorComposeIcon(UISprite bluePrintIcon, UIAtlas atlas, string name, bool isNeedSpecialModification)
	{
	}

	private static void SetIncubatorComposeIcon(UISprite boxIcon, UISprite sprite, bool isNeedSpecialModification)
	{
	}

	public static void ChangeIcon(UISprite boxIcon, ResourceID resID, string name, Vector3 pos, bool isGemOrCoin)
	{
	}

	public static void ChangeIcon(UISprite boxIcon, UIAtlas atlas, string name, Vector3 pos, bool isGemOrCoin)
	{
	}

	private static void SetComposeIcon(UISprite boxIcon, UISprite sprite, Vector3 pos, bool isGemOrCoin)
	{
	}

	public static void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityMidBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityBG2(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityBG3(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityProfileCustom(int Quality, UISprite QualityBG, UISprite QualityLight, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityWeapon(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetQualityWithNoBG(int Quality, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static void SetWeaponQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static Color GetHCQualityColor(uint quality, bool isQualityLine = false)
	{
		return default(Color);
	}

	public static void SetHCQualityAtlasSprite(int Quality, UISprite QualityBG)
	{
	}

	public static void SetQualityBGWithoutBg01(int Quality, UISprite QualityBG, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public static int GetAdjustedAnchor(int oldAnchor, float defRatio, float ipxRatio)
	{
		return 0;
	}

	public static void SetSpriteByNum(int num, UISprite[] sprites, string spriteNamePrefix)
	{
	}

	public static string FormatBigNum(string num, int digit = 3, string sign = ",")
	{
		return null;
	}

	public static void InitNGUINotchSetting(bool reset = false)
	{
	}

	public static bool IsBG1500x750(ResourceID bg)
	{
		return false;
	}

	public static bool IsBG1834x1070(ResourceID bg)
	{
		return false;
	}

	public static Vector2 FitBgSize(int width, int height)
	{
		return default(Vector2);
	}

	public static void ClipCDNTexture(UINetworkTexture cdnTexture)
	{
	}

	public static Texture2D GetWorkShopMap(uint mapID)
	{
		return null;
	}

	public static Texture2D GetWorkShopMiniMap(uint mapID)
	{
		return null;
	}

	public static Vector2 ProjectToMapUVPos(uint mapID, Vector2 pos2D)
	{
		return default(Vector2);
	}

	public static void BuildWorkShopMap(SceneEditSlotInfo slotInfo, UITexture bitMaptexture, UISprite iconSprite, UITexture iconSpriteSpawnParent)
	{
	}

	public static bool NeedShowProfileInfo()
	{
		return false;
	}

	public static float CalRatioByGroupMode(CMDBIPLGLGA mode)
	{
		return 0f;
	}

	public static int CalMatchInfoBgWidth(CMDBIPLGLGA mode)
	{
		return 0;
	}

	public static void AdjustClipPanelWithActiveWidth(UIPanel scrollViewPanel, bool changeChild = true)
	{
	}

	public static void SetButtonActiveAndGray(UIButton button, bool active)
	{
	}

	public static void SetUILabelWithSprite(UILabel label, string text, List<ResourceID> resourceList)
	{
	}

	public static void AddAllDragViewIgnorePlayerInput(Transform root)
	{
	}

	public static void ClearIgnoreUserInputState()
	{
	}

	public static StandardTabTagConfig GetStandardTabTagConfig(EEventTag eEvent)
	{
		return null;
	}

	public static void SetLabelColor(UILabel label, string labelColor, string gradientTop = "", string gradientBottom = "")
	{
	}

	public static void SetSpriteColor(UISprite sprite, string spriteColor, string gradientTop = "", string gradientBottom = "")
	{
	}

	public static bool CreateVFXByResName(Transform parent, string resName)
	{
		return false;
	}

	public static GameObject CreateVFXByResID(Transform parent, ResourceID resId, bool needReset = true)
	{
		return null;
	}

	public static GameObject CreateVFXByStringName(Transform parent, string resName)
	{
		return null;
	}

	public static void SetSpriteViewByResName(UISprite sprite, string resName)
	{
	}

	public static void SetEntranceClick(string newbietype, NewbieGuideId guideId)
	{
	}

	public static void ShowEntranceLockTip(uint entranceId)
	{
	}

	public static void ShowEntranceLockTipByLevel(uint unLockLevel)
	{
	}

	public static string GetText(bool locSwitch, string key, object[] args)
	{
		return null;
	}

	public static bool Play(Animation self, string clipName, out float clipLength)
	{
		clipLength = default(float);
		return false;
	}

	public static void Sample(Animation self, string clipName, float samplePercentage)
	{
	}

	public static AnimationState GetAnimStateByIndex(Animation self, int clipIndex)
	{
		return null;
	}

	public static void PlayByIndex(Animation self, int index)
	{
	}

	public static void SampleByIndex(Animation self, int clipIndex, float samplePercentage)
	{
	}

	public static uint CalculateFloorDiscountPercentage(uint originalPrice, uint discountPrice)
	{
		return 0u;
	}

	public static string[] GetAnimationClipNameArrayWithHelper(Animation self)
	{
		return null;
	}

	public static void AdaptationBGSize(UIWidget widget)
	{
	}

	public static void GetMiniMapAndAreaNameRes(uint mapId, string lang, out ResourceID miniMapRes, out ResourceID areaNameRes, bool pcMiniMap = false)
	{
		miniMapRes = default(ResourceID);
		areaNameRes = default(ResourceID);
	}

	public static void GetMiniMapAndAreaNameRes(uint mapId, string lang, out ResourceID miniMapRes, out ResourceID areaNameRes, bool pcMiniMap, uint specialLayerMapId, uint specialLayerId)
	{
		miniMapRes = default(ResourceID);
		areaNameRes = default(ResourceID);
	}

	public static ResourceID GetMiniMapName(uint map_id, string lang)
	{
		return default(ResourceID);
	}

	public static void SetLWFactionName(int teamIndex, UILabel label)
	{
	}

	public static void SetLWFactionIcon(int teamIndex, UISprite sprite)
	{
	}

	public static void ChestChangeText(ChestChangeTextData changeText, UILabel originalLabel, UILabel label)
	{
	}

	private static void ResetChestChangeText(UILabel originalLabel, UILabel changedLabel)
	{
	}

	public static void ChestChangeColor(ChestChangeTextData changeText, UIColor originalColor, UIColor color)
	{
	}

	private static void ResetChestChangeColor(UIColor originalColor, UIColor changedColor)
	{
	}

	public static void ChestChangeSprite(ChestChangeTextData changeText, UISprite originalSprite, UISprite sprite)
	{
	}

	private static void ResetChestChangeSprite(UISprite originalSprite, UISprite changedSprite)
	{
	}

	public static void SetLWRankIcon(int teamIndex, UISprite sprite)
	{
	}

	public static Color GetTeamColor(int index)
	{
		return default(Color);
	}

	public static string getScenePath(Transform obj)
	{
		return null;
	}

	public static string getScenePath(GameObject gameObj)
	{
		return null;
	}

	public static float RoundUpFloatOnePlacae(float number)
	{
		return 0f;
	}

	public static bool SetupHudWeaponIconWithID(uint weaponID, UISprite weaponIcon)
	{
		return false;
	}

	public static string GetPersistentDataTypeToLocKey(IKLCIHIKDJB t)
	{
		return null;
	}

	public static string GetPersistentDataTypeValue(IKLCIHIKDJB t, float val)
	{
		return null;
	}

	public static void ShuffleList<T>(List<T> list)
	{
	}

	public static int AdjustPanelsDepthWithBase(Transform panelsRoot, int baseDepth)
	{
		return 0;
	}

	public static string SecFormat(uint _sec)
	{
		return null;
	}

	private static string ZeroFill(uint n)
	{
		return null;
	}

	public static string CapitalizeFirstLetter(string input)
	{
		return null;
	}

	public static Quaternion CalReverseRotation(Quaternion self)
	{
		return default(Quaternion);
	}

	public static Quaternion CalReverseRotationByRotZ(float mapRotationZ)
	{
		return default(Quaternion);
	}

	public static void SetTechDeviceItemBG(UISprite techDeviceBg, GIICMFPJJLL itemDataEffectLevel)
	{
	}

	public static Color GetColorByString(string str)
	{
		return default(Color);
	}

	public static bool Float3ToVector3(float[] floats, out Vector3 v3)
	{
		v3 = default(Vector3);
		return false;
	}

	public static string GetUpgradeGemIconSpriteName(EUpgradeGemIconState state)
	{
		return null;
	}

	public static Rect GetNormalizedRect(UIWidget widget)
	{
		return default(Rect);
	}

	public static Texture2D BilinearInterpolationResize(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	public static Color GetColorWithAlphaByString(string colorStr)
	{
		return default(Color);
	}

	public static long ConvertTicksToTimeStampMs(long ticks)
	{
		return 0L;
	}

	public static bool ShouldShowUGCCustomCover(SceneEditSlotInfo slotInfo, bool allowUnapprovedCover = false)
	{
		return false;
	}

	public static bool TryGetUGCMapCoverUrl(SceneEditSlotInfo slotInfo, ERecommendationType recommendationType, out string url, bool allowUnapprovedCover = false)
	{
		url = null;
		return false;
	}

	public static string GetUGCMapDefaultCoverUrl(SceneEditSlotInfo slotInfo)
	{
		return null;
	}

	public static void SetUGCMapBg(SceneEditSlotInfo slotInfo, ERecommendationType recommendationType, UINetworkTexture cdnSlotIcon, UITexture gameMapBg, UITexture gameBitMap, UITexture gameBitOutlineMap, UISprite iconItemSprite, bool allowUnapprovedCover = false)
	{
	}

	public static void SetUGCMapBgEditor(SceneEditSlotInfo slotInfo, ERecommendationType recommendationType, GameObject gameMapRoot, UINetworkTexture cdnSlotIcon, UITexture gameMapBg, UITexture gameBitMap, UITexture gameBitOutlineMap, bool allowUnapprovedCover = false)
	{
	}

	public static void SetupShareButton(PlatformType platformType, UIButton button, UISprite sprite, int content)
	{
	}
}
