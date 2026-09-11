using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipTeamInviteController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
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

		public static Comparison<FriendAccountInfo> _003C_003E9__16_1;

		internal int _003CUpdateFriendListView_003Eb__16_1(FriendAccountInfo e, FriendAccountInfo o)
		{
			return 0;
		}
	}

	private UIChampionshipTeamInviteView m_View;

	private UIModelFriends m_ModelFriends;

	private Dictionary<ulong, InviteState> m_InviteStates;

	private UIModelChampionship m_ModelChampionship;

	private bool m_GettedFriendsData;

	private bool m_GettedInvitedListData;

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

	private bool _003CUpdateFriendListView_003Eb__16_0(FriendAccountInfo e)
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
