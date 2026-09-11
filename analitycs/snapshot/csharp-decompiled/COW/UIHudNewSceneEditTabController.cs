using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudNewSceneEditTabController : UIBaseController
{
	private const uint COLLABORATE_OPTION_ID = 9999u;

	private UIHudNewSceneEditTabView m_View;

	private HNDHJGJILHC m_SceneEditGame;

	private List<UIHudNewScenenEditSubTabController> m_SubTabControllers;

	private uint m_OptionID;

	private int m_SelectedSubTab;

	private int m_RevertSelectedSubTab;

	private bool m_IsFold;

	private bool m_IsSearchTab;

	private bool previousState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public void RefreshData(WorkShopResourceTypeData tabData)
	{
	}

	public void RefreshData(WorkShopResourceTypeData tabData, HashSet<uint> subTabs)
	{
	}

	private void RefreshTabContent(WorkShopResourceTypeData tabData)
	{
	}

	private void RefreshSubContent(WorkShopResourceTypeData tabData, List<WorkShopResourceTypeData> subTabTypeDataList)
	{
	}

	private void OnSelectSubTab(UIToggleButton button)
	{
	}

	public void SelectSubTab(int index)
	{
	}

	public void SelectSubTab()
	{
	}

	public void SwitchFoldState()
	{
	}

	public void SwitchFoldState(bool state)
	{
	}

	public void RefreshFoldState()
	{
	}

	public void SaveCurrent()
	{
	}

	public void RevertSelect()
	{
	}

	public void RefreshTabNew()
	{
	}

	public UIHudNewScenenEditSubTabController GetGuideCtrl()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
