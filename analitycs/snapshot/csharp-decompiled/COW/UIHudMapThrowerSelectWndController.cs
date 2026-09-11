using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapThrowerSelectWndController : UIBaseController
{
	private UIHudMapThrowerSelectWndView m_View;

	private VisualInstanceHolder m_UIFXHolder;

	private Action<Vector3, uint> m_ItemClick;

	private Vector3 m_RightPos;

	private Vector3 m_LeftPos;

	private Vector3 m_TopPos;

	private Vector3 m_BottomPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void SetDragBounds(UIWidget widget, float offset)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnItemBtnClick(uint itemIndex)
	{
	}

	public void RefreshView(Vector3 localPos)
	{
	}

	public void RefreshView(uint selectItemId)
	{
	}

	private void RefreshUIFX(bool show)
	{
	}

	public void SetItemClickAction(Action<Vector3, uint> itemClick)
	{
	}

	public bool NeedAdjustMapThrowerSelectWnd()
	{
		return false;
	}

	public Vector3[] GetWidgetCorners()
	{
		return null;
	}

	public void SetItemPosition(bool isLeftClipped, bool isRightClipped, bool isTopClipped, bool isBottomClipped)
	{
	}

	public void UpdateMainAlpha(float alpha)
	{
	}

	public bool GetIsVisible()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	private void _003COnUIInit_003Eb__8_1()
	{
	}

	private void _003COnUIInit_003Eb__8_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
