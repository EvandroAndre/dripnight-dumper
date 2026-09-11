using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIGachaUnlimitedChestInfoCDNController : UIBaseController
{
	private const float INFO_CDN_INTERVAL = 5f;

	private UIGachaUnlimitedChestInfoCDNView m_View;

	private List<UINetworkTexture> m_InfoCDNList;

	private int m_ShowingInfoCDNIndex;

	private uint m_InfoCDNCycleDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void StopDownload()
	{
	}

	public bool TryShowInfoCDN(List<AdvertDesc> adList)
	{
		return false;
	}

	private void InfoCDNCycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
