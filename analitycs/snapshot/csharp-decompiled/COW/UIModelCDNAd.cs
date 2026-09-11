using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelCDNAd : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public uint adId;

		internal bool _003CGetAdDescByIdAndType_003Eb__0(AdvertDesc x)
		{
			return false;
		}
	}

	private Dictionary<uint, List<AdvertDesc>> m_AdDic;

	private Dictionary<uint, Dictionary<uint, List<AdvertDesc>>> m_AdSubTypeCacheDic;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ProcessCDNAd(CSGetAdvertRes adRes)
	{
	}

	public List<AdvertDesc> GetAdList(AdType type)
	{
		return null;
	}

	public List<AdvertDesc> GetAdListUintType(uint type)
	{
		return null;
	}

	public string GetBGUrlByType(AdType type)
	{
		return null;
	}

	public string GetBGUrlByType(AdType type, uint subType)
	{
		return null;
	}

	public string GetBGUrlByUintType(uint type)
	{
		return null;
	}

	public AdvertDesc GetAdDescByIdAndType(uint adId, AdType type)
	{
		return null;
	}

	public List<AdvertDesc> GetAdListBySubType(AdType type, uint subType)
	{
		return null;
	}

	private void BuildSubTypeCacheForAdType(uint typeKey)
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
