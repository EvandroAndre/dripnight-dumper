using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudTechBuildPointSelectionPopupWndController : UIPopupWindowController
{
	private uint m_BrowsingTechBuildPointObjectID;

	private Action m_ClickMaskTriggerHandler;

	private UIClickMask m_ClickMask;

	private UIHudTechBuildPointSelectionPopupWndView m_View;

	private readonly List<UIHudTechBuildPointSelectionItemController> m_SelectionItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RegisterEvents()
	{
	}

	private void OnPlayerFundsChanged(int data)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnClickMaskTriggered()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void SetupClickMask()
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void RequestStopUsingWithCurrentBrowsing()
	{
	}

	private void PopulateSelections(UIHudTechBuildPointSelectionItemViewData[] viewDataArr)
	{
	}

	private void RefreshLayout()
	{
	}

	public void SetViewData(uint pointObjectID, UIHudTechBuildPointSelectionItemViewData[] viewDataArr)
	{
	}

	public uint GetCurrentBrowsingTechBuildPoint()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
