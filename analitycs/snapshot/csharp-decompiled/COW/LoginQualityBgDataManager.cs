using System.Collections.Generic;
using GCommon;

namespace COW;

public class LoginQualityBgDataManager : SingletonModule<LoginQualityBgDataManager>
{
	private CSVAsyncDataMap<uint, LoginBgData> m_LoginBgAndMusicDataDict;

	public ResourceID ConfigDefaultRes;

	public ResourceID ConfigDefaultEqualTimeRes;

	public const string DefultRegion = "default";

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ResourceID GetNowShowResID(string countryCode, LoginShowResIDType type = LoginShowResIDType.LoginQualityBg)
	{
		return default(ResourceID);
	}

	public Dictionary<string, List<string>> GetLoginBgGroupedByRegion(LoginShowResIDType type = LoginShowResIDType.LoginQualityBg)
	{
		return null;
	}

	public ResourceID GetLoginBgResIDByName(string bgName, LoginShowResIDType type = LoginShowResIDType.LoginQualityBg)
	{
		return default(ResourceID);
	}

	private string GetBgDisplayName(LoginBgData data)
	{
		return null;
	}

	private string SimplifyResourceName(string fullName)
	{
		return null;
	}

	private string GetResourceDisplayName(ResourceID resId)
	{
		return null;
	}
}
