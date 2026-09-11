using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamInviteController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum InviteState
	{
		Normal,
		Inviting,
		Invited
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FriendAccountInfo> _003C_003E9__20_0;

		public static Comparison<FriendAccountInfo> _003C_003E9__21_1;

		internal int _003CShowSearchResultView_003Eb__20_0(FriendAccountInfo e, FriendAccountInfo o)
		{
			return 0;
		}

		internal int _003CUpdateFriendListView_003Eb__21_1(FriendAccountInfo e, FriendAccountInfo o)
		{
			return 0;
		}
	}

	private UICupMatchTeamInviteView m_View;

	private UIModelFriends m_ModelFriends;

	private Dictionary<ulong, InviteState> m_InviteStates;

	private UIModelCupMatch m_ModelCupMatch;

	private bool m_GettedFriendsData;

	private bool m_GettedInvitedListData;

	private int m_CupMatchKey;

	private bool m_HasSearch;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetCupMatchKey(int key)
	{
	}

	public InviteState GetInviteState(ulong id)
	{
		return InviteState.Normal;
	}

	public void SetInviteState(ulong id, InviteState state)
	{
	}

	private void Search()
	{
	}

	private void ResetSearch()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	public void ShowSearchResultView()
	{
	}

	private void UpdateFriendListView()
	{
	}

	private void RefreshEasyListView(List<FriendAccountInfo> data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool _003CUpdateFriendListView_003Eb__21_0(FriendAccountInfo e)
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
