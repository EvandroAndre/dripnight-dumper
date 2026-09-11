using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIRoomPopMenuController : UIPopupWindowController
{
	private RoomPlayerInfo m_info;

	private int CellWidth;

	private int CellHeight;

	private int CellWidthPadding;

	private int m_NewCellWidth;

	private Vector2 m_showOffset;

	private Vector2 m_clickPos;

	private int m_offset;

	private int m_activatedMenuWidth;

	private int m_activatedMenuHeight;

	private float m_scale;

	private UIRoomPopMenuView m_View;

	private List<UICommonPopMenuItemController> m_ItemControllerList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

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

	private void OnAddFriend()
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnClickeMenuItem(object[] data)
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
