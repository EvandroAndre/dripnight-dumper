using GCommon;

namespace COW;

public class UIPayItemController : UIBaseController
{
	private UIPayItemView m_View;

	private PayItemData m_Data;

	private UIModelPayment m_ModelPayment;

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

	public void SetData(PayItemData data, bool hasUsedFirstPayBonus)
	{
	}

	private void SetVirtualCurrencyAmount(PayItemData localData, PayItemData remoteData, bool hasFirstPayBonus)
	{
	}

	private void SetCostString(PayItemData localData, PayItemData remoteData)
	{
	}

	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	private void OnButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
