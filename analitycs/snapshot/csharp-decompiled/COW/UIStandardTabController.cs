using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabController : UIBaseController, IEasyList
{
	protected UIStandardTabView m_View;

	public Action<int> onItemClick;

	protected int count;

	private const int MAX_ITEM_NUM = 8;

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

	public void RefreshEasyListNoClear<DataType>(List<DataType> dataList, bool resetScroll = true)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected virtual UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	public void OnItemClick(int index)
	{
	}

	public void UpdatePanelDepth(int newDepth)
	{
	}

	public UIStandardTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
	{
		return null;
	}

	public void SelectTabItemByIndex(int index, bool needScroll = true)
	{
	}

	public UIEasyListItemController[] GetAllEasyListItemCtrls()
	{
		return null;
	}

	public void ChangeScollviewHieghtByItemHeight(float itemNum)
	{
	}

	public void ChangeTopArrowHeight(float offsetY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
