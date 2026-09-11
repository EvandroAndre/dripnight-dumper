using System;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;

namespace COW;

public static class GameConfig
{
	public enum EAppStore
	{
		GooglePlay,
		GooglePlay_FullPackage,
		Apple,
		Official,
		Huawei,
		ThirdParty,
		Samsung,
		Trial,
		GooglePlay_Max,
		Apple_Max,
		GooglePlay_India,
		Apple_India,
		GooglePlay_Vietnam,
		Apple_Vietnam
	}

	private class LocalConfig
	{
		public string serverUrl;

		public string serverLoginUrl;

		public string CDNAddr;

		public string ABHotUpdaeCDNAddr;

		public string region;

		public string countryCode;

		public string verAddr;

		public bool skipVersionCheck;

		public bool skipResourceDownload;

		public bool hotUpdateUsePersistentDataPath;

		public string ipRegion;

		public string ipAddress;

		public string fakeVersion;

		public bool forceReview;

		public string verbose;

		public string[] SomeLogCallStack;

		public string AgeCtrlByStore_Status;

		public string AgeCtrlByStore_ErrorCode;

		public int AgeCtrlByStore_MinAge;

		public int AgeCtrlByStore_MaxAge;

		public string AgeCtrlByStore_AndroidInstallID;

		public string BillboardDesc;

		public bool AnnouncementDebug;

		public bool garenaOverride;

		public bool garenaSandbox;

		public bool gmsdkEnableDebugLog;

		public bool gmsdkDebugLogShowSensitiveContent;

		public bool legacyGuest;

		public bool accountOverride;

		public bool accountGuestAllowed;

		public bool showAllIngameTutorial;

		public bool debugInfoOverride;

		public bool debugInfoDisplay;

		public bool debugSkipRoomCheck;

		public bool rebateCardOverride;

		public bool rebateCardEnabled;

		public bool paymentBundleOverride;

		public bool paymentBundleEnabled;

		public bool brMatchReviewFullAIThresholdOverride;

		public int brMatchReviewFullAIThreshold;

		public bool paymentShopOverride;

		public bool paymentShopEnabled;

		public bool paymentShopFirstOverride;

		public bool paymentShopFirst;

		public string paymentShopCdnUrl;

		public string paymentShopFallbackStrategy;

		public bool paymentShopFalseFaulty;

		public bool logClipboard;

		public bool preferExternalUnityPaymentShopOverride;

		public bool preferExternalUnityPaymentShop;

		public bool recommitBeforePaymentOverride;

		public bool recommitBeforePayment;

		public bool resetGuest;

		public bool resetGuestBeforeLogin;

		public string testOpenedByUrl;

		public string testOpenedByDeepLinkUrl;

		public string testOpenedByWebViewUrl;

		public string testOpenedByWebViewStyle;

		public string testOpenedByBrowserUrl;

		public uint prepareForNavigatePos;

		public string prepareForNavigateParam;

		public string testOpenedByWebUrl;

		public string testShareUrl;

		public string testInviteUrl;

		public string testReleaseVersion;

		public string testPayMainUrl_Paid;

		public string testPayMainUrl_Unpaid;

		public string testPayItemUrl_iOS;

		public string testPayIAPButtonUrl_Android;

		public string testPaymentActivityImageUrl;

		public string testPayAdImageUrl_Android;

		public string testPayAdClickUrl_Android;

		public string versionOfIAPProducts;

		public string versionOfPaymentBundles;

		public string versionOfRebateCards;

		public ulong paymentBundleNextResetTime;

		public bool logoutStopTPNS;

		public bool showDebugLog;

		public bool showProfilerLogs;

		public bool debugHack;

		public bool showServerTime;

		public bool checkHacker;

		public bool openBetaDebugUI;

		public bool integrationTest;

		public bool enableRemoteConsoleOverride;

		public bool enableRemoteConsole;

		public bool forceWebView;

		public string testWebViewUrl;

		public string testTournamentUrl;

		public string testLiveTVUrl;

		public string testBooyahTVUrl;

		public string testMShopUrl;

		public uint overrideProduction;

		public bool androidWebViewUseActivityOverride;

		public bool androidWebViewUseActivity;

		public bool androidEnhancedNetworkTypeOverride;

		public bool androidEnhancedNetworkType;

		public string testRebateCardNotifyTime;

		public string testPlayTestNotifyTime;

		public int testIAPBundleStoreID;

		public int testIAPBundleDuration;

		public int testMinutesOfNotifyBeforeIAPBundleEnds;

		public bool testIAPBundleFirstTime;

		public bool testIAPBundleAllPurchasable;

		public string reviewIAPBundleStoreIDs;

		public bool forceIAPBundleFullyDisplay;

		public bool forcePlatformFriendReunion;

		public uint reviewIAPBundleStoreType;

		public bool testSparkEventOverride;

		public bool testSparkEventEnable;

		public bool testSparkEventOnEnterLobby;

		public bool testSparkEventDebugMode;

		public bool testSparkEventDebugWithoutMTV;

		public string testDeviceIdForGoogleAdMob;

		public bool testAdMob;

		public bool testAdMobOverride;

		public string testRewardedVideoAdUnitId;

		public bool forceEnableRewardedVideo;

		public bool forceEnableRewardVideoAfterMatch;

		public string testFreeGachaNotifyTime;

		public bool disableRandomDelayForNotifies;

		public int paymentBundleReloadInterval;

		public bool forceDisplayAllPaymentTabs;

		public bool screenshotForIAPBundles;

		public long localNotifyStatsEventLogInterval;

		public bool mambetDebugVoiceOverride;

		public bool mambetDebugVoice;

		public bool pretendUltraWideScreen;

		public bool pretendDisplayCutout;

		public bool autoNotchOverride;

		public bool autoNotch;

		public float autoNotchSizeBias;

		public bool logNetworkType;

		public bool forceCrash;

		public bool enableCDNLogFlush;

		public bool enableUGCFullCustom;

		public bool firebaseSettingsOverride;

		public bool firebaseEnabled;

		public bool firebaseMessagingEnabled;

		public bool firebaseAnalyticsEnabled;

		public bool firebaseCrashlyticsEnabled;

		public bool firebaseMessagingSettingsOverride;

		public bool firebaseMessagingUseUserProperties;

		public bool firebaseMessagingUseTopics;

		public bool debugSpeechRecognition;

		public ulong fcmTokenInspectionMinutes;

		public bool firebaseCrashlyticsUnityLogTypesOverride;

		public int firebaseCrashlyticsUnityLogTypes;

		public bool disableCacheForFirebaseAnalytics;

		public bool disableCacheForFirebaseMessaging;

		public string detectAndroidApplicationBundleIdentifier;

		public bool testChangeClothIngame;

		public float durationforEatingChicken;

		public bool GER_Override;

		public bool GER_Enabled;

		public int GER_Env;

		public string GER_Region;

		public bool GER_BypassAllFilters;

		public string GER_SponsorId;

		public string GER_ApiKey;

		public string GER_EP;

		public bool Subscription_Override;

		public bool Subscription_RebateCard_Enabled;

		public bool Subscription_ElitePass_Enabled;

		public bool Subscription_EvoPass_Enabled;

		public int Subscription_Bundles_Switch;

		public int Subscription_Memership_Switch;

		public int Subscription_EvoPass_Switch;

		public string Subscription_ProductIdentifier_MiniWeekCard;

		public string Subscription_ProductIdentifier_WeekCard;

		public string Subscription_ProductIdentifier_MonthCard;

		public string Subscription_ProductIdentifier_ElitePass;

		public int Subscription_GracePeriod_ProductId;

		public ulong Subscription_GracePeriod_ExpiryTime;

		public string ElitePassSubscribeStart;

		public string ElitePassSubscribeEnd;

		public bool ElitePassSubscribedOverride;

		public bool ElitePassSubscribed;

		public bool showPaymentFailureSignatureOverride;

		public bool showPaymentFailureSignature;

		public bool copyOpenID;

		public string languageCheckFlag;

		public bool livePaymentChannel;

		public bool forceLowMemoryAndLowQuality;

		public bool TPNS_Override;

		public bool TPNS;

		public bool TPNS_FCM;

		public bool TPNS_NoCache;

		public bool TPNS_Preview;

		public bool webViewOverride;

		public bool webViewDisableJavaScriptInjection;

		public bool webViewDisableMediaManipulationOnHideAndShowByJavaScript;

		public bool webViewProtect;

		public bool webViewPromptFaulty;

		public bool webViewFallbackToBrowser;

		public bool webViewFalseFaulty;

		public bool webViewDeferredDisplay;

		public float webViewLoadingProgressAnimationDuration;

		public float webViewPromptReloadDuration;

		public bool webViewOnlyAutoPlayMediaWithWIFI;

		public bool webViewOverrideReloadAsCaptureScreenshot;

		public bool webViewProgressBarOverride;

		public float webViewProgressBarLaunchPercentage;

		public float webViewProgressBarLaunchDuration;

		public string webViewProgressTextLaunchColor;

		public string webViewProgressTextLoadColor;

		public string webViewJavaScriptName;

		public bool webViewRunJavaScript;

		public string webViewJavaScriptEcho;

		public bool webViewLogConsoleMessages;

		public bool androidWebViewActivityDebugLog;

		public bool webViewWebContentDebugging;

		public bool overrideXHK;

		public bool XHK;

		public bool overrideXHK_Revise;

		public bool XHK_Revise;

		public string webViewLogUrls;

		public string googleClientId;

		public int veteranReminderDays;

		public bool UMALogErrors;

		public bool UMALogDetails;

		public bool UMALogDetails3P;

		public bool UMALogTimes;

		public bool PGSRecallOverride;

		public bool PGSRecallWrite;

		public bool PGSRecallRead;

		public bool testServerForPGS;

		public bool inAppReviewOverride;

		public bool inAppReviewEnabled;

		public string test_hook;

		public bool testFireWallOpen;

		public bool lessIsMoreTest;

		public bool lessIsMoreOverride;

		public bool lessIsMoreUseGMSDK;

		public ulong lessIsMoreMinReloadInterval;

		public int lessIsMoreMaxReloadFailures;

		public ulong lessIsMorePendingReloadInterval;

		public string turnOnPersonalizedOffer;

		public string turnOffPersonalizedOffer;

		public string webPageFallbackStrategy;

		public string translateDeepLinkInput;

		public string translateDeepLinkOutput;

		public string overrideGOPAuthUrl;

		public string overrideGOPPayUrl;

		public bool msdkRegForm_ForceDisplay;

		public bool overrideDynamicFontFallbackNotDefGlyph;

		public bool dynamicFontFallbackNotDefGlyph;

		public bool testInvalidClientVersion;

		public bool testCodePatch;

		public bool logToken;

		public bool ffaiTraining;

		public string ffaiParamStr;

		public string LatestReleaseVersion;

		public bool enableBackendLogJson;

		public bool autoResetHotupdate;

		public bool enableTrialDebugRemoteConsole;

		public bool clearIconCDNCache;

		public string CustomAIChatLang;

		public string UnityMobileInfoViewerHostIp;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<int, string> _003C_003E9__291_0;

		internal string _003Cget_ReviewIAPBundleStoreIDs_003Eb__291_0(int id)
		{
			return null;
		}
	}

	public static string ReleaseVersion;

	public static string VerAddr;

	public static string CDNAddr;

	public static string ABHotUpdateCDNAddr;

	public static string IconCDNAddr;

	public static string ServerAddr;

	public static string MajorServerAddr;

	public static string LogServerAddr;

	public static string NetworkLogServerAddr;

	public static string NetworkDetectionServerAddr;

	public static string GIProxyGatewayUrl;

	private static bool _IsIOSReview;

	private static int backupAddrIndex;

	private static List<string> backupVerAddrs;

	public const bool IsPcBuild = false;

	public const bool IsPcBuildHasHotAb = true;

	public const bool IsPcBuildHasOptAb = false;

	public const bool IsPcBuildHasWwise = true;

	public static bool SkipVersionCheck;

	public static bool SkipResourceDownload;

	public static bool EnableBackgroundThread;

	public static bool EnableRefreshFile;

	public static bool LegacyGuest;

	public static EAppStore AppStore;

	public static string AppStoreAddr;

	public static string BackupAppStoreAddr;

	public static bool NeedBigFileDownloadForHotupdate;

	public static bool OpenOptionalDownloadInLogin;

	public static bool UseAssetBundle;

	public static LocLang CurrentLang;

	public static float CAM_OFFSET_FOR_SNIPER;

	public static string ClientIP;

	public static int EuroPolicyVersion;

	public static string MULTISESSION_CONNECTION_KEY;

	private static string _Country;

	public static bool IsFirewallOpen;

	public static bool MuteSound;

	public static string DevId;

	public static bool DebugMode;

	private static bool _ShowDebugInfo;

	public static string randomDevId;

	private static bool _ShowDebugUI;

	public static bool DrawAimAssistDebugInfo;

	public static bool TestModeEnabled;

	public static bool EnableRemoteConsole;

	public static string UrgentAnnouncement;

	public static bool DebugHack;

	public static bool garenaProduction;

	public static string garenaAppId;

	public static string garenaAppKeySandbox;

	public static string garenaAppKeyProduction;

	public const string GOOGLE_CLIENT_ID = "185753624591-3sg2arfuus5i1anc2jcfarepnf6cdlaq.apps.googleusercontent.com";

	private static string _OverrideGOPAuthUrl;

	private static string _OverrideGOPPayUrl;

	public const string GOP_CHECK_BIND = "oauth/token/checkbind";

	public static string garenaPushAppkeySandbox;

	public static string garenaPushAppkeyProduction;

	public static int NeedCheckLoginFailedCount;

	private static bool _GarenaLogin;

	private static bool _GarenaLoginHint;

	private static LocalConfig m_LocalConfig;

	private static bool? _LivePayRuntimeStatus;

	private static DateTime APOCH_UTC;

	private static readonly string[] _WebViewLogUrlSeparators;

	private static string[] _WebViewLogUrls;

	private static bool _003CTestChangeClothIngame_003Ek__BackingField;

	private static bool _003CTestAutoChangeClothInGame_003Ek__BackingField;

	private static UserAgeMgr.AgeResult _AgeCtrlByStore_FakeResult;

	public static bool IsIOSReview
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string Country
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool ShowAllIngameTutorial => false;

	public static bool ShowDebugInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ShowDebugUI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ShowServerTime => false;

	public static bool CheckHacker => false;

	public static bool OpenBetaDebugUI => false;

	public static bool IntegrationTest => false;

	public static string GarenaAppKey => null;

	public static string GoogleClientID => null;

	public static string OverrideGOPAuthUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string OverrideGOPPayUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string GOP_URL => null;

	public static string GarenaPushAppKey => null;

	public static bool AutoResetHotUpdate => false;

	public static bool HotUpdateUsePersistentDataPath => false;

	public static bool LessIsMoreTest => false;

	public static bool LessIsMoreOverride => false;

	public static bool LessIsMoreUseGMSDK => false;

	public static ulong LessIsMoreMinReloadInterval => 0uL;

	public static int LessIsMoreMaxReloadFailures => 0;

	public static ulong LessIsMorePendingReloadInterval => 0uL;

	public static bool TestCodePatch => false;

	public static bool LogToken => false;

	public static bool DebugSpeechRecognition => false;

	public static string WebPageFallbackStrategy => null;

	public static string TranslateDeepLinkInput => null;

	public static string TranslateDeepLinkOutput => null;

	public static int VeteranReminderDays => 0;

	public static bool? DisplayDebugInfo => null;

	public static bool DebugSkipRoomCheck => false;

	public static string VersionOfIAPProducts => null;

	public static float DurationForEatingChicken => 0f;

	public static string VersionOfPaymentBundles => null;

	public static string VersionOfRebateCardss => null;

	public static ulong PaymentBundleNextResetTime => 0uL;

	public static string TestPayMainUrl_Paid => null;

	public static string TestPayMainUrl_Unpaid => null;

	public static string TestPaymentActivityImageUrl => null;

	public static string TestPayItemUrl_iOS => null;

	public static string TestPayIAPButtonUrl_Android => null;

	public static string TestPayAdImageUrl_Android => null;

	public static string TestPayAdClickUrl_Android => null;

	public static string TestShareUrl => null;

	public static string TestInviteUrl => null;

	public static string TestOpenedByUrl => null;

	public static string TestOpenedByWebUrl => null;

	public static string TestOpenedWithDeepLinkUrl => null;

	public static string TestOpenedWithWebViewUrl => null;

	public static string TestOpenedWithWebViewStyle => null;

	public static string TestOpenedWithBrowserUrl => null;

	public static uint PrepareForNavigatePos => 0u;

	public static string PrepareForNavigateParam => null;

	public static string BillboardTestDesc => null;

	public static bool GMSDKEnableDebugLog => false;

	public static bool GMSDKDebugLogShowSensitiveContent => false;

	public static bool ResetGuest => false;

	public static bool ResetGuestBeforeLogin => false;

	public static bool RebateCardOverride => false;

	public static bool RebateCardEnabled => false;

	public static bool PaymentBundleOverride => false;

	public static bool PaymentBundleEnabled => false;

	public static bool BRMatchReviewFullAIThresholdOverride => false;

	public static int BRMatchReviewFullAIThreshold => 0;

	public static bool PaymentShopOverride => false;

	public static bool PaymentShopEnabled => false;

	public static bool PaymentShopFirstOverride => false;

	public static bool CDNLogFlushImmediate => false;

	public static bool PaymentShopFirst => false;

	public static string PaymentShopCdnUrl => null;

	public static string PaymentShopFallbackStrategy => null;

	public static bool PaymentShopFalseFaulty => false;

	public static bool LogClipboard => false;

	public static bool PreferExternalUnityPaymentShopOverride => false;

	public static bool PreferExternalUnityPaymentShop => false;

	public static bool RecommitBeforePaymentOverride => false;

	public static bool RecommitBeforePayment => false;

	public static bool ForceDisplayAllPaymentTabs => false;

	public static bool ScreenshotForIAPBundles => false;

	public static bool LogoutStopTPNS => false;

	public static bool ForceWebView => false;

	public static string TestWebViewUrl => null;

	public static string TestReleaseVersion => null;

	public static string TestTournamentUrl => null;

	public static string TestLiveTVUrl => null;

	public static string TestBooyahTVUrl => null;

	public static string TestMShopUrl => null;

	public static uint OverrideProduction => 0u;

	public static bool AndroidWebViewUseActivityOverride => false;

	public static bool AndroidWebViewUseActivity => false;

	public static bool AndroidEnhancedNetworkTypeOverride => false;

	public static bool AndroidEnhancedNetworkType => false;

	public static bool LivePaymentChannel
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ForceLowMemoryAndLowQuality => false;

	public static long TestRebateCardNotifyTimeOfDay_Local_MS => 0L;

	public static long TestPlayTestNotifyTimeOfDay_Local_MS => 0L;

	public static string TestHook => null;

	public static int TestIAPBundleStoreID => 0;

	public static int TestIAPBundleDuration => 0;

	public static int TestMinutesOfNotifyBeforeIAPBundleEnds => 0;

	public static bool TestIAPBundleFirstTime => false;

	public static bool TestIAPBundleAllPurchasable => false;

	public static uint ReviewIAPBundleStoreType => 0u;

	public static int[] ReviewIAPBundleStoreIDs => null;

	public static bool ForceIAPBundleFullyDisplay => false;

	public static bool ForcePlatformFriendReunion => false;

	public static bool? TestSparkEventEnabled => null;

	public static bool? TestSparkEventDebugWithoutMTV => null;

	public static bool? TestSparkEventOnEnterLobby => null;

	public static bool? TestSparkEventDebugMode => null;

	public static long TestFreeGachaNotifyTimeOfDay_Local_MS => 0L;

	public static bool DisableRandomDelayForNotifies => false;

	public static string DetectAndroidApplicationBundleIdentifier => null;

	public static string TestDeviceIdForGoogleAdMob => null;

	public static bool TestAdMobOverride => false;

	public static string TestRewardedVideoAdUnitId => null;

	public static bool TestAdMob => false;

	public static bool ForceEnableRewardedVideo => false;

	public static bool ForceEnableRewardVideoAfterMatch => false;

	public static int PaymentBundlesReloadInterval => 0;

	public static long LocalNotifyStatsEventLogInterval => 0L;

	public static bool ForceCrash => false;

	public static bool EnableUGCFullCustom => false;

	public static bool DisableCacheForFirebaseAnalytics => false;

	public static bool DisableCacheForFirebaseMessaging => false;

	public static bool FirebaseSettingsOverride => false;

	public static bool FirebaseEnabled => false;

	public static bool FirebaseMessagingEnabled => false;

	public static bool FirebaseAnalyticsEnabled => false;

	public static bool FirebaseCrashlyticsEnabled => false;

	public static bool FirebaseMessagingSettingsOverride => false;

	public static bool FirebaseMessagingUseUserProperties => false;

	public static bool FirebaseMessagingUseTopics => false;

	public static ulong FcmTokenInspectionMinutes => 0uL;

	public static bool GER_Override => false;

	public static bool GER_Enabled => false;

	public static int GER_Env => 0;

	public static string GER_SponsorId => null;

	public static bool GER_BypassAllFilters => false;

	public static string GER_ApiKey => null;

	public static string GER_EP => null;

	public static bool Subscription_Override => false;

	public static bool Subscription_RebateCard_Enabled => false;

	public static bool Subscription_EvoPass_Enabled => false;

	public static bool Subscription_ElitePass_Enabled => false;

	public static int Subscription_Bundles_Switch => 0;

	public static int Subscription_Membership_Switch => 0;

	public static int Subscription_EvoPass_Switch => 0;

	public static string Subscription_ProductIdentifier_ElitePass => null;

	public static string Subscription_ProductIdentifier_MonthCard => null;

	public static string Subscription_ProductIdentifier_WeekCard => null;

	public static string Subscription_ProductIdentifier_MiniWeekCard => null;

	public static int Subscription_GracePeriod_ProductId => 0;

	public static ulong Subscription_GracePeriod_ExpiryTime => 0uL;

	public static bool ShowPaymentFailureSignatureOverride => false;

	public static bool ShowPaymentFailureSignature => false;

	public static long ElitePassSubscribeStart_Seconds => 0L;

	public static long ElitePassSubscribeEnd_Seconds => 0L;

	public static bool ElitePassSubscribedOverride => false;

	public static bool ElitePassSubscribed => false;

	public static bool CopyOpenID => false;

	public static bool TPNS_Override => false;

	public static bool TPNS => false;

	public static bool TPNS_FCM => false;

	public static bool TPNS_NoCache => false;

	public static bool TPNS_Preview => false;

	public static bool WebViewOverride => false;

	public static bool WebViewDisableJavaScriptInjection => false;

	public static bool WebViewOnlyAutoPlayMediaWithWIFI => false;

	public static bool WebViewOverrideReloadAsCaptureScreenshot => false;

	public static bool WebViewDisableMediaManipulationOnHideAndShowByJavaScript => false;

	public static bool WebViewProtect => false;

	public static bool WebViewPromptFaulty => false;

	public static bool WebViewFallbackToBrowser => false;

	public static bool WebViewFalseFaulty => false;

	public static string WebViewJavaScriptName => null;

	public static string CustomAIChatLang => null;

	public static bool WebViewRunJavaScript => false;

	public static string WebViewJavaScriptEcho => null;

	public static bool WebViewLogConsoleMessages => false;

	public static bool AndroidWebViewActivityDebugLog => false;

	public static bool WebViewWebContentDebugging => false;

	public static bool WebViewProgressBarOverride => false;

	public static float WebViewProgressBarLaunchPercentage => 0f;

	public static float WebViewProgressBarLaunchDuration => 0f;

	public static string WebViewProgressTextLaunchColor => null;

	public static string WebViewProgressTextLoadColor => null;

	public static bool OverrideXHK => false;

	public static bool XHK => false;

	public static bool OverrideXHK_Revise => false;

	public static bool XHK_Revise => false;

	public static string[] WebViewLogUrls => null;

	public static bool WebViewDeferredDisplay => false;

	public static float WebViewLoadingProgressAnimationDuration => 0f;

	public static float WebViewPromptReloadDuration => 0f;

	public static bool MambetDebugVoiceOverride => false;

	public static bool MambetDebugVoice => false;

	public static bool LogNetworkType => false;

	public static bool MsdkRegForm_ForceDisplay => false;

	public static bool PretendUltraWideScreen => false;

	public static bool PretendDisplayCutout => false;

	public static bool AutoNotchOverride => false;

	public static bool AutoNotch => false;

	public static float AutoNotchSizeBias => 0f;

	public static bool AccountOverride => false;

	public static bool AccountGuestAllowed => false;

	public static string LanguageCheckFlag => null;

	public static bool TestChangeClothIngame
	{
		get
		{
			return _003CTestChangeClothIngame_003Ek__BackingField;
		}
		set
		{
			_003CTestChangeClothIngame_003Ek__BackingField = value;
		}
	}

	public static bool TestAutoChangeClothInGame
	{
		get
		{
			return _003CTestAutoChangeClothInGame_003Ek__BackingField;
		}
		set
		{
			_003CTestAutoChangeClothInGame_003Ek__BackingField = value;
		}
	}

	public static bool IsAnnouncementDebugMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool UMALogErrors => false;

	public static bool UMALogDetails => false;

	public static bool UMALogDetails3P => false;

	public static bool UMALogTimes => false;

	public static bool InAppReviewOverride => false;

	public static bool InAppReviewEnabled => false;

	public static bool PGSRecallOverride => false;

	public static bool PGSRecallRead => false;

	public static bool PGSRecallWrite => false;

	public static bool TestServerForPGS => false;

	public static UserAgeMgr.AgeResult AgeCtrlByStore_FakeResult => null;

	public static string IPRegion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string IPAddress
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool TestInvalidClientVersion => false;

	public static bool ShowDebugLog => false;

	public static bool ShowProfilerLogs => false;

	public static bool IsFFAITraining => false;

	public static string LatestReleaseVersion => null;

	public static bool EnableBackendLogJson => false;

	public static string FFAIParam => null;

	public static bool EnableTrialDebugRemoteConsole => false;

	public static bool ClearIconCDNCache => false;

	public static string UnityMobileInfoViewerHostIp => null;

	private static string BuildVerAddr(int[] codes)
	{
		return null;
	}

	public static void OverrideServerAddr(string addr)
	{
	}

	public static bool NeedRefreshFile()
	{
		return false;
	}

	public static void SetOverrideGOPUrlFromVersion(string gop_url)
	{
	}

	public static void SetGarenaLoginInfo(bool login, bool hint)
	{
	}

	private static string[] ParsePaymentTypes(string types)
	{
		return null;
	}

	public static bool IsOfferPersonalized(string lockRegion, string paymentType)
	{
		return false;
	}

	public static bool LocalConfigFireWallOpen()
	{
		return false;
	}

	private static long _DateTimeToTimeStamp(string timeString)
	{
		return 0L;
	}

	private static long _TimeOfDayToMS(string timeString)
	{
		return 0L;
	}

	public static string GetClientIP()
	{
		return null;
	}

	private static string GetLocalIPAddress()
	{
		return null;
	}

	public static void SelectServer(ServerSettingsData region)
	{
	}

	public static void UpdateServerConfigFromHTTPVerGet(string serverAddr, string cdnAddr, bool isIOSReview, string abHotupdateAddr)
	{
	}

	public static string GetRegion()
	{
		return null;
	}

	private static LocalConfig ReadUrlFromLocalConfig()
	{
		return null;
	}

	private static void SetAppSrc()
	{
	}

	public static void GotoAppSrc()
	{
	}

	public static void Reset()
	{
	}

	public static bool IsRTLLanguage()
	{
		return false;
	}

	public static bool CheckIsConfigVerAddr()
	{
		return false;
	}

	public static void UpdateVerBose(string verbose)
	{
	}

	public static string SwitchBackupVerAddr()
	{
		return null;
	}
}
