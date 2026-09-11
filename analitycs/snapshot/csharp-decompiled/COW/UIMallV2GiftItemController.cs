using GCommon;
using proto;

namespace COW;

public class UIMallV2GiftItemController : UIMallV2ItemWidgetController
{
	private GiftItem m_GiftItem;

	private bool m_IsPlayPriceAnim;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void RefreshItemView()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override bool CanShowDiscountTag()
	{
		return false;
	}

	private void SetTag(uint tagValue)
	{
	}

	protected override void SetUniquedTitleState()
	{
	}

	private void SetPriceLabel(uint gemsPrice, uint coinsPrice, uint discountGemsPrice)
	{
	}

	protected override void ResetState()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void RefreshItemBGState()
	{
	}

	protected override void OnStartToggleMove()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void OnFinishToggleMove()
	{
	}

	private void _003CSetViewData_003Eb__12_0()
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanShowDiscountTag()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetUniquedTitleState()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
