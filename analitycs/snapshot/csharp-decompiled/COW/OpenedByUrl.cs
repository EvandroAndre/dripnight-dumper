using System;
using System.Collections.Generic;
using GCommon;
using InterApp;
using proto;

namespace COW;

public static class OpenedByUrl
{
	public static class DownloadUrls
	{
		public const string STD = "http://play.google.com/store/apps/details?id=com.dts.freefireth";

		public const string MAX = "http://play.google.com/store/apps/details?id=com.dts.freefiremax";
	}

	public static class BundleIDs
	{
		public const string STD = "com.dts.freefireth";

		public const string MAX = "com.dts.freefiremax";
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__76_0;

		internal bool _003CInit_003Eb__76_0(string urlScheme)
		{
			return false;
		}

		internal void _003C_002Ecctor_003Eb__111_0(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_1(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_2(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_3(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_4(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_5(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_6(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_7(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_8(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_9(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_10(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_11(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_12(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_13(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_14(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_15(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_16(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_17(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_18(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_19(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_20(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_21(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_22(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_23(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_24(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_25(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_26(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_27(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_28(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_29(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_30(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_31(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_32(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_33(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_34(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_35(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_36(InterAppAction action)
		{
		}

		internal void _003C_002Ecctor_003Eb__111_37(InterAppAction action)
		{
		}
	}

	public const string VERSION_KEY = "version";

	public const string ACTION_KEY = "action";

	private static bool _Inited;

	public const string ACTION_GROUP_INVITE = "group_invite";

	public const string ACTION_LOBBY = "lobby";

	public const string ACTION_GACHA = "gacha";

	public const string ACTION_MAIL = "mail";

	public const string ACTION_CHARACTERS_NEW = "characters_new";

	public const string ACTION_ELITE_PASS = "elite_pass";

	public const string ACTION_REBATE_CARD = "rebate_card";

	public const string ACTION_IAP_BUNDLE = "iap_bundle";

	public const string ACTION_REUNION = "reunion";

	public const string ACTION_NAVIGATE = "navigate";

	public const string ACTION_INVITE_TO_CLAN = "locate_clan";

	public const string ACTION_INVITE_TO_ROOM = "locate_room";

	public const string ACTION_SUPERCAR = "supercar";

	public const string ACTION_CLANWAR_RECRUIT = "clanwar_recruit";

	public const string ACTION_UGC_MYWORKS = "ugc_myworks";

	public const string ACTION_UGC_MAPCODE = "ugc_mapdetail";

	public const string ACTION_HUD_SHARE = "hud_share";

	public const string ACTION_GROUP_REMIND = "group_remind";

	public const string ACTION_VETERAN_FRIEND_NOTIFY = "veteran_friend_notify";

	public const string ACTION_WEBVIEW = "webview";

	public const string ACTION_CLAN_MAIN_PAGE = "clan_main_page";

	public const string ACTION_SQUAD_TREASURE_TEAM_INFO = "squad_treasure_team_info";

	public const string ACTION_SQUAD_TREASURE_MAIN_PAGE = "squad_treasure_main_page";

	public const string ACTION_TOURNAMENT_SPECTATE = "tournament_spectate";

	public const string ACTION_VIEW_TOURNAMENT_PAGE = "view_tournament_page";

	public const string ACTION_TOURNAMENT_OFFLINE_PUSH = "tournament_offline_push";

	public const string ACTION_TOURNAMENT_OFFLINE_CHECKIN = "tournament_offline_checkin";

	public const string ACTION_CLANWAR_NOTIFY = "clanwar_notify";

	public const string ACTION_BIG_EVENT = "big_event";

	public const string ACTION_RELAY_MART = "relay_mart";

	public const string ACTION_SYSTEM_CALENDAR = "system_calendar";

	public const string ACTION_QRCODE_ADD_FRIEND = "qrcode_add_friend";

	public const string ACTION_QRCODE_ADD_CLAN = "qrcode_add_clan";

	public const string ACTION_QRCODE_GROUP_INVITE = "qrcode_group_invite";

	public const string ACTION_QRCODE_ROOM_INVITE = "qrcode_room_invite";

	public const string ACTION_QRCODE_ROOM_INVITE_LINK = "qrcode_room_invite_link";

	public const string ACTION_QRCODE_UGC_MAPCODE = "qrcode_ugc_mapdetail";

	public const string ACTION_QRCODE_SQUAD_TREASURE_TEAM_INFO = "qrcode_squad_treasure_team_info";

	public const string ACTION_FRIEND_INVITE = "friend_invite";

	private static Dictionary<string, InterAppActionType> _ActionTypes;

	private const string PLAYER_PREFS_KEY_NOTIFY_TYPES = "OpeneneWithLocalNotificationTypes";

	private static Dictionary<string, bool> _LoggedOpenedWithRmtNtfs;

	private static Dictionary<string, bool> _LoggedEventPushLinkReturns;

	private static List<UniversalLinkSettingDesc> _WebUrlToDeepLinks;

	private static readonly AES.AESOption aesOption;

	public static string URL => null;

	public static Dictionary<int, int> OpenedWithLocalNotificationTypes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static string DeepLinkUrl(string urlScheme)
	{
		return null;
	}

	private static void Log(string content)
	{
	}

	public static string PrepareForGroupInvite(string url, string groupId, string region, string secretCode)
	{
		return null;
	}

	public static string PrepareForRebateCard()
	{
		return null;
	}

	public static string PrepareForLobby()
	{
		return null;
	}

	public static string PrepareForSystemCalendar(string ff_event_name, string ff_event_id)
	{
		return null;
	}

	public static string PrepareForReunion(string url, string uid)
	{
		return null;
	}

	public static string PrepareForIAPBundle()
	{
		return null;
	}

	public static string PrepareForNavigate(string url, uint pos, string param = "")
	{
		return null;
	}

	public static string PrepareForInviteToClan(string url, string clanId)
	{
		return null;
	}

	public static string PrepareForInviteToRoom(string url, int roomType, string roomId)
	{
		return null;
	}

	public static string PrepareForInviteToJoinRoom(string url, int roomID, string roomQRCode)
	{
		return null;
	}

	public static string PrepareForWorkshopDetail(string url, string mapcode, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareDeepLinkForHudShare(string url, string shareCode, QRCodeGenerationChannel qRCodeGenerationChannel)
	{
		return null;
	}

	public static string PrepareDeepLinkForGroupInvite(string url, string groupId, string region, string secretCode)
	{
		return null;
	}

	public static string PrepareDeepLinkForGroupRemind(string url)
	{
		return null;
	}

	public static string PrepareDeepLinkForVeteranFriendNotify(string url)
	{
		return null;
	}

	public static string PrepareDeepLinkForWebView(string baseUrl, string webviewUrl, string style = "")
	{
		return null;
	}

	public static string PrepareDeepLinkForClanMainPage(string url)
	{
		return null;
	}

	public static string PrepareDeepLinkForClanWarNotify(string url)
	{
		return null;
	}

	public static string PrepareDeepLinkForSquadTreasureMainPage(string url)
	{
		return null;
	}

	public static string PrepareDeepLinkForSquadTreasureTeamInfo(string url, string groupId)
	{
		return null;
	}

	public static string PrepareDeepLinkForRelayMart(string url, string discountCode)
	{
		return null;
	}

	public static string PrepareDeepLinkForQRCodeAddFriend(string url, string accoutId, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareDeepLinkForQRCodeAddClan(string url, string clanId, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareDeepLinkForQRCodeGroupInvite(string url, string groupId, string qrSerectCode, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareDeepLinkForQRCodeRoomInvite(string url, string roomId, string qrSerectCode, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareDeepLinkForQRCodeSquadTreasureTeamInfo(string url, string groupId, string region, string lang, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	public static string PrepareForFriendInvite(string url, string inviterUid)
	{
		return null;
	}

	public static void Init()
	{
	}

	private static void ProcessFallback(string url)
	{
	}

	private static PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
	{
		return null;
	}

	private static string TranslateWebUrlToDeepLink(string webUrl)
	{
		return null;
	}

	public static string TranslateWebUrlToDeepLinkForQRCode(string webUrl)
	{
		return null;
	}

	private static PlatformUtility.OpenedWith CollectOpenedWith()
	{
		return null;
	}

	public static bool WillProcessOpenedWith()
	{
		return false;
	}

	public static InterAppAction PeekInterAppActionByOpenedWith()
	{
		return null;
	}

	public static InterAppAction PeekInterAppActionByUrl(string url)
	{
		return null;
	}

	public static void LogOpenedWith()
	{
	}

	private static string GetEventPushReturnFromUrl(PlatformUtility.OpenedWith ow)
	{
		return null;
	}

	private static bool TryGetEventPushReturnUrl(Dictionary<string, string> parameters, string key, out string url)
	{
		url = null;
		return false;
	}

	private static string UriUnescapeEventPushReturnUrl(string url)
	{
		return null;
	}

	public static void SetupWebUrlToDeepLinks(CSGetUniversalLinkSettingRes res)
	{
	}

	public static void OnQueued()
	{
	}

	public static void OnDone()
	{
	}

	public static void ProcessOpenedWith()
	{
	}

	private static bool WillProcessParams(OpenedWithParamsDelegate.OpenedWithParams parameters)
	{
		return false;
	}

	private static void ProcessParams(OpenedWithParamsDelegate.OpenedWithParams parameters)
	{
	}

	private static bool WillProcess(string url)
	{
		return false;
	}

	public static bool WillProcessWithAction(string url, Action CheckVersionFallback, OpenedByUrlProcessor.WillProcessDelegate WillProcessFallback)
	{
		return false;
	}

	public static void Process(string url)
	{
	}

	public static string ToBase64(string str)
	{
		return null;
	}

	public static string FromBase64(string base64)
	{
		return null;
	}

	public static string GetClientVersion()
	{
		return null;
	}

	public static bool CheckClientVersion(InterAppActionType actionType, InterAppAction action)
	{
		return false;
	}

	public static void OnCheckVersionFailed()
	{
	}
}
