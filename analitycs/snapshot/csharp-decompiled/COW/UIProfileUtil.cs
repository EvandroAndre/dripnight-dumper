using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public static class UIProfileUtil
{
	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public UISprite m_HeadIcon;

		public UITexture uiTexture;

		public UINetworkTexture uiNetworkTexture;

		public bool requestChangeDefault;

		public Action<bool> onAvatarReady;

		internal void _003CSetHeadPic_003Eb__0()
		{
		}
	}

	public static Color Online_ColorOrange;

	public static Color Online_ColorGreen;

	public static Color Busy_ColorBlue;

	public static Color OfflineWithoutMask_Color;

	public static Color OfflineWithMask_Color;

	public static Color LevelLimit_Color;

	public const uint BTN_COLOR_YELLOW = 4256628991u;

	public const uint BTN_COLOR_GRAY = 2189591295u;

	public const uint BG_COLOR_GRAY = 1448630527u;

	public const uint PROFILE_NICKNAME_OFFLINE_GRAY_COLOR = 2341178367u;

	public const uint PROFILE_NICKNAME_CREATOR_COLOR = uint.MaxValue;

	public const uint PROFILE_NICKNAME_CREATOR_GRADIENT_TOP = 4294891007u;

	public const uint PROFILE_NICKNAME_CREATOR_GRADIENT_BOTTOM = 836606975u;

	public const uint PROFILE_NICKNAME_CREATOR_SHADOW_1 = 184549631u;

	public const uint PROFILE_NICKNAME_CREATOR_SHADOW_2 = 4281335910u;

	private static readonly Color PROFILE_NICKNAME_DEFAULT_COLOR;

	public const uint UI_HideClanName = 1u;

	public const uint UI_HideLevel = 2u;

	public const uint UI_ShowRank = 4u;

	public const uint UI_ShowOnline = 8u;

	public const uint UI_GrayOffline = 16u;

	public const uint UI_ShowPlatformIcon = 32u;

	public const uint UI_ShowElitePass = 64u;

	public const uint UI_ShowCSRank = 128u;

	public const uint UI_ShowBtnPinIcon = 256u;

	public const uint UI_ForceShowBRRank = 512u;

	public const uint UI_ShowPeriodicRank = 1024u;

	public const uint UI_ShowGameModeAndInGameTime = 2048u;

	public const uint UI_ShowRecommandReson = 4096u;

	public const uint UI_ShowFloatingWindowRecommandReson = 8192u;

	public const uint UI_ShowCompatibleLoginStatus = 16384u;

	public const uint UI_ShowOfflineMask = 32768u;

	public const uint UI_ForceNoRank = 65536u;

	public const uint UI_ShowSocialHighlight = 131072u;

	public const uint UI_ShowSocialStatus = 262144u;

	public const uint UI_ShowLevelInfo = 524288u;

	public const uint UI_ShowLobbyProfileTip = 1048576u;

	public const uint UI_ShowInGroupAndInSocialArea = 4194304u;

	public const uint UI_ShowClanRecommendState = 8388608u;

	public const uint UI_ShowSeasonReplayDesc = 16777216u;

	public const uint UI_ShowPrimeBadge = 33554432u;

	public const uint UI_HideLeaderboardTitle = 67108864u;

	public const uint UI_HideCallSign = 134217728u;

	public const string DEFAULT_HEADICON = "Icon_face_normal";

	public const string DEFAULT_BRIEF_BANNER = "Icon_callsign_briefbg_default";

	public const string DEFAULT_BANNER = "Icon_callsign_basebg_default";

	public const string DEFAULT_STOREBG_BANNER = "Icon_callsign_storebg_default";

	public const string DEFAULT_PIN = "FF_UI_Pin_Currency";

	private static ResourceID m_NewVaultEmoteSlotResourceID;

	private static ResourceID m_LobbyEmoteSlotResourceID;

	private const uint DEFAULT_HEADPIC_RAEL_ID = 0u;

	public const int NORMAL_EMOTESLOT_CNT = 8;

	private static readonly Dictionary<uint, int> AccountPresenceSortOrder;

	public static int MAX_EMOTESLOT_CNT => 0;

	public static ResourceID NewVaultEmoteSlotResourceID => default(ResourceID);

	public static ResourceID LobbyEmoteSlotResourceID => default(ResourceID);

	public static void ApplyUnifiedNameStyle(BaseProfileInfo profileInfo, UILabel label, bool isUGCScene = false, bool grayOffline = false, bool isBanned = false, bool enableCreatorColor = false)
	{
	}

	public static void ApplyCreatorOnlyNameStyle(UILabel label, uint creatorLevel, bool disableNameColor)
	{
	}

	private static void ApplyPlainNameStyle(UILabel label, Color targetColor)
	{
	}

	private static bool TryApplyPrimeNameStyle(UILabel label, BaseProfileInfo profileInfo)
	{
		return false;
	}

	private static void InitCreatorLvNickNameShowState(UILabel label, bool isCreatorLvEnabled)
	{
	}

	private static bool ShouldUseCreatorNameColor(BaseProfileInfo profileInfo)
	{
		return false;
	}

	private static bool ShouldUseCreatorNameColor(ulong accountId)
	{
		return false;
	}

	private static bool IsCreatorNameColorEnabled(proto.WorkshopAccountSummaryInfo workshopSummaryInfo)
	{
		return false;
	}

	private static bool IsCreatorNameColorEnabled(uint creatorLevel, bool disableNameColor)
	{
		return false;
	}

	public static void SetLobbyEmoteSlotResourceID(bool isBP)
	{
	}

	public static void SetNewVaultEmoteSlotResourceID(bool isBP)
	{
	}

	public static int ComparePresence(proto.EPresence.AccountPresence a, proto.EPresence.AccountPresence b)
	{
		return 0;
	}

	public static string GetPlatformIconByType(AccountExternalPlatform platform)
	{
		return null;
	}

	public static void SetHeadPic(UISprite m_HeadIcon, uint iid, bool asyncEffect = false, bool needEffect = true)
	{
	}

	public static void SetHeadPic(UISprite m_HeadIcon, uint iid, ulong accountId, string externalIcon, proto.EAccount.ExternalIconStatus externalIconStatus, proto.EAccount.ExternalIconShowType externalIconShowType, bool asyncEffect = false)
	{
	}

	public static void SetHeadPic(UISprite m_HeadIcon, uint iid, ulong accountId, proto.ExternalIconInfo externalIconInfo)
	{
	}

	public static void SetHeadPic(UISprite m_HeadIcon, HeadPicData data, bool isDownloadIconCovered = false, bool valutSelectDefault = false, bool requestChangeDefault = false, bool useAsyncEffect = false, bool needEffect = true, Action<bool> onAvatarReady = null)
	{
	}

	public static void SetPinPic(UISprite pinIcon, uint pinId, bool isBigIcon)
	{
	}

	public static void SetBannerWithResourceID(UISprite m_Banner, BannerData data, bool isDownloadIconCovered = false, bool needResetRot = false, bool needEffect = true, bool useAsyncEffect = false)
	{
	}

	public static void SetBanner(UISprite m_Banner, uint bannerId, bool needEffect = true, bool useAsyncEffect = false)
	{
	}

	public static void UpdateHeadPicOrPortraitUrl(UISprite headIcon, UINetworkTexture headTexture, BaseProfileInfo data, GameObject fakeImage = null, bool requestChangeDefault = false)
	{
	}

	public static void UpdateHeadPicOrPortraitUrl(UISprite headIcon, UINetworkTexture headTexture, GroupRecruitTeamMemberInfo memberInfo, GameObject fakeImage = null)
	{
	}

	public static string BlurNickName(string nickName)
	{
		return null;
	}

	public static string MaskString(string str)
	{
		return null;
	}
}
