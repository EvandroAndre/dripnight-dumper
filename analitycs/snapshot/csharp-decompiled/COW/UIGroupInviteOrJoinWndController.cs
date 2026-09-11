using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGroupInviteOrJoinWndController : UIPopupWindowController
{
	private UIGroupInviteOrJoinWndView m_View;

	private Action m_InviteBtnClick;

	private Action m_JoinInBtnClick;

	private const uint SPRITE_OFFSET = 5u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void CloseByRefreshList()
	{
	}

	public void SetViewData(Action invite, Action join, Vector3 pos, float offsetX = 0f)
	{
	}

	private void OnMaskBtnClick()
	{
	}

	private void OnInviteBtnClick()
	{
	}

	private void OnJoinInBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
