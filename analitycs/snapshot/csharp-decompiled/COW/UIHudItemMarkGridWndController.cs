using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudItemMarkGridWndController : UIBaseController
{
	private UIHudMarkItemShowGridWndView m_View;

	private List<UIHudItemMarkShowItemController> m_ItemControllers;

	private LevelContainerBase m_CurrentContainer;

	private FHMPPFHPBND m_CurrentLContainer;

	private int m_CurrentLen;

	private Vector3 m_CurrentMarkPosition;

	private int m_initItemCount;

	private float m_NextAutoHideTime;

	private string BUTTON_MARK_NAME;

	private string UIROOT_NAME;

	private string BTNITEM_NAME;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshShowList()
	{
	}

	private void RefreshShowList(GEvent param)
	{
	}

	private void RefreshShowLList(GEvent param)
	{
	}

	private void OnEnterLPickupArea(GEvent param)
	{
	}

	private void OnEnterPickupArea(GEvent param)
	{
	}

	private void OnLocalPlayerBeHit(object[] param)
	{
	}

	private void FixedUpdate()
	{
	}

	private void ExitChooseWndState()
	{
	}

	private void OnExitPickupArea(object[] param)
	{
	}

	private void OnChooseOneItemMark(object[] param)
	{
	}

	private void OnClickEndShow(List<GameObject> hits)
	{
	}

	private void OnDragScreenEvent(GameObject obj, Vector2 dragStartPos)
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void RefreshPickUpDataList(LevelContainerBase container)
	{
	}

	public void RefreshPickUpDataList(FHMPPFHPBND container)
	{
	}

	private void ClearMarkItemControllers()
	{
	}

	private void ShowMarkItemUI(uint dataID, uint Count, Vector3 Position, bool isLocalOnlyVisible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
