using GCommon;
using proto;

namespace COW;

public class UIMallPurchaseItemController : UIBaseController
{
	private UIMallPurchaseItemView m_View;

	private StoreDesc m_StoreDesc;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(StoreDesc data, int data_index)
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void HightLightItem(bool hightlight)
	{
	}

	private void RefreshPatchNoteItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
