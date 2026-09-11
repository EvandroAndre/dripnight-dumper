using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIFriendController : UINavigationController, IUIModelDataChangeObserver, IEasyList, ITipsDelegate
{
	private enum ESearchBtnState
	{
		Search,
		Clear
	}

	public enum EFriendSearchType
	{
		FuzzySearch,
		PrecisiousSearch,
		Recommand
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<FriendAccountInfo> _003C_003E9__58_0;

		public static Predicate<FriendAccountInfo> _003C_003E9__58_1;

		public static Predicate<StandardTabItemViewData> _003C_003E9__59_2;

		public static EventDelegate.Callback _003C_003E9__59_1;

		public static Predicate<StandardTabItemViewData> _003C_003E9__90_0;

		internal bool _003CRefreshViewInfo_003Eb__58_0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRefreshViewInfo_003Eb__58_1(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRefreshFriendListEmptyAction_003Eb__59_2(StandardTabItemViewData x)
		{
			return false;
		}

		internal void _003CRefreshFriendListEmptyAction_003Eb__59_1()
		{
		}

		internal bool _003CCheckAndShowNearbySearchGuide1_003Eb__90_0(StandardTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public EFriendTabType type;

		internal bool _003CSelectTab_003Eb__0(StandardTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public UIFriendController _003C_003E4__this;

		public UICommonCountDownBoxController ctrl;

		internal void _003CShowGoToSystemSettingsDialog_003Eb__0()
		{
		}

		internal void _003CShowGoToSystemSettingsDialog_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public FriendAccountInfo x;

		public FriendAccountInfo y;

		internal bool _003CCompareFriendForDisplay_003Eb__0(TeamMemberWithAccountInfo e)
		{
			return false;
		}

		internal bool _003CCompareFriendForDisplay_003Eb__1(TeamMemberWithAccountInfo e)
		{
			return false;
		}
	}

	private UIFriendView m_View;

	private UIRelationshipController m_RelationShipController;

	private UIModelShare m_ModelShare;

	private UIModelFriends m_ModelFriends;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelLocalization m_ModelLocalization;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIStandardTabController m_TabCtrl;

	private UIAddFriendController m_AddFriendController;

	private bool m_WaitingForGPSPermissionFromSettings;

	private const int TopAnchor_FriendList = -7;

	private const int TopAnchor_RecommandList = -75;

	private uint m_DelayCallClanIcon;

	private bool m_IsFirstOpen;

	private string m_PreNavigation;

	private int m_scrollWidth;

	private bool m_IsNotifiedWhileInactive;

	private bool m_IsShowClanIcon;

	private EFriendTabType m_CurrentType;

	private ESearchBtnState m_SearchBtnState;

	private EFriendSearchType m_SearchType;

	private bool m_IsSearchingStranger;

	private string m_PendingSearchText;

	private List<FriendAccountInfo> m_ExactSearchResults;

	private List<FriendAccountInfo> m_FuzzySearchResults;

	private List<FriendAccountInfo> m_MergedSearchResults;

	private bool m_ExactSearchCompleted;

	private bool m_FuzzySearchCompleted;

	private bool IsNotifiedWhileInactive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EFriendSearchType SearchType => EFriendSearchType.FuzzySearch;

	public EFriendTabType CurrentTabType
	{
		get
		{
			return EFriendTabType.None;
		}
		private set
		{
		}
	}

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

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshHint()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private bool CanTabClick()
	{
		return false;
	}

	private void InitToggles()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OpenWndByFriendWndType(uint friendWnd)
	{
	}

	private void RefreshPlatformIcon()
	{
	}

	private void RefreshInviteBtnGroup()
	{
	}

	private void UpdateShareUI()
	{
	}

	private void OnSelectFriend()
	{
	}

	private void OnSelectShowRelationship()
	{
	}

	private void OnSelectPlatformFriend()
	{
	}

	private void OnSelectAddFriend()
	{
	}

	private void SelectTab(EFriendTabType type)
	{
	}

	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	private void RefreshViewInfo()
	{
	}

	private void RefreshFriendListEmptyAction(int totalCnt, EFriendTabType tabType)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnRemoveFriendsBtnClick()
	{
	}

	private void OnOtherClick()
	{
	}

	private void OnCopyLink()
	{
	}

	private void OnInviteClick()
	{
	}

	private void OnLineClick()
	{
	}

	private void OnWhatsAppClick()
	{
	}

	private void OnInstagramClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnAddFriendsBtnClicked()
	{
	}

	private void OnBlackListBtnClicked()
	{
	}

	private void OnNearbySearchBtnClick()
	{
	}

	private void HandleFirstTimeNearbySearch(string guideKey)
	{
	}

	private void HandleNonFirstTimeNearbySearch()
	{
	}

	private void RequestGPSPermissionFromOS()
	{
	}

	private void ShowGoToSystemSettingsDialog()
	{
	}

	private void OpenNearbySearchWindow()
	{
	}

	private void OnSearchFriendBtnClicked()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	public bool IsShowRecommandList()
	{
		return false;
	}

	private void SearchPlayer()
	{
	}

	private void ShowStrangerSearchResult()
	{
	}

	private void RefreshStrangerSearchResultPresence()
	{
	}

	private void ClearStrangerSearchState()
	{
	}

	private void SetClanIconCarousel()
	{
	}

	private List<FriendAccountInfoData> GetFriendAccountInfoData(List<FriendAccountInfo> list)
	{
		return null;
	}

	private int CompareFriendForDisplay(FriendAccountInfoData a, FriendAccountInfoData b)
	{
		return 0;
	}

	public EBriefBoxDetail_FriendTab GetBriefBoxDetail()
	{
		return EBriefBoxDetail_FriendTab.None;
	}

	private void CheckAndShowNearbySearchGuide1()
	{
	}

	private void CheckAndShowNearbySearchGuide2()
	{
	}

	private void _003CRefreshFriendListEmptyAction_003Eb__59_0()
	{
	}

	private void _003CHandleFirstTimeNearbySearch_003Eb__74_0()
	{
	}

	private void _003CHandleFirstTimeNearbySearch_003Eb__74_1()
	{
	}

	private void _003CRequestGPSPermissionFromOS_003Eb__76_0(bool granted)
	{
	}

	private void _003CSetClanIconCarousel_003Eb__86_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
