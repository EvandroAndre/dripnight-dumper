using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendBatchRemoveFriendController : UIPopupWindowController, IEasyList
{
	private UIModelFriends m_ModelFriends;

	private UIFriendBatchRemoveFriendView m_View;

	private HashSet<ulong> m_SelectedSet;

	private List<FriendAccountInfo> m_UnActiveFriendsList;

	public bool IsAllSelected => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshSelectView()
	{
	}

	private void OnDeleteBtnClick()
	{
	}

	private void OnSecondConfirmOkCilck()
	{
	}

	private void OnAllSelectBtnClick()
	{
	}

	public void OnItemBtnClick(ulong account_id)
	{
	}

	public bool IsSelectedByAccountId(ulong account_id)
	{
		return false;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private bool _003COnSecondConfirmOkCilck_003Eb__11_0(FriendAccountInfo item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
