using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDIceWallModuleTipPopOverController : UIPopupWindowController
{
	private UIHUDIceWallModuleTipPopOverView m_View;

	private float m_ValidRequestTime;

	private Rect m_BgWorldCornerRect;

	private Action m_HideAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Vector3 targetWorldPosition, OB46IceWallModule config)
	{
	}

	private void ResetPosition(Vector3 targetWorldPosition)
	{
	}

	private void SaveBgWorldCornerRect()
	{
	}

	public Rect GetBgWorldCornerRect()
	{
		return default(Rect);
	}

	public void AddVisibility(Action onClickMaskTriggered)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetIcon(OB46IceWallModule config)
	{
	}

	private void OnTableReposition()
	{
	}

	private void ShowIceWallMakerExp(Player localPlayer)
	{
	}

	private void OnIceWallMakerExpChange(object[] data)
	{
	}

	private void OnIceWallMakerLevelChange(object[] data)
	{
	}

	private void RefreshIceWallMakerExp()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
