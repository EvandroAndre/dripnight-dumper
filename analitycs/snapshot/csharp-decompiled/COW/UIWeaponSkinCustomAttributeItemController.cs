using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomAttributeItemController : UIBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIWeaponSkinCustomAttributeItemView m_View;

	private UIModelCollection m_ModelCollection;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelEvoPass m_ModelEvoPass;

	public WeaponSkinBaseInfo Data;

	private bool m_IsIconAbReady;

	private ResourceID m_LastResourseId;

	private List<UIFrontEndPreviewWeaponPropertyItemController> m_PvpPropertyItems;

	private List<UIFrontEndPreviewWeaponPVePropertyItemController> m_PvePropertyItems;

	private List<WeaponScoreName> m_DetailInfoList;

	private bool m_hasPveProperty;

	private bool m_hasPvpProperty;

	private UISprite m_WeaponImg;

	private attributeType m_CurType;

	private uint m_TipDelayCall;

	public UIWidget GuideWidget => null;

	public UIButton GuideBtn => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetViewData(object data, int data_index)
	{
	}

	private void RefreshPveScoreGrid()
	{
	}

	private void InitPveItems()
	{
	}

	private void RefreshPvpScoreGrid()
	{
	}

	private void InitPvpItems()
	{
	}

	private void RefreshEvoPassIcon()
	{
	}

	private void RefreshTime()
	{
	}

	public void RefreshHLStateSprite()
	{
	}

	private void SetWeaponShowIcon(UIUtils.SpriteScaleType scaleType)
	{
	}

	private void SetWeaponQualityBG(int Quality, UISprite QualityBG, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	public void ItemBtnClick()
	{
	}

	private void OnSwitchClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
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

	private void _003COnSwitchClick_003Eb__32_0()
	{
	}

	private void _003COnSwitchClick_003Eb__32_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
