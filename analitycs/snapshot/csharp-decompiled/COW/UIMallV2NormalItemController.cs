using GCommon;
using proto;

namespace COW;

public class UIMallV2NormalItemController : UIMallV2ItemWidgetController
{
	private StoreDesc m_StoreItem;

	private bool m_NeedPlay;

	private bool m_IsPlayPriceAnim;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void RefreshItemView()
	{
	}

	protected virtual void SetPriceLabel()
	{
	}

	protected override bool CanShowDiscountTag()
	{
		return false;
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void ResetState()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnStartToggleMove()
	{
	}

	protected override void OnFinishToggleMove()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003CSetViewData_003Eb__11_0()
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanShowDiscountTag()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
