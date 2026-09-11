using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudSceneEditPopupMenuController : UIPopupWindowController
{
	public class MenuItemData
	{
		public string label;

		public string icon;

		public Action action;
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public MenuItemData data;

		internal void _003CSetButtonData_003Eb__0()
		{
		}
	}

	private UIHudSceneEditPopupMenuView m_View;

	private UIRoot m_UIRoot;

	private List<MenuItemData> m_MenuItemDataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Vector3 worldPos, List<MenuItemData> itemDataList)
	{
	}

	private void SetButtonData(UIButton btn, MenuItemData data)
	{
	}

	private void SetRootPosition(Vector3 pos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
