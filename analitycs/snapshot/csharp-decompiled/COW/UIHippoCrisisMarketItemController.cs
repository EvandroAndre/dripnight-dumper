using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisMarketItemController : UIEasyListItemController
{
	private UIHippoCrisisMarketItemView m_View;

	private HippoCrisisStoreItemData m_StoreData;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private HENEHAGJCLI m_ItemData;

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

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void SetMarketViewData(HippoCrisisStoreItemData data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
