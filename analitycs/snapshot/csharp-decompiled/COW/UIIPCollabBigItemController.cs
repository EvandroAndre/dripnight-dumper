using GCommon;

namespace COW;

public class UIIPCollabBigItemController : UIEasyListItemController
{
	private UIIPCollabBigItemView m_View;

	private UIModelInventory m_ModelInventory;

	private UIStandardItemMAXBController ctrl;

	private uint m_ItemID;

	private BaseItemInfo m_BaseItemInfo;

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

	public override void OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
