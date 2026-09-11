using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTopTabController : UIBaseController, IEasyList
{
	protected UIStandardTopTabView m_View;

	public Action<int> onItemClick;

	protected int count;

	public bool IsCurSelectSuccess;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshEasyList<DataType>(List<DataType> dataList, bool framing = false, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true, float itemWidth = 0f, float itemHeight = 0f)
	{
	}

	public void OnItemClick(int index)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public UIButton GetBtnClose()
	{
		return null;
	}

	public void UpdatePanelDepth(int newDepth)
	{
	}

	public int GetPanelDepth()
	{
		return 0;
	}

	public UIStandardTopTabItemController GetTabItemControllerByIndex(int index)
	{
		return null;
	}

	public void SelectTabItemByIndex(int index)
	{
	}

	public float GetEasyListItemWidth()
	{
		return 0f;
	}

	public void SetScrollViewHeight(float height)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
