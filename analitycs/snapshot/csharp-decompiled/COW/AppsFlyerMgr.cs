using System;
using GCommon;
using UnityEngine;
using proto;
using proto.Login;

namespace COW;

public class AppsFlyerMgr
{
	public class GDPR_Identity
	{
		public string identity_type;

		public string identity_value;

		public string identity_format;
	}

	public class GDPR_Req
	{
		public string subject_request_id;

		public string subject_request_type;

		public GDPR_Identity[] subject_identities;

		public string submitted_time;

		public string property_id;
	}

	public enum EnumNewInstallType
	{
		ObbDownload = 2,
		ObbFinish = 4,
		StartGame = 8,
		Eventtypehfbegin = 0x10,
		Eventtypehfcomplete = 0x20,
		Login = 0x40,
		GmsdkBegin = 0x80,
		GmsdkFinish = 0x100,
		Register = 0x200
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Action callback;

		internal void _003C_EnsureOnRequestResponse_003Eb__0(object sender, EventArgs args)
		{
		}
	}

	private static uint eventActivityAwardedCount;

	private static uint eventStoreClicks;

	public static TimeSpan LocalRegistrationTime;

	private static EventHandler _OnRequestResponseCallback;

	private static bool _isStarted;

	private static long _ObbDownloadStart;

	public static string LoginEventTimeKeyEachDay;

	public static string LoginEventTimeKeyLimitDays;

	public static string EnterLobbyKey;

	public const string PRODUCT_TYPE_REBATE_CARD = "RebateCard";

	public const string PRODUCT_TYPE_IAP = "IAP";

	private const string NewInstallPrefKey = "AppsFlyerNewInstallPrefKey";

	public static void OnAppsFlyerScriptAwake(MonoBehaviour handler)
	{
	}

	private static void _EnsureOnRequestResponse(Action callback)
	{
	}

	public static void OnConsent_DMA_EU_Inapplicable(Action callback = null)
	{
	}

	public static void OnConsent_DMA_EU_Applicable(bool acceptDataUsage, bool acceptAdsPersonalization, Action callback = null)
	{
	}

	private static void startSDKWithCallback(Action callback)
	{
	}

	public static void OnLogout()
	{
	}

	public static void OnApplicationPause(bool paused)
	{
	}

	public static void OnApplicationQuit()
	{
	}

	public static void SendCacheEvent()
	{
	}

	public static void tractEventAppOpen()
	{
	}

	public static void trackEventAppStart(string local_version, string region)
	{
	}

	public static void trackEventLoginMethod()
	{
	}

	public static void TrackEventObbDownload(string lang)
	{
	}

	public static void TrackEventObbFinish()
	{
	}

	public static void trackEventLogin(EGLJDBDMENB loginRes)
	{
	}

	public static void trackEventVersionCheck(string local_version, bool is_auto_update)
	{
	}

	public static void trackEventHotUpdateComplete(string local_version, ResErrorCode error_code)
	{
	}

	public static void trackEventFirstEnterLobby(ulong accountID)
	{
	}

	public static void trackEventInviteFriend(ulong accountID)
	{
	}

	public static void trackEventPurchase(ulong accountID, string productType, string productID, string currency, double revenue)
	{
	}

	public static void trackEventGooglePlayGiftCard(ulong accountID, string productID, int amount)
	{
	}

	public static void trackEventActivityAwarded()
	{
	}

	public static void trackEventStoreClicks()
	{
	}

	public static void trackEventAccountRegister(PlatformRegisterRes res, string region)
	{
	}

	public static void SendEventStoreClicks()
	{
	}

	public static void SetTrackEnable(bool enable)
	{
	}

	public static void RequestDelPersonalData()
	{
	}

	private static void GetAdvertisingIdentifierCallBack(string advertisingId, bool trackingEnabled, string errorMsg)
	{
	}

	public static void TrackEventStartGame()
	{
	}

	public static void TrackEventGmsdkBegin(string accountPlatform)
	{
	}

	public static void TrackEventGmsdkFinish(string accountPlatform)
	{
	}

	public static void TrackEventRegister()
	{
	}

	public static bool HasNewInstallKey(EnumNewInstallType type)
	{
		return false;
	}

	public static void SetNewInstallKey(EnumNewInstallType type)
	{
	}
}
