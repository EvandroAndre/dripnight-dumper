using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class SDKManager : MonoBehaviour
{
	private static SDKManager _instance;

	private PlatformType m_PlatformType;

	private string openID;

	private string token;

	private static readonly Dictionary<int, string> _AppsFlyerAccountTypes;

	private const string PLAYER_PREF_KEY_PLATFORM_TYPE = "SDKPlatformType";

	public static SDKManager Instance => null;

	public PlatformType PlatformType
	{
		get
		{
			return PlatformType.Guest;
		}
		set
		{
		}
	}

	public string OpenID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Token
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool IsSupported(PlatformType platform)
	{
		return false;
	}

	public bool CanAuthorizePlatform(PlatformType platform)
	{
		return false;
	}

	public void InitSDK(PlatformType platform, bool force = false)
	{
	}

	public void SetupGarenaMSDKPlatformAuthStrategies()
	{
	}

	private void ApplyGMSDKSettings()
	{
	}

	public void InitGMSDK(bool force = false)
	{
	}

	public void PCForceInitSDK(PlatformType platform)
	{
	}

	public void InitBindSDK(PlatformType platform)
	{
	}

	public void LogoutSDK()
	{
	}

	public static string AppsFlyerAccountType(PlatformType platform)
	{
		return null;
	}

	public static SDKType GetSDKType(PlatformType platform)
	{
		return SDKType.None;
	}

	public SDKType GetCurrentSDKType()
	{
		return SDKType.None;
	}

	public PlatformType GetCachePlatformType()
	{
		return PlatformType.Guest;
	}

	public SDKType GetCacheSDKType()
	{
		return SDKType.None;
	}

	private void SavePlatformType(PlatformType platformType)
	{
	}

	private PlatformType LoadPlatformType()
	{
		return PlatformType.Guest;
	}

	public bool CurrentPlatformTypeHasPlatformFriend()
	{
		return false;
	}
}
