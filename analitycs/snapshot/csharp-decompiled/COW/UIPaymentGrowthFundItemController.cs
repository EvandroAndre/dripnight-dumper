using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentGrowthFundItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIPaymentGrowthFundItemView m_View;

	private PayLevelRewardDesc m_Data;

	private UIModelPayment m_Payment;

	private PlayLevelInfo m_Info;

	private Color m_NormalColor;

	private Color m_DisableColor;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	private void UpdateContents()
	{
	}

	private void OnClaimClick()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
