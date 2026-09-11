using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchTeamJoinController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum ApplyState
	{
		Normal,
		Applying,
		ApplySuccess,
		CantApplyTeamFull
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<FriendAccountInfo, ulong> _003C_003E9__21_0;

		internal ulong _003COnDataChanged_003Eb__21_0(FriendAccountInfo f)
		{
			return 0uL;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public FriendAccountInfo friendAccountInfo;

		internal bool _003CRefreshFriendCupInfo_003Eb__0(FriendAccountInfoWithCupTeamInfo f)
		{
			return false;
		}

		internal bool _003CRefreshFriendCupInfo_003Eb__1(CSAccountCupInfoRes info)
		{
			return false;
		}
	}

	private UICupMatchTeamJoinView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelFriends m_ModelFriends;

	private Dictionary<ulong, ApplyState> m_ApplyStates;

	private int m_CupMatchKey;

	private bool m_HasSearch;

	private List<FriendAccountInfo> m_AllOnlineFriend;

	private List<FriendAccountInfoWithCupTeamInfo> m_FriendsAccountInfoWitchCupTeamInfoList;

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

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void SetCupMatchType(int cupMatchKey)
	{
	}

	private void InitApplyState()
	{
	}

	public ApplyState GetApplyState(ulong id)
	{
		return ApplyState.Normal;
	}

	public void SetApplyState(ulong id, ApplyState state)
	{
	}

	private void Search()
	{
	}

	private void ResetSearch()
	{
	}

	private int FriendSort(FriendAccountInfoWithCupTeamInfo a, FriendAccountInfoWithCupTeamInfo b)
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshFriendCupInfo(bool isSearch)
	{
	}

	public void RefreshEasyListView(List<FriendAccountInfoWithCupTeamInfo> data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void SetRefreshBtnState()
	{
	}

	private void _003CSetRefreshBtnState_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
