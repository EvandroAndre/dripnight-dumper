using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanRecruitController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private enum ClanRecruitStyle
	{
		None,
		RecruitWithRecommendFriend,
		SearchFriend,
		RecommendFriend,
		NoSearchResult
	}

	private enum EnumSortState
	{
		None,
		AscendingOrder,
		DescendingOrder
	}

	private enum EnumSortType
	{
		None,
		BRRank,
		CSRank
	}

	private enum ESearchBtnState
	{
		Search,
		Clear
	}

	private const string FRIEND_NOT_IN_GUILD = "T_48_TT_GUILD_INVITEABLEPERSON";

	private const string SEARCH_RESULT = "T_40_L_FRIEND_SEARCHRESULT";

	private const string NO_RESULT = "T_43_L_GUILD_NOINVATIONRESULT";

	private UIClanRecruitView m_View;

	private ClanRecruitStyle m_RecruitUIStyle;

	private ESearchBtnState m_SearchBtnState;

	private EnumSortState m_CurrentSortState;

	private EnumSortType m_CurrentSortType;

	private List<ClanApplicationAndInvitationInfo> m_ClanApplicationList;

	private Color32 White;

	private Color32 Grey;

	private bool m_ShowApprovalToggle;

	private bool m_IsApprovalToggleChosen;

	private bool m_IsApplyRequestFinish;

	private bool m_IsApplyRequesting;

	private bool m_IsAllClanApplyRead;

	private UIModelFriends m_ModelFriends;

	private UIModelClan m_ModelClan;

	private List<FriendAccountInfo> m_Friends;

	private List<FriendAccountInfo> m_RecommendFriends;

	private List<FriendAccountInfo> m_SearchResultFriends;

	private UIEasyList RecruitPlayerList => null;

	private UIEasyList RecruitRecommendPlayerList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowApplyUIAfterInit()
	{
	}

	private void InitUIState()
	{
	}

	private void ChangeRecruitUIStyle()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCommunityBtnClick()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void RefreshAllRecruitUI()
	{
	}

	private void TryRefreshFriendsList(bool force = false)
	{
	}

	private void TryRefreshRecommendFriendList(bool force = false)
	{
	}

	private List<FriendAccountInfo> FilterInviteablePlayers(List<FriendAccountInfo> source)
	{
		return null;
	}

	private void TryRefreshSearchFriendsList()
	{
	}

	private void TryRefreshNoSearchResultFriendsList()
	{
	}

	private void SearchPlayer()
	{
	}

	private void OnApprovalToggleClick()
	{
	}

	private void OnRecruitToggleClick()
	{
	}

	private void OnClickClanPromotionBtn()
	{
	}

	private void OnClickBRSortBtn()
	{
	}

	private void OnClickCSSortBtn()
	{
	}

	private void SortMember()
	{
	}

	private int BRRankComparison(ClanApplicationAndInvitationInfo p1, ClanApplicationAndInvitationInfo p2)
	{
		return 0;
	}

	private int CSRankComparison(ClanApplicationAndInvitationInfo p1, ClanApplicationAndInvitationInfo p2)
	{
		return 0;
	}

	private void SwapComparer(ref ClanApplicationAndInvitationInfo p1, ref ClanApplicationAndInvitationInfo p2)
	{
	}

	private void ClearAllIconColor()
	{
	}

	private void TryRefreshApplyPlayerList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
