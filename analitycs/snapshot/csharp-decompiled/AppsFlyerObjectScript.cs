using AppsFlyerSDK;
using UnityEngine;

public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData
{
	private static AppsFlyerObjectScript _003CInstance_003Ek__BackingField;

	public static AppsFlyerObjectScript Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	public void onConversionDataSuccess(string conversionData)
	{
	}

	public void onConversionDataFail(string error)
	{
	}

	public void onAppOpenAttribution(string attributionData)
	{
	}

	public void onAppOpenAttributionFailure(string error)
	{
	}
}
