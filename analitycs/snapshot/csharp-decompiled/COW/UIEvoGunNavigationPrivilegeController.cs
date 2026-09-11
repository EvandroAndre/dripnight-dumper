using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIEvoGunNavigationPrivilegeController : UIBaseController
{
	private List<WeaponSkinUpgradeInfoData> m_ListPrivilegeData;

	private SkinOwnAndOpenInfo m_WeaponSkinOpenInfoData;

	private Action<WeaponSkinUpgradeInfoData> m_AnalysePrivilegeInfoCallBack;

	private UIModelWeaponSkinUpgrader m_modelWeaponSkinUpgrader;

	private List<UIEvoGunNavigationPrivilegeItemController> m_ListPrivilegeItemCtrls;

	private List<UIEvoGunNavigationPrivilegeSubItemController> m_ListPrivilegeSubItemCtrls;

	private UIEvoGunNavigationPrivilegeView m_View;

	private UIEvoGunNavigationComponentController m_NaviController;

	private string ItemNameFormat;

	private int m_LastSelectIndex;

	private UIScopeSelectController m_UIScopeSelectCtrl;

	private uint m_SelectedScopeId;

	public int LastSelectIndex
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public UIEvoGunNavigationComponentController NaviPageController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPrivilegeData(SkinOwnAndOpenInfo infoData)
	{
	}

	private void InitPrivilegeItem()
	{
	}

	private void AnalysePrivilegeInfoCallBackFunc(WeaponSkinUpgradeInfoData privilegeItem)
	{
	}

	private void RefreshPrivilegeView()
	{
	}

	private void RefreshTitle()
	{
	}

	public void SelectItemByIndex(int index)
	{
	}

	private void ClickItemByItem(int index)
	{
	}

	private void ResetItems()
	{
	}

	private void RefreshScopeSelectorByCurrentItem()
	{
	}

	private void ShowScopeSelector(uint weaponSkinId)
	{
	}

	private void HideScopeSelector()
	{
	}

	private void OnScopeTypeSelected(uint scopeAttachmentId)
	{
	}

	private static List<uint> BuildScopeListForSightReskin(uint weaponSkinId)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
