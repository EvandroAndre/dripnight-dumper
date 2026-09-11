using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallMultiGoodsContainerController : UIBaseController
{
	private UIMallMultiGoodsContainerView m_View;

	private List<StoreDesc> m_SotreList;

	private List<UIMallPurchaseItemController> m_ItemControllers;

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

	private void OnItemSelected(object[] data)
	{
	}

	public void SetViewData(List<StoreDesc> storeList)
	{
	}

	private void SelectItem(int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
