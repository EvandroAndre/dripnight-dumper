using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UILadderLeaderBoardController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public enum NavigationType
	{
		NotSpecific,
		ToMatch,
		ToWeaponPower,
		ToPeak
	}

	public class WeaponPowerNavigationData
	{
		public NavigationType NavType;

		public string TabDeepLink;

		public string FirstFilterDeepLink;

		public string SecondFilterDeepLink;

		public string ThirdFilterDeepLink;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<TabInfo> _003C_003E9__129_0;

		public static Predicate<TabInfo> _003C_003E9__129_2;

		public static Predicate<TabInfo> _003C_003E9__156_0;

		public static Predicate<TabInfo> _003C_003E9__156_1;

		public static Predicate<TabInfo> _003C_003E9__156_2;

		public static Predicate<TabInfo> _003C_003E9__160_0;

		public static Predicate<TabInfo> _003C_003E9__160_1;

		public static Predicate<TabInfo> _003C_003E9__210_1;

		public static Predicate<TabInfo> _003C_003E9__210_3;

		public static Predicate<TabInfo> _003C_003E9__210_0;

		internal bool _003CSetNewTabTagState_003Eb__129_0(TabInfo tab)
		{
			return false;
		}

		internal bool _003CSetNewTabTagState_003Eb__129_2(TabInfo tab)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__156_0(TabInfo tab)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__156_1(TabInfo tab)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__156_2(TabInfo tab)
		{
			return false;
		}

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__160_0(TabInfo tab)
		{
			return false;
		}

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__160_1(TabInfo tab)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__210_1(TabInfo tab)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__210_3(TabInfo tab)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__210_0(TabInfo tab)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public string deepLink;

		internal bool _003CInitLimitedTimeRankFilter_003Eb__0(FilterItemData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public WeaponPowerNavigationData navData;

		internal bool _003CNavigationToLeaderBoard_003Eb__3(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__4(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__5(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__6(TabInfo tabinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass160_0
	{
		public string tabDeepLink;

		public UILadderLeaderBoardController _003C_003E4__this;

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__2(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__3(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__4(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CGotoDefaultWeaponPowerTab_003Eb__5(TabInfo tabinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass204_0
	{
		public uint modeID;

		internal int _003CSortLimitedTimeRankLeaderboardInfo_003Eb__0(LeaderBoardInfo data1, LeaderBoardInfo data2)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_0
	{
		public string deepLink;

		internal bool _003COnDataChanged_003Eb__2(TabInfo tabinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_1
	{
		public string deepLink;

		internal bool _003COnDataChanged_003Eb__4(TabInfo tabinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_2
	{
		public string selectDeepLink;

		public string deepLink;

		internal bool _003COnDataChanged_003Eb__5(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__6(TabInfo tabinfo)
		{
			return false;
		}
	}

	private UILadderLeaderBoardView m_View;

	private GameObject m_Loading;

	private GameObject m_Share;

	private GameObject m_Profile;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private List<TabInfo> m_TabList;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private List<List<StandardSubTabItemViewData>> m_SubTabDataList;

	private readonly Dictionary<string, List<FilterData>> m_DicFilterData;

	private readonly Dictionary<uint, string[]> m_DicFiltersCached;

	private string[] m_Filters;

	private LadderType m_LadderType;

	private LeaderBoardInfo m_SelectedInfo;

	private uint m_SelectedWeaponID;

	private ELeaderBoardTitleRegionType m_LeaderBoardRegionType;

	private ulong m_LeaderBoardID;

	private int m_LeaderBoardType;

	private uint m_RequestPropIDs;

	private WeaponPowerNavigationData m_WeaponPowerNavData;

	private ulong m_SelectedAccountID;

	private bool m_HideProfile;

	private bool m_ChooseDefaultWeaponID;

	private bool m_IsBRWPOpen;

	private bool m_IsCSWPOpen;

	private bool m_IsRankingAreaLeaderBoardOpen;

	private bool m_IsCsPeakAreaLeaderBoardOpen;

	private bool m_NeedResetWPLeaderBoardRequestCD;

	private bool m_NeedResetRankLeaderBoardRequestCD;

	private int m_lastSelectIndex;

	private UIEasyList m_EasyList;

	private AutoPopup m_AutoPopup;

	private List<UIPopMenuLeaderBoardControler> m_PopMenusList;

	private UIPopWndStandardDrawerTabRemakeController m_DrawerTabCtrl;

	private UILadderLeaderBoardItemController m_SelfRankUI;

	private UILeaderBoardNewController m_LeaderBoardCtrl;

	private LeaderBoardIDV2 m_LimitedTimeRankFriendLeaderboardID;

	private LeaderBoardIDV2 m_LimitedTimeRankRegionLeaderboardID;

	public string DL_BRRank;

	public string DL_CSRank;

	public string DL_PeriodicRank;

	public string DL_BRWeapon;

	public string DL_CSWeapon;

	public string DL_LimitedTimeRank;

	public string DL_CsPeak;

	public const string DL_Friend = "Friend";

	public const string DL_Region = "Region";

	public const string DL_Location = "Location";

	public const string DL_Country = "Country";

	public const string DL_Province = "Province";

	public const string DL_City = "City";

	public const string PLAYERPREF_BRMATCH_TAB = "LeaderBoard_BrMatch_TAB";

	public const string PLAYERPREF_CSMATCH_TAB = "LeaderBoard_CsMatch_TAB";

	public const string PLAYERPREF_CSPeak_TAB = "LeaderBoard_CsPeak_TAB";

	private const uint FILTER_NUM = 4u;

	private float m_RankEasyListLocationPosY;

	private float m_RankEasyListFriendRegionPosY;

	private float m_RankScrollViewDefaultPosY;

	private float m_RankScrollViewDefaultSizeY;

	private float m_ReigionToggleDefaultPosY;

	private float m_RankTitlePosOffsetY;

	private const float RANK_TITLEPOS_X = -249f;

	private const float RANK_TITLENAME_X = 40f;

	private const float RANK_TITLEPOS_X_FRIEND = -296f;

	private const float RANK_TITLENAME_X_FRIEND = -7f;

	private const float SCROLL_BUTTON_OFFSET_Y = 40f;

	private const float COUNTDOWN_ENDTIME_LABEL_STARTPOS_X = 58f;

	private const float COUNTDOWN_ENDTIME_ICON_WIDTH = 16f;

	private const int RANK_TOGGLE_TWO_WIDTH = 274;

	private const int RANK_TOGGLE_THREE_WIDTH = 406;

	public int LastSelectIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public LadderType LadderType => LadderType.None;

	private LeaderBoardIDV2 LimitedTimeRankFriendLeaderboardID => null;

	private LeaderBoardIDV2 LimitedTimeRankRegionLeaderboardID => null;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetLeaderBoardController(UILeaderBoardNewController ctrl)
	{
	}

	public void SetTabList(List<TabInfo> list)
	{
	}

	public void SetDrawerTabController(UIPopWndStandardDrawerTabRemakeController ctrl)
	{
	}

	public void SetMainTabDataList(List<StandardTabItemViewData> list)
	{
	}

	public void SetSubTabDataList(List<List<StandardSubTabItemViewData>> list)
	{
	}

	public void SetShare(GameObject share)
	{
	}

	public void SetProfile(GameObject profile)
	{
	}

	public void OnTabClick(string deepLink, LadderType ladderType)
	{
	}

	private void SetRegionToggleIcon()
	{
	}

	private void SetRegionToggleIcon(ResourceID countryRes, ResourceID provinceRes, ResourceID cityRes)
	{
	}

	private void OnRankLocationTopClick(object data)
	{
	}

	private void OnRankLocationSubClick(object data)
	{
	}

	private void OnRankFriendClick(object data)
	{
	}

	private void OnRankRegionClick(object data)
	{
	}

	private void OnWeaponRegionClick(object data)
	{
	}

	private void OnWeaponTypeFilterClick(object data)
	{
	}

	private void OnWeaponModelFilterClick(object data)
	{
	}

	private void OnLocateIconClick()
	{
	}

	public void OnShareClick()
	{
	}

	public void OnProfileClick()
	{
	}

	private void OnSeasonTipsBtnClick()
	{
	}

	private void OnCSSeasonTipsBtnClick()
	{
	}

	private void OnPeakSeasonTipsBtnClick()
	{
	}

	private void OnGoToPeakBtnClick()
	{
	}

	private void OnScrollBtnClick()
	{
	}

	public void ScrollToIndex(int index)
	{
	}

	public bool IsSelfRankUIInCurrentPage(int index)
	{
		return false;
	}

	public void SetSelfLocationBtnShow()
	{
	}

	public int GetEasylistMaxCount()
	{
		return 0;
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void SetRankPanelDefaultSize()
	{
	}

	private void SetNoDataTipsState(bool show, bool isRankLocation = false, bool isCsPeakFriend = false)
	{
	}

	private void SetRankTitleLabel()
	{
	}

	private void SetLocateIconState(bool show)
	{
	}

	private void SetProfileBtnState(bool show)
	{
	}

	private void SetNewTabTagState()
	{
	}

	private void SetNoLocationState()
	{
	}

	private void SetSelfInfoActive(bool show)
	{
	}

	private void SetFilterAndCallBackPopMenuClick(string deepLink)
	{
	}

	private void ShowSelfNoDataTips()
	{
	}

	private void RefreshWeaponLeaboard(FilterItemData itemData)
	{
	}

	public void NewRefreshUI()
	{
	}

	private void InitFilterDic()
	{
	}

	private void InitRankFilter(string deepLink)
	{
	}

	private void InitLimitedTimeRankFilter(string deepLink)
	{
	}

	private void InitPeriodicRankFilter(string deepLink)
	{
	}

	private void InitWeaponFilter(string tabDeepLink)
	{
	}

	private void AddWeaponFilter(string tabDeepLink)
	{
	}

	private FilterData ProcessWeaponTypeFilterData()
	{
		return null;
	}

	private void InitToggleBtnGroup()
	{
	}

	private void SetToggleGroupUI()
	{
	}

	private void OnLocationToggleClick(int index)
	{
	}

	private FilterItemData GetCurLocationFilterItemDatas(int index)
	{
		return null;
	}

	private FilterItemData GetCurRankFilterItemDatas(int index)
	{
		return null;
	}

	private void RefreshLocationToggleFilter()
	{
	}

	private void InitPopMenu()
	{
	}

	private void InitPopMenuData(Func<FilterData, List<PopMenuData>> func, string tabFilter)
	{
	}

	private List<PopMenuData> GenerateFilterData(FilterData filterData)
	{
		return null;
	}

	private void SetFilter(string filter1 = "", string filter2 = "", string filter3 = "", string filter4 = "", bool hasLadderTypeSet = true)
	{
	}

	private void SetFilterByClick(FilterItemData itemData)
	{
	}

	private static WeaponPowerNavigationData GetNavigationData(List<object> rawData)
	{
		return null;
	}

	private void SetDefaultNavi(string tabDeepLink)
	{
	}

	private void NavigationToLeaderBoard(WeaponPowerNavigationData navData)
	{
	}

	private void MatchAreaNavParamToAreaData()
	{
	}

	private bool NavigationToDefaultWeaponPower(bool isBrWeaponPower)
	{
		return false;
	}

	private void RefreshUIByClickCallBack()
	{
	}

	private void GotoDefaultWeaponPowerTab(string tabDeepLink)
	{
	}

	private LeaderBoardIDV2 GetLimitedTimeRankRegionLeaderboardID(uint gameMode)
	{
		return null;
	}

	private void AddEventDelegate()
	{
	}

	private void ResetUIOnTabClick()
	{
	}

	private void ResetCacheData(LadderType ladderType)
	{
	}

	private void SetSeasonBtnState()
	{
	}

	private void SetCountDownEndTimePos()
	{
	}

	private void SetRankLocationFilterPos()
	{
	}

	private void ResetRankFilterPos()
	{
	}

	private void ChanePosUtil(Transform transForm, float value, bool isX)
	{
	}

	private void SetLine(bool isdefault)
	{
	}

	private void ShowLine(bool isShow)
	{
	}

	private void SetRegionTogglePos(float regionToggleSizeY)
	{
	}

	private void SetRankLocationUIStyle()
	{
	}

	private void ReSetRankLocationUIStyle()
	{
	}

	private void UpdateStyle(LadderType ladderType)
	{
	}

	private void SetRequestBoardType(uint propID)
	{
	}

	private void SetTitleList()
	{
	}

	private void InitSelfItem()
	{
	}

	private void InitSeasonInfo()
	{
	}

	private void RefreshList(List<LeaderBoardInfo> dataList)
	{
	}

	private void RefreshSelfInfo(LeaderBoardInfo selfInfo, uint maxSize, bool showClosedUI = false)
	{
	}

	private void RequestWeaponPowerLeaderBoard()
	{
	}

	private void RequestAreaRankLeaderBoard()
	{
	}

	private DLBMPCCFKKM GetWPLeaderBoardMatchModeByLadderType(LadderType ladderType)
	{
		return DLBMPCCFKKM.EMATCHMODE_NONE;
	}

	private void SetPopMenuData(UILeaderBoardNewController.DeepLinkLayer layer, string filter)
	{
	}

	private void RefreshNoLocationUI(bool isShowNoLocationUI)
	{
	}

	private void ResetRankTitlePos()
	{
	}

	private void SetRankFriendTitlePos()
	{
	}

	private void ResetLimitedTimeRankTitlePos()
	{
	}

	private bool IsPeriodicSeasonTipsBtnVisible()
	{
		return false;
	}

	private bool IsCurTabLadderMatch()
	{
		return false;
	}

	private bool IsCurTabPeak()
	{
		return false;
	}

	private bool IsCurTabWeaponPower()
	{
		return false;
	}

	private bool IsCurTabRankInLocation()
	{
		return false;
	}

	private bool IsCurTabPeakInLocation()
	{
		return false;
	}

	private bool IsCachedFilterAvailable()
	{
		return false;
	}

	private bool IsGotoDefaultWPTab(WeaponPowerNavigationData navData)
	{
		return false;
	}

	private void RefreshEasyList()
	{
	}

	private void BeforeRequestLeaderBoard(FilterItemData filterItemData, uint PropID)
	{
	}

	private void NewGotoDefaultTab()
	{
	}

	private bool IsSelectWeaponPowerTab(LadderType ladderType)
	{
		return false;
	}

	private bool IsSelectRankTab(LadderType ladderType)
	{
		return false;
	}

	private bool IsSelectPeakTab(LadderType ladderType)
	{
		return false;
	}

	private void SortLimitedTimeRankLeaderboardInfo(uint modeID, List<LeaderBoardInfo> infos)
	{
	}

	public void SelectLeaderBoardItem(ulong accountID, uint rank, bool hideProfile)
	{
	}

	public void SetSelectInfo(LeaderBoardInfo info)
	{
	}

	private bool ShowAvatar(ulong accountID)
	{
		return false;
	}

	public void TryShowPreviewAvatar()
	{
	}

	private void TryShowPreviewAvatar(ulong accountID)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public LeaderBoardInfo GetAreaLeaderBoardSelfInfo(bool isBR, ulong leaderBoardID, List<LeaderBoardInfo> leaderBoardList)
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private bool _003CSetNewTabTagState_003Eb__129_1(TabInfo x)
	{
		return false;
	}

	private bool _003CSetNewTabTagState_003Eb__129_3(TabInfo x)
	{
		return false;
	}

	private void _003CInitToggleBtnGroup_003Eb__143_0()
	{
	}

	private void _003CInitToggleBtnGroup_003Eb__143_1()
	{
	}

	private void _003CInitToggleBtnGroup_003Eb__143_2()
	{
	}

	private void _003CInitToggleBtnGroup_003Eb__143_3()
	{
	}

	private void _003CInitToggleBtnGroup_003Eb__143_4()
	{
	}

	private void _003CInitToggleBtnGroup_003Eb__143_5()
	{
	}

	private bool _003CRefreshUIByClickCallBack_003Eb__159_2(FilterItemData x)
	{
		return false;
	}

	private bool _003CRefreshUIByClickCallBack_003Eb__159_0(FilterItemData x)
	{
		return false;
	}

	private bool _003CRefreshUIByClickCallBack_003Eb__159_1(FilterItemData x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
