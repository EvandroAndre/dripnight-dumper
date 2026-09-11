using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBasePopMenuController<T> : UIPopupWindowController where T : UICommonPopMenuItemController
{
	protected int CellWidth;

	protected int CellHeight;

	protected int CellWidthPadding;

	protected int m_NewCellWidth;

	private Vector2 m_showOffset;

	private Vector2 m_clickPos;

	private int m_offset;

	private int m_activatedMenuWidth;

	private int m_activatedMenuHeight;

	private float m_scale;

	private UIClickMask m_ClickMask;

	private UICommonPopMenuView m_View;

	protected List<T> m_ItemControllerList;

	protected string m_Region;

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void UpdateMenuData(List<CommonPopMenuData> list, bool isRightPopup = true)
	{
	}

	public void SetClanWarBG(string BGName = "FF_roundness_bg", string BGBorderName = "UI_icon_BG", uint BGColor = 1095985663u, uint BGBorderColor = uint.MaxValue)
	{
	}

	protected void CreateMenuData(List<CommonPopMenuData> list)
	{
	}

	private void ResizeMenuWidth()
	{
	}

	private void ComputePopPosition(int itemNum, bool isRightPop)
	{
	}

	private void OnClickeMenuItem(object[] data)
	{
	}

	public void SetDepth(int depth)
	{
	}
}
