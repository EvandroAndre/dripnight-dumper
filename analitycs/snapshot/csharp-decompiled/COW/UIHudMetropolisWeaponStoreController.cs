using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisWeaponStoreController : UIBaseController, IEasyList
{
	public enum EActionType
	{
		Select,
		NotEnough,
		Unlock,
		Obtain
	}

	private UIHudMetropolisWeaponStoreView m_View;

	private bool m_SelectCollect;

	private int m_SelectWeaponType;

	private FMetroWeaponData m_SelectData;

	private EActionType m_ActionType;

	private EActionType m_LevelupType;

	private UIModelMetropolis m_ModelMetropolis;

	private List<UIHudMetropolisStoreTabItem> m_TabList;

	private UIHudMetropolisStoreTabItem m_CollectTab;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshClickTab()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnClickTab(bool collect, int weaponType)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickActionBtn()
	{
	}

	private void OnClickLevelBtn()
	{
	}

	private void OnCurCoinChanged(int data)
	{
	}

	private void OnUpdateStore(int itemType)
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnSelectWeapon(object[] data)
	{
	}

	private void OnCollectWeapon(object[] data)
	{
	}

	private void RefreshItemList()
	{
	}

	private void RefreshTabInfo()
	{
	}

	private void RefreshActionType()
	{
	}

	private void RefreshCollectTabVisiable()
	{
	}

	private int SortWeaponList(FMetroWeaponData weapon1, FMetroWeaponData weapon2)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
