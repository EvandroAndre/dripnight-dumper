using GCommon;

namespace COW;

public class UIWeaponSkinMenuSecondItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIWeaponSkinMenuSecondItemView m_View;

	private object m_Data;

	private UIModelCollection m_ModelCollection;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelWeaponSkinCustom m_ModelWeaponSkinCustom;

	private ResourceID m_LastSetSprite;

	private bool m_IconIsReady;

	private bool m_NeedSelectNextTabItem;

	private int m_SpriteWidth;

	private int m_SpriteHeight;

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

	private void RefreshRedTips(bool flag)
	{
	}

	private void OnRefreshRed(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRefreshIcon(object[] data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshSecondGridIcon(uint weaponId)
	{
	}

	private void SetSpecialSpriteSize(UISprite sprite, uint id)
	{
	}

	private void RefreshMultiSelectSpriteWithSpecialWeapon(UISprite spriteUI, ResourceID default_icon, UIUtils.SpriteScaleType scaleType, WeaponSkinBaseInfo weaponSkinInfo)
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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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
