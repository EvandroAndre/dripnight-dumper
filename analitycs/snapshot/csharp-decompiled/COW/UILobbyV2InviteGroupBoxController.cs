using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UILobbyV2InviteGroupBoxController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<RoomPlayerInfo> _003C_003E9__88_1;

		public static Func<FriendAccountInfoData, FriendAccountInfo> _003C_003E9__101_1;

		internal bool _003CUpdateRoomPlayersList_003Eb__88_1(RoomPlayerInfo player)
		{
			return false;
		}

		internal FriendAccountInfo _003ConSearchBtnClick_003Eb__101_1(FriendAccountInfoData a)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public UILobbyV2InviteGroupBoxController _003C_003E4__this;

		public string name;

		internal void _003ConSearchBtnClick_003Eb__0()
		{
		}

		internal bool _003ConSearchBtnClick_003Eb__2(TeamMemberWithAccountInfo a)
		{
			return false;
		}

		internal bool _003ConSearchBtnClick_003Eb__3(UIModelCupMatch.AccountInfoBasicWithCupInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public ulong uid;

		internal bool _003CAddRecommandPlayer_003Eb__0(ulong item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public ulong uid;

		internal bool _003CAddRecommandPlayerWithoutCheck_003Eb__0(ulong item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public FriendAccountInfo player;

		internal bool _003CGetRecommandPlayerNotInGroup_003Eb__0(ulong id)
		{
			return false;
		}
	}

	private sealed class _003CDelayRefreshNewBeeRecFriendList_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2InviteGroupBoxController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshNewBeeRecFriendList_003Ed__98(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDelayRepositionBottomGridTable_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2InviteGroupBoxController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRepositionBottomGridTable_003Ed__64(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CNewBeeRecRefreshCountDownCoroutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ulong endTime;

		public UILobbyV2InviteGroupBoxController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CNewBeeRecRefreshCountDownCoroutine_003Ed__69(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILobbyV2InviteGroupBoxView m_View;

	private string INVITE_FILTER;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelFriends m_ModelFriends;

	private UIModelGroup m_ModelGroup;

	private UIModelMatch m_ModelMatch;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private UIModelCustomRoom m_ModelCustomRoom;

	private GroupInviteMemberType m_InviteType;

	private List<FriendAccountInfoData> m_CachedFriends;

	private List<ClanMember> m_CachedClanMembers;

	private List<FriendAccountInfo> m_RecommandPlayer;

	private List<RoomPlayerInfo> m_CachedRoomPlayers;

	private List<ulong> m_RecommandPlayerIdList;

	private const int NewBeeRecItemPoolSize = 3;

	private List<UINewBeeRecFriendItemController> m_NewBeeRecFriendItemList;

	private bool m_NewBeeRecItemsInitialized;

	private bool m_HastUpdateRecent;

	private ulong m_LastRefreshTime;

	private bool m_HasSearch;

	private bool m_IsSearchingStranger;

	private string m_PendingSearchText;

	private List<FriendAccountInfo> m_ExactSearchResults;

	private List<FriendAccountInfo> m_FuzzySearchResults;

	private bool m_ExactSearchCompleted;

	private bool m_FuzzySearchCompleted;

	private List<FriendAccountInfoData> m_DisplayedSearchResults;

	private uint m_WinkCall;

	private List<ulong> m_CurrrentMemebers;

	private int m_OriginalScrollViewTopOffset;

	private const int STRANGER_SEARCH_HINT_HEIGHT = 50;

	private float m_LastSearchTime;

	private UIClickMask m_StatusClickMask;

	private UICommonCodeInputWindowController m_CodeInputWindow;

	private UILobbyV2GroupInviteItemController m_FloatingWindow;

	private UILobbyV2LeaderBoardController m_LobbyV2LeaderBoardController;

	private UILobbyV2GroupInviteItemController.GroupInviteUI m_InviteUI;

	private bool m_ReuqestedChampionshipTeamMembersPresence;

	private bool m_RequestedCupTeamMembersPresence;

	private bool m_HasPublicRoot;

	private bool m_HasLastUseFloatingWindow;

	private bool m_IsShowFullTeamcode;

	private bool m_isEnableCommunity;

	private uint m_DelayCallClanIcon;

	private bool m_IsShowClanIcon;

	private uint m_ItemCountInScrollView;

	private bool m_IsInGame;

	private bool m_IsInGameUGCSocial;

	private bool m_NeedResetScrollViewPosition;

	private Vector3 m_AddFriendDefaultLocalPos;

	private Vector3 m_LightDefaultLocalPos;

	private const float AddFriendOffset = 74f;

	private ulong m_LastRequestRecommandPlayerInfoTime;

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

	protected override void OnUIDestroy()
	{
	}

	public void SetData(GroupInviteMemberType defaultInviteType = GroupInviteMemberType.Friend)
	{
	}

	private void InitItemCountData()
	{
	}

	private void OnClickRefreshNewBeeRecCountDownLabelBtn()
	{
	}

	private void OnClickRefreshNewBeeRecBtn()
	{
	}

	private void RefreshNewBeeRecFriendList()
	{
	}

	private IEnumerator DelayRepositionBottomGridTable()
	{
		return null;
	}

	private int GetNewBeeRecommendCount()
	{
		return 0;
	}

	private void InitNewBeeRecFriendItemPool()
	{
	}

	private void TryResumeNewBeeRecCountDown()
	{
	}

	private void StartNewBeeRecRefreshCountDown()
	{
	}

	private IEnumerator NewBeeRecRefreshCountDownCoroutine(ulong endTime)
	{
		return null;
	}

	private void RefreshAddFriendItemView()
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

	private void OnRoomToggleClick()
	{
	}

	private void SetRecentUIData()
	{
	}

	private void SetRecentRecommandUIData()
	{
	}

	private void UpdateRoomPlayersList()
	{
	}

	private void RefreshRoomUIData()
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

	private void OnEnable()
	{
	}

	private IEnumerator DelayRefreshNewBeeRecFriendList()
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ClearStrangerSearchState()
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

	private void OnMatchmakingShow()
	{
	}

	private void OnSelectGameMode(object[] args)
	{
	}

	private void RefreshFriendState()
	{
	}

	private void ChangePublicState(object[] args)
	{
	}

	public void OnClickClose()
	{
	}

	private void FinishedTween()
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

	private void AddRecommandPlayerWithoutCheck(ulong uid)
	{
	}

	private void UpdateRecommandPlayer()
	{
	}

	public void UpdateFloatingWindow()
	{
	}

	public void UpdateFloatingWindowWhenRefresh()
	{
	}

	private void SetStrangerSearchHintSpace(bool enabled)
	{
	}

	private void SearchStrangerAccount(string searchText)
	{
	}

	private void ShowStrangerSearchResult()
	{
	}

	private void RefreshStrangerSearchResultPresence()
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

	public void ShowGroupInviteLeaderBox()
	{
	}

	private void OnChangeBtnClick()
	{
	}

	private void OnClickCommunity()
	{
	}

	private void SetSocialStatus()
	{
	}

	private void OnClickStatusBtn()
	{
	}

	private void OnClickBtnInviteMe()
	{
	}

	private void OnClickBtnOnline()
	{
	}

	private void OnClickBtnQuickAddFriend()
	{
	}

	private void OnClickBtnDontDisturb()
	{
	}

	private void OnQuickEnter()
	{
	}

	private void OnGroupCodeEnter(object data)
	{
	}

	private void OnSerachMiniClick()
	{
	}

	private void OnReturnBtnClick()
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

	private void SwitchTeamcodeStyle(bool isShowFull)
	{
	}

	private void RefreshTeamcodeAndCommunity()
	{
	}

	private void CancelClanIconCarousel()
	{
	}

	private void SetClanIconCarousel()
	{
	}

	private List<FriendAccountInfoData> GetFriendAccountInfoData(List<FriendAccountInfo> list)
	{
		return null;
	}

	private bool IsOpenHippoCrisisLobby()
	{
		return false;
	}

	private void SetDisablePlayerInputDrag()
	{
	}

	public GroupInviteMemberType GetCurrentInviteType()
	{
		return GroupInviteMemberType.Friend;
	}

	private void UpdateAddFriendContainerAnchor()
	{
	}

	public void SetInGameUGCSocialState()
	{
	}

	private void ResetScrollViewPosition()
	{
	}

	private void _003COnRefreshBtnClick_003Eb__78_0()
	{
	}

	private int _003CUpdateRoomPlayersList_003Eb__88_0(RoomPlayerInfo a, RoomPlayerInfo b)
	{
		return 0;
	}

	private void _003COnClickStatusBtn_003Eb__132_0()
	{
	}

	private void _003CSetClanIconCarousel_003Eb__148_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
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
