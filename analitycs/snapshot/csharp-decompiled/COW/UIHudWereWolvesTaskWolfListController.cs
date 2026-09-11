using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesTaskWolfListController : UIBaseController, IEasyList
{
	private UIHudWereWolvesTaskWolfListView m_View;

	private List<MICOLHIEIOC> m_TaskList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ShowList(bool value)
	{
	}

	private void OnExpandClick()
	{
	}

	private void OnShrinkClick()
	{
	}

	private void OnRefreshTaskList(object[] data)
	{
	}

	private int Cmp(MICOLHIEIOC infoA, MICOLHIEIOC infoB)
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnShowTaskList(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
