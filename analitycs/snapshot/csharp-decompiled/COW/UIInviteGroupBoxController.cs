using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIInviteGroupBoxController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public FriendAccountInfo player;

		internal bool _003CGetRecommandPlayerNotInGroup_003Eb__0(ulong id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UIInviteGroupBoxController _003C_003E4__this;

		public string name;

		internal void _003ConSearchBtnClick_003Eb__0()
		{
		}

		internal bool _003ConSearchBtnClick_003Eb__1(FriendAccountInfo a)
		{
			return false;
		}

		internal bool _003ConSearchBtnClick_003Eb__2(ClanMember a)
		{
			return false;
		}

		internal bool _003ConSearchBtnClick_003Eb__3(TeamMemberWithAccountInfo a)
		{
			return false;
		}

		internal bool _003ConSearchBtnClick_003Eb__4(UIModelCupMatch.AccountInfoBasicWithCupInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public ulong uid;

		internal bool _003CAddRecommandPlayer_003Eb__0(ulong item)
		{
			return false;
		}

		internal bool _003CAddRecommandPlayer_003Eb__1(ulong item)
		{
			return false;
		}
	}

	protected UIInviteGroupBoxView m_View;

	private uint m_DelayCall;

	private string INVITE_FILTER;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelFriends m_ModelFriends;

	private UIModelMatch m_ModelMatch;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private GroupInviteMemberType m_InviteType;

	private List<FriendAccountInfo> m_CachedFriends;

	private List<ClanMember> m_CachedOnlineClanMembers;

	private List<FriendAccountInfo> m_RecommandPlayer;

	private List<ulong> m_RecommandPlayerIdList;

	private bool m_HastUpdateRecent;

	private ulong m_LastRefreshTime;

	private ulong m_LastChangePublicTime;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private List<ulong> m_CurrrentMemebers;

	private UICommonCodeInputWindowController m_CodeInputWindow;

	private UIGroupInviteItemController m_FloatingWindow;

	private UIGroupInviteItemController.GroupInviteUI m_InviteUI;

	private Action m_OnClose;

	private bool m_ReuqestedChampionshipTeamMembersPresence;

	private bool m_RequestedCupTeamMembersPresence;

	private bool m_HasPublicRoot;

	private bool m_HasLastUseFloatingWindow;

	private UIModelGroup __ModelGroup;

	private UIModelGroup m_ModelGroup => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(Action onOpen = null, Action onClose = null)
	{
	}

	public void SetData(Vector3 worldPos, Vector3 scale, Action onOpen = null, Action onClose = null)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnClickAddFriend()
	{
	}

	public void OnClickAddClan()
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnGroupUIEnter(object[] data)
	{
	}

	private void SetInviteType()
	{
	}

	private void UpdateRefreshState(bool inCD = false)
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void RefreshFriendsList()
	{
	}

	private void PartialUpdateCachedClanMembersInfo()
	{
	}

	private void PartialUpdateCachedFriendsInfo()
	{
	}

	private void OnFriendToggleBtnClick()
	{
	}

	private void OnClanToggleBtnClick()
	{
	}

	private void OnRecentToggleClick()
	{
	}

	private void SetRecentUIData()
	{
	}

	private void SetRecentRecommandUIData()
	{
	}

	private List<FriendAccountInfo> GetRecommandPlayerNotInGroup()
	{
		return null;
	}

	private void SetClanUIData()
	{
	}

	private void SetFriendUIData()
	{
	}

	private void SetTeamUIData()
	{
	}

	private void SetCupUIData()
	{
	}

	private void RefreshInviteUI()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void onSearchBtnClick()
	{
	}

	private void RefreshScrollView()
	{
	}

	private void OnClickMask(object[] args)
	{
	}

	private void OnTweenFinish()
	{
	}

	private void OnMatchmakingShow()
	{
	}

	private void OnSelectGameMode(object[] args)
	{
	}

	private void ChangePublicState(object[] args)
	{
	}

	public void OnClickClose()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RequestRecommandPlayerInfo()
	{
	}

	private void AddRecommandReason(ulong uid, ERecommandReason reason)
	{
	}

	private void AddRecommandPlayer(ulong uid)
	{
	}

	private void UpdateRecommandPlayer()
	{
	}

	private void UpdateFloatingWindow()
	{
	}

	private void UpdateFloatingWindowRecommandPlayer()
	{
	}

	private void UpdateView()
	{
	}

	private void ResetClipPos()
	{
	}

	private void ResetSearchInput()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void UpdateGroupInfo()
	{
	}

	private void SetGroupData()
	{
	}

	private void OnClickChangePublic()
	{
	}

	private void OnClickCommunity()
	{
	}

	private void OnQuickEnter()
	{
	}

	private void OnGroupCodeEnter(object data)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private int CompareFriendListInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	public Vector3 GetBriefBoxPos()
	{
		return default(Vector3);
	}

	private void _003COnRefreshBtnClick_003Eb__44_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
