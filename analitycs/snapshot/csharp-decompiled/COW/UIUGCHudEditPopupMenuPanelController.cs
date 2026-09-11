using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudEditPopupMenuPanelController : UIPopupWindowController
{
	public class MenuItemData
	{
		public string text;

		public Action callback;

		public MenuItemData(string text, Action callback)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public MenuItemData itemData;

		public UIUGCHudEditPopupMenuPanelController _003C_003E4__this;

		internal void _003CInitMenuItem_003Eb__0()
		{
		}
	}

	private const int DEFAULT_WIDTH = 180;

	private UIUGCHudEditPopupMenuPanelView m_View;

	private UIRoot m_UIRoot;

	private int m_ItemHeight;

	private Vector2 m_Padding;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetMenus(Vector3 position, MenuItemData[] itemDatas)
	{
	}

	public void SetWidth(int width)
	{
	}

	private void InitMenuItems(MenuItemData[] itemDatas)
	{
	}

	private void InitMenuItem(GameObject item, MenuItemData itemData)
	{
	}

	private void FixPosition(Vector3 position)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
