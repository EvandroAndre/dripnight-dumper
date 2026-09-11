using System.Collections.Generic;
using GCommon;

namespace COW;

public class MShopConfigDataManager : SingletonModule<MShopConfigDataManager>
{
	public enum MShopPlatformType
	{
		Default,
		IOS,
		Android,
		IOSMAX,
		AndroidMAX,
		AndroidThirdParty,
		HuaWei,
		Samsung
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int serverID;

		public uint productionID;

		internal bool _003CGetMshopUrl_003Eb__0(MShopUrlData x)
		{
			return false;
		}

		internal bool _003CGetMshopUrl_003Eb__1(MShopUrlData x)
		{
			return false;
		}
	}

	private const int DEFAULTSERVERID = 0;

	private List<MShopUrlData> m_Datas;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public string GetMshopUrl(bool isProduction, int serverID, MShopPlatformType platformType)
	{
		return null;
	}
}
