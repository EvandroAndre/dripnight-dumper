using GCommon;

namespace COW;

public class UIWeaponSkinMenuFirstItemController : UIEasyListItemController
{
	private UIWeaponSkinMenuFirstItemView m_View;

	private object m_Data;

	private bool m_NeedSelectNextTabItem;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

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

	private void OnRefreshRed(object[] data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshRedTips(bool flag)
	{
	}

	public void NeedSelectNextTabItem(bool need)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
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
