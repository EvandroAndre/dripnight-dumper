using GCommon;

namespace COW;

public class UIWeaponProficiencyPickItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIWeaponProficiencyPickItemView m_View;

	private uint m_WeaponId;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private int m_SpriteWeaponWidth;

	private int m_SpriteWeaponHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
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

	private void RefreshView()
	{
	}

	private void OnChangeToV2Bar(object[] data)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshRedDot()
	{
	}

	private void RefreshPin()
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
