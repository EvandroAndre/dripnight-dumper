using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunCarouselController : UIBaseController
{
	private UIEvoGunCarouselView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private List<UIEvoGunCarouselItemController> m_ListItemCtrls;

	private List<UIEvoGunCarouselDotController> m_ListDotCtrls;

	private List<UICarouselTickData> m_TickDatas;

	private int m_LastSelectedIndex;

	private SkinOwnAndOpenInfo m_Data;

	private Action<WeaponSkinUpgradeInfoData> m_AnalyseCarouselFeatureInfoCallBack;

	private UIEvoGunNavigationComponentController m_NaviController;

	private List<WeaponSkinUpgradeInfoData> m_ListCarouselData;

	private bool m_TickPauseByActive;

	private const string LABELPROGRESSTXT = "{0}/{1}";

	private EvoGunCarouselTickDataOnStartLogicPool m_TickOnStartLogicPool;

	private bool m_IsShowPrivilegeList;

	private UIEvoGunNavigationPrivilegeController m_PrivilegeListController;

	public UIEvoGunNavigationComponentController NaviPageController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void OnShowPrivilegeListBtnClick()
	{
	}

	private void RefreshPrivilegeListState(bool state)
	{
	}

	private void RefreshPrivilegeList()
	{
	}

	private void InitCarouselItem()
	{
	}

	private void AnalyseCarouselFeatureInfoCallBackFunc(WeaponSkinUpgradeInfoData carouselItem)
	{
	}

	private void RefreshCarouselView()
	{
	}

	private void OnScrollCenter(GameObject centerGo)
	{
	}

	private void PauseCarouselTick()
	{
	}

	private void OnScrollFinish()
	{
	}

	private void DebugText(string log)
	{
	}

	public void SetViewData(SkinOwnAndOpenInfo info)
	{
	}

	private void _003COnUIInit_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
