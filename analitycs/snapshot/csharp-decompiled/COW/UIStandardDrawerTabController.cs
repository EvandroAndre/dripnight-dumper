using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardDrawerTabController : UIBaseController
{
	protected UIStandardDrawerTabView m_View;

	protected List<UIStandardTabItemController> mainTabList;

	protected int maxMainTabItemIndex;

	protected int curMainTabItemIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void CreateTabByData(StandardTabItemViewData mainTabData, List<StandardSubTabItemViewData> subTabDataist, bool needupdateanim = false)
	{
	}

	public void SetSnapToTop()
	{
	}

	protected virtual UIStandardTabItemController CreateTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	public void SelectSubTabByIndex(int mainTabIndex, int subTabIndex, bool isFocusMainTab = false)
	{
	}

	public void SelectDefaultSubTab(int mainTabIndex)
	{
	}

	private void UpdateScrollViewState()
	{
	}

	public void ReposTab()
	{
	}

	public UIStandardTabItemController GetTabItemControllerByIndex(int index)
	{
		return null;
	}

	public uint GetScrollviewPanelDepth()
	{
		return 0u;
	}

	public void SelectMainTabByIndex(int index, bool isDrawerOpen = false, bool isNeedUpdateSubItemState = true, bool isFocusMainTab = false)
	{
	}

	public void SelectMainTabByExpara(object Expara, bool goSubTab = false)
	{
	}

	public int GetCurTabItemIndex()
	{
		return 0;
	}

	public bool IsMainTabNoSubTabItem(int mainTabIndex)
	{
		return false;
	}

	public void SetGuideContainerPos(Vector3 pos)
	{
	}

	public UIWidget GetGuideWidght()
	{
		return null;
	}

	public void SetStandardTabItemVisible(int index, bool visible)
	{
	}

	public void RefreshArrowObject()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
