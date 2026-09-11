using System;
using System.Collections.Generic;
using UnityEngine;

namespace AppsFlyerSDK;

public class AppsFlyer : MonoBehaviour
{
	public delegate void unityCallBack(string message);

	public static readonly string kAppsFlyerPluginVersion;

	public static string CallBackObjectName;

	private static EventHandler onRequestResponse;

	private static EventHandler onInAppResponse;

	private static EventHandler onDeepLinkReceived;

	public static IAppsFlyerNativeBridge instance;

	public static event EventHandler OnRequestResponse
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler OnInAppResponse
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler OnDeepLinkReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void initSDK(string devKey, string appID)
	{
	}

	public static void initSDK(string devKey, string appID, MonoBehaviour gameObject)
	{
	}

	public static void startSDK()
	{
	}

	public static void sendEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	public static void stopSDK(bool isSDKStopped)
	{
	}

	public static bool isSDKStopped()
	{
		return false;
	}

	public static string getSdkVersion()
	{
		return null;
	}

	public static void setIsDebug(bool shouldEnable)
	{
	}

	public static void setCustomerUserId(string id)
	{
	}

	public static void setAppInviteOneLinkID(string oneLinkId)
	{
	}

	public static void setDeepLinkTimeout(long deepLinkTimeout)
	{
	}

	public static void setAdditionalData(Dictionary<string, string> customData)
	{
	}

	public static void setResolveDeepLinkURLs(string[] urls)
	{
	}

	public static void setOneLinkCustomDomain(string[] domains)
	{
	}

	public static void setCurrencyCode(string currencyCode)
	{
	}

	public static void setConsentData(AppsFlyerConsent appsFlyerConsent)
	{
	}

	public static void recordLocation(double latitude, double longitude)
	{
	}

	public static void anonymizeUser(bool shouldAnonymizeUser)
	{
	}

	public static void enableTCFDataCollection(bool shouldCollectTcfData)
	{
	}

	public static string getAppsFlyerId()
	{
		return null;
	}

	public static void setMinTimeBetweenSessions(int seconds)
	{
	}

	public static void setHost(string hostPrefixName, string hostName)
	{
	}

	public static void setUserEmails(EmailCryptType cryptType, string[] userEmails)
	{
	}

	public static void updateServerUninstallToken(string token)
	{
	}

	public static void setPhoneNumber(string phoneNumber)
	{
	}

	public static void setImeiData(string aImei)
	{
	}

	public static void setSharingFilterForAllPartners()
	{
	}

	public static void setAndroidIdData(string aAndroidId)
	{
	}

	public static void waitForCustomerUserId(bool wait)
	{
	}

	public static void setSharingFilter(string[] partners)
	{
	}

	public static void setCustomerIdAndStartSDK(string id)
	{
	}

	public static void setSharingFilterForPartners(string[] partners)
	{
	}

	public static string getOutOfStore()
	{
		return null;
	}

	public static void setOutOfStore(string sourceName)
	{
	}

	public static void getConversionData(string objectName)
	{
	}

	public static void setCollectAndroidID(bool isCollect)
	{
	}

	public static void setIsUpdate(bool isUpdate)
	{
	}

	public static void setCollectIMEI(bool isCollect)
	{
	}

	public static void setDisableCollectAppleAdSupport(bool disable)
	{
	}

	public static void setShouldCollectDeviceName(bool shouldCollectDeviceName)
	{
	}

	public static void attributeAndOpenStore(string appID, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject)
	{
	}

	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	public static void setDisableCollectIAd(bool disableCollectIAd)
	{
	}

	public static bool isPreInstalledApp()
	{
		return false;
	}

	public static void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox)
	{
	}

	public static void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters)
	{
	}

	public static void setUseUninstallSandbox(bool useUninstallSandbox)
	{
	}

	public static string getAttributionId()
	{
		return null;
	}

	public static void handlePushNotifications()
	{
	}

	public static void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string tranactionId, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject)
	{
	}

	public static void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject)
	{
	}

	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	public static void registerUninstall(byte[] deviceToken)
	{
	}

	public static void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval)
	{
	}

	public static void setCurrentDeviceLanguage(string language)
	{
	}

	public static void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject)
	{
	}

	public static void disableSKAdNetwork(bool isDisabled)
	{
	}

	public static void setCollectOaid(bool isCollect)
	{
	}

	public static void addPushNotificationDeepLinkPath(string[] paths)
	{
	}

	public static void setDisableAdvertisingIdentifiers(bool disable)
	{
	}

	public static void subscribeForDeepLink()
	{
	}

	public static void setPartnerData(string partnerId, Dictionary<string, string> partnerInfo)
	{
	}

	public static void setDisableNetworkData(bool disable)
	{
	}

	public static void disableIDFVCollection(bool isDisabled)
	{
	}

	public void inAppResponseReceived(string response)
	{
	}

	public void requestResponseReceived(string response)
	{
	}

	public void onDeepLinking(string response)
	{
	}

	private static AppsFlyerRequestEventArgs parseRequestCallback(string response)
	{
		return null;
	}

	public static Dictionary<string, object> CallbackStringToDictionary(string str)
	{
		return null;
	}

	public static void AFLog(string methodName, string str)
	{
	}
}
