using System.Collections.Generic;
using UnityEngine;

namespace AppsFlyerSDK;

public class AppsFlyerAndroid : IAppsFlyerAndroidBridge, IAppsFlyerNativeBridge
{
	private bool _003CisInit_003Ek__BackingField;

	private static AndroidJavaClass appsFlyerAndroid;

	public bool isInit
	{
		get
		{
			return _003CisInit_003Ek__BackingField;
		}
		set
		{
			_003CisInit_003Ek__BackingField = value;
		}
	}

	public void initSDK(string devkey, MonoBehaviour gameObject)
	{
	}

	public void startSDK(bool onRequestResponse, string CallBackObjectName)
	{
	}

	public void stopSDK(bool isSDKStopped)
	{
	}

	public string getSdkVersion()
	{
		return null;
	}

	public void updateServerUninstallToken(string token)
	{
	}

	public void setIsDebug(bool shouldEnable)
	{
	}

	public void setImeiData(string aImei)
	{
	}

	public void setAndroidIdData(string aAndroidId)
	{
	}

	public void setCustomerUserId(string id)
	{
	}

	public void waitForCustomerUserId(bool wait)
	{
	}

	public void setCustomerIdAndStartSDK(string id)
	{
	}

	public string getOutOfStore()
	{
		return null;
	}

	public void setOutOfStore(string sourceName)
	{
	}

	public void setAppInviteOneLinkID(string oneLinkId)
	{
	}

	public void setAdditionalData(Dictionary<string, string> customData)
	{
	}

	public void setDeepLinkTimeout(long deepLinkTimeout)
	{
	}

	public void setUserEmails(string[] userEmails)
	{
	}

	public void setPhoneNumber(string phoneNumber)
	{
	}

	public void setUserEmails(EmailCryptType cryptMethod, string[] emails)
	{
	}

	public void setCollectAndroidID(bool isCollect)
	{
	}

	public void setCollectIMEI(bool isCollect)
	{
	}

	public void setResolveDeepLinkURLs(string[] urls)
	{
	}

	public void setOneLinkCustomDomain(string[] domains)
	{
	}

	public void setIsUpdate(bool isUpdate)
	{
	}

	public void setCurrencyCode(string currencyCode)
	{
	}

	public void recordLocation(double latitude, double longitude)
	{
	}

	public void sendEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	public void sendEvent(string eventName, Dictionary<string, string> eventValues, bool shouldCallback, string callBackObjectName)
	{
	}

	public void anonymizeUser(bool isDisabled)
	{
	}

	public void enableTCFDataCollection(bool shouldCollectTcfData)
	{
	}

	public void enableFacebookDeferredApplinks(bool isEnabled)
	{
	}

	public void setConsentData(AppsFlyerConsent appsFlyerConsent)
	{
	}

	public void setConsumeAFDeepLinks(bool doConsume)
	{
	}

	public void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	public bool isPreInstalledApp()
	{
		return false;
	}

	public string getAttributionId()
	{
		return null;
	}

	public string getAppsFlyerId()
	{
		return null;
	}

	public void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject)
	{
	}

	public bool isSDKStopped()
	{
		return false;
	}

	public void setMinTimeBetweenSessions(int seconds)
	{
	}

	public void setHost(string hostPrefixName, string hostName)
	{
	}

	public string getHostName()
	{
		return null;
	}

	public string getHostPrefix()
	{
		return null;
	}

	public void setSharingFilterForAllPartners()
	{
	}

	public void setSharingFilter(string[] partners)
	{
	}

	public static void setSharingFilterForPartners(string[] partners)
	{
	}

	public void getConversionData(string objectName)
	{
	}

	public void initInAppPurchaseValidatorListener(MonoBehaviour gameObject)
	{
	}

	public void setCollectOaid(bool isCollect)
	{
	}

	public void attributeAndOpenStore(string promoted_app_id, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject)
	{
	}

	public void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters)
	{
	}

	public void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject)
	{
	}

	public void handlePushNotifications()
	{
	}

	public void addPushNotificationDeepLinkPath(string[] paths)
	{
	}

	public void subscribeForDeepLink(string objectName)
	{
	}

	public void setDisableAdvertisingIdentifiers(bool disable)
	{
	}

	public void setPartnerData(string partnerId, Dictionary<string, string> partnerInfo)
	{
	}

	public void setDisableNetworkData(bool disable)
	{
	}

	private static AndroidJavaObject getEmailType(EmailCryptType cryptType)
	{
		return null;
	}

	private static AndroidJavaObject convertDictionaryToJavaMap(Dictionary<string, string> dictionary)
	{
		return null;
	}
}
