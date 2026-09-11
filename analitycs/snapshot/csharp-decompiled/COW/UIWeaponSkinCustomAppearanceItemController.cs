using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomAppearanceItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIWeaponSkinCustomAppearanceItemView m_View;

	private UIModelCollection m_ModelCollection;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelEvoPass m_ModelEvoPass;

	private WeaponSkinBaseInfo m_Data;

	private bool m_IsIconAbReady;

	private GameObject m_GODiscolorItem;

	private ResourceID m_LastResourseId;

	private bool m_MultiSelected;

	private uint m_SkinID;

	public UIButton GuideBtn => null;

	public UIWidget GuideWidget => null;

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

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void RefreshMultiSelectEquipState()
	{
	}

	private void RefreshEvoPassIcon()
	{
	}

	private void RefreshTime()
	{
	}

	private void SetWeaponShowIcon(UIUtils.SpriteScaleType scaleType)
	{
	}

	private void SetWeaponQualityBG(int Quality, UISprite QualityBG, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	private void RefreshWeaponName()
	{
	}

	public void DisableDiscoloration(UISprite spr)
	{
	}

	private void OnItemDownloadUpdate(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
