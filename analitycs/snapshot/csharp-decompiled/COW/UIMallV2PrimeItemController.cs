using GCommon;
using proto;

namespace COW;

public class UIMallV2PrimeItemController : UIMallV2ItemBaseController
{
	private UIMallV2PrimeItemView m_View;

	protected PrimeStoreItemDesc m_PrimeStoreInfo;

	private uint m_CurrentDataItemID;

	private UIModelPrime m_ModelPrime;

	public uint CurrentDataItemID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	private void InitWidget()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	public void SetItemSelectedView(bool show)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshCDNShow()
	{
	}

	public void RefreshSoldOutTips()
	{
	}

	public void RefreshItemBG()
	{
	}

	public void RefreshOwnTitleState()
	{
	}

	public void RefreshIPTag()
	{
	}

	public void RefreshPrimeTag()
	{
	}

	public void RefreshUnFreeItemView(uint item_id, uint gems_price, uint discount_value)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
