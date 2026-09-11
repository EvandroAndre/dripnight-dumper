using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class UITransferLeaderMenuController : UIPopupWindowController, IEasyList
{
	private UITransferLeaderMenuView m_View;

	private UIModelGroup m_ModelGroup;

	private const int ITEMHEIGHT = 58;

	private uint[] m_SquadGroupMemberOrderArray;

	private uint[] m_PenTaGroupMemberOrderArray;

	private const float TRANSFERNODEOFFSET = 5f;

	private UISprite m_TransferBtnSprite;

	private Vector3 m_TransferBtnPos;

	private Action<ulong> BtnClickAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void readyToTransfer(object[] data)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void RefreshViewData(object[] data)
	{
	}

	public void SetTitle(string title)
	{
	}

	public void SetBtnClickAction(Action<ulong> action)
	{
	}

	public void AdjustOrder(GroupInfo groupInfo, List<GroupMemberInfo> groupMemberList)
	{
	}

	public void AdjustHeight(int memberCnt)
	{
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public void RefreshPosition()
	{
	}

	private void OnMaskClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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
