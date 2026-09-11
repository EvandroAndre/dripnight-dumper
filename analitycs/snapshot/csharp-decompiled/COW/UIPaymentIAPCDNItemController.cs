using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIPaymentIAPCDNItemController : UIBaseController
{
	private AdvertDesc m_Desc;

	private UIPaymentIAPCDNItemView m_View;

	public int AdIndex;

	private Dictionary<uint, uint> m_DictCDNTypeToGopos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(AdvertDesc info)
	{
	}

	public void SetDefaultTexture(ResourceID resourceId)
	{
	}

	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url, uint endTime)
	{
	}

	private void OnCDNBtnClick()
	{
	}

	private void RefreshVFX()
	{
	}

	private void RefreshCDNSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
