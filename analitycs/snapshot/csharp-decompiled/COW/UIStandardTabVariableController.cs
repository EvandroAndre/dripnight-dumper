using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabVariableController : UIBaseController, IEasyList
{
	private UIStandardTopTabView m_View;

	public Action<int> onItemClick;

	public bool IsCurSelectSuccess;

	private float m_ScrollViewWidth;

	private uint m_ItemFullScreenCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshEasyList<DataType>(List<DataType> dataList, bool framing = false, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true)
	{
	}

	public void OnItemClick(int index)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void UpdatePanelDepth(int newDepth)
	{
	}

	public void SelectTabItemByIndex(int index)
	{
	}

	public void HideCloseBtn()
	{
	}

	public UIEasyListItemController[] GetTabItems()
	{
		return null;
	}

	public void SetEasyListView(float itemWidth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
