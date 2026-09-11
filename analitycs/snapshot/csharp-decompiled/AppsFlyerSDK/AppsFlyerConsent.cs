namespace AppsFlyerSDK;

public class AppsFlyerConsent
{
	private bool _003CisUserSubjectToGDPR_003Ek__BackingField;

	private bool _003ChasConsentForDataUsage_003Ek__BackingField;

	private bool _003ChasConsentForAdsPersonalization_003Ek__BackingField;

	public bool isUserSubjectToGDPR
	{
		get
		{
			return _003CisUserSubjectToGDPR_003Ek__BackingField;
		}
		private set
		{
			_003CisUserSubjectToGDPR_003Ek__BackingField = value;
		}
	}

	public bool hasConsentForDataUsage
	{
		get
		{
			return _003ChasConsentForDataUsage_003Ek__BackingField;
		}
		private set
		{
			_003ChasConsentForDataUsage_003Ek__BackingField = value;
		}
	}

	public bool hasConsentForAdsPersonalization
	{
		get
		{
			return _003ChasConsentForAdsPersonalization_003Ek__BackingField;
		}
		private set
		{
			_003ChasConsentForAdsPersonalization_003Ek__BackingField = value;
		}
	}

	private AppsFlyerConsent(bool isGDPR, bool hasForDataUsage, bool hasForAdsPersonalization)
	{
	}

	public static AppsFlyerConsent ForGDPRUser(bool hasConsentForDataUsage, bool hasConsentForAdsPersonalization)
	{
		return null;
	}

	public static AppsFlyerConsent ForNonGDPRUser()
	{
		return null;
	}
}
