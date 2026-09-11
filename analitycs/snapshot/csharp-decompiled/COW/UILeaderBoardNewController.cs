using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;
using UnityEngine.Events;
using proto;

namespace COW;

public class UILeaderBoardNewController : UIPreviewNavigationController, IEasyList, IUIModelDataChangeObserver
{
	private enum EStyle
	{
		Short,
		Shorter,
		Long
	}

	private class UIActiveState
	{
		public GameObject UI;

		public bool Active;

		public UIActiveState(GameObject ui, bool active)
		{
		}
	}

	public enum DeepLinkLayer
	{
		L0,
		L1,
		L2,
		L3
	}

	private sealed class _003C_003Ec__DisplayClass193_0
	{
		public int index;

		public UILeaderBoardNewController _003C_003E4__this;

		internal void _003CInitGuildWarSelectAction_003Eb__0()
		{
		}

		internal void _003CInitGuildWarSelectAction_003Eb__1()
		{
		}

		internal void _003CInitGuildWarSelectAction_003Eb__2()
		{
		}

		internal void _003CInitGuildWarSelectAction_003Eb__3()
		{
		}

		internal void _003CInitGuildWarSelectAction_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass197_0
	{
		public uint copyGameMode;

		public UILeaderBoardNewController _003C_003E4__this;

		internal void _003CInitTabInfoList_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass277_0
	{
		public bool navigationToLadderBoard;

		public UILeaderBoardNewController _003C_003E4__this;

		public UINavigationData navigationData;

		public bool isRoot;

		internal void _003COnNavigationShowed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass282_0
	{
		public string filter1;

		public string filter2;

		internal bool _003CNavigationToLeaderBoard_003Eb__0(TabInfo tabinfo)
		{
			return false;
		}

		internal bool _003CNavigationToLeaderBoard_003Eb__1(TabInfo tabinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass418_0
	{
		public UILeaderBoardNewController _003C_003E4__this;

		public UMAData umaData;

		public UnityAction<UMAData> characterUpdatedCallback;

		internal void _003CChangeAvatarMaterial_003Eb__0(UMAData data)
		{
		}
	}

	private sealed class _003CDelayCreateUI_003Ed__279 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILeaderBoardNewController _003C_003E4__this;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreateUI_003Ed__279(int _003C_003E1__state)
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

	private UILeaderBoardNewView m_View;

	private UINavigationData m_NavData;

	public bool m_LeaderBoardMenuCreated;

	private int m_RequestPropIDs;

	private Action m_RefreshList;

	private List<PVELeaderboardRewardDesc> m_CurPVELeaderboardRewards;

	private UILeaderBoardItemNewController m_SelfRankUI;

	private UILeaderBoardItemNewController.DisplayType m_ListItemDisplayType;

	private string m_DeepLink;

	private bool m_IsInitPveInfo;

	private PVEDifficultyAttributeRuleDesc m_PVE2DifficultyAttributeRule;

	private PVEDifficultyAttributeRuleDesc m_PVEInfiniteDifficultyAttributeRule;

	private PVEDifficultyAttributeRuleDesc m_CurSelectedPVEDifficultyAttributeRule;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClan m_ModelClan;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private UIModelWishList m_ModelWishList;

	private UIModelInventory m_ModelInventory;

	private uint m_CSRankLeaderBoardMinRank;

	private uint m_BRRankLeaderBoardMinRank;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private List<List<StandardSubTabItemViewData>> m_SubTabDataList;

	private List<UIActiveState> m_DelayShowUIs;

	private UIPopWndStandardDrawerTabRemakeController m_DrawerTabCtrl;

	private List<FilterItemData> m_ToggleDataList;

	private List<UIPopMenuLeaderBoardControler> m_PopMenusList;

	private Dictionary<string, Action> m_DicCallBack;

	private List<string> m_Filters;

	private Dictionary<string, List<FilterData>> m_DicFilterData;

	private List<TabInfo> m_TabList;

	private int m_BGWidth1;

	private int m_BGWidth2;

	private int m_BGWidth3;

	private EStyle m_CurrStyle;

	private ulong m_SelectedAccountID;

	private bool m_SelectedIsAnonymous;

	private bool m_InitedBGWidth;

	private bool m_IsLadderLeaderBoard;

	private WishListLeaderboardPeriod m_CurrentWishListLeaderboardPeriod;

	private WishListLeaderboardItem m_SelectedWishListLeaderboardItem;

	private UIRoot uiRoot;

	private UILaunchTagFrameController m_LaunchTag;

	private uint m_RequestBoardID;

	private int m_LeaderBoardType;

	private Dictionary<int, Action> m_GuildWarIndivdual_RoundSelect_Action;

	private Dictionary<int, Action> m_GuildWarGuild_Country_RoundSelect_Action;

	private Dictionary<int, Action> m_GuildWarGuild_Province_RoundSelect_Action;

	private Dictionary<int, Action> m_GuildWarGuild_City_RoundSelect_Action;

	private Dictionary<int, Action> m_GuildWarGuild_Region_RoundSelect_Action;

	private const int ROUND_INVALID = -1;

	private const int SelfBGPadding = 6;

	private const uint GuildTypeRegion = 99u;

	private int m_GuildWarRound;

	public static string GUILD_ACTIVE_LOCATED;

	private UILadderLeaderBoardController m_LadderLeaderCtrl;

	public const string DL_Rank = "RANK";

	public const string DL_CSRank = "CSRANK";

	public const string DL_Guild = "GUILD";

	public const string DL_GuildHonor = "GUILDHONOR";

	public const string DL_WarInfoIndividual = "WARINDIVIDUAL";

	public const string DL_WarInfoGuild = "WARGUILD";

	public const string DL_GuildActive = "GUILDACTIVE";

	public const string DL_WarChampionshipInfoGuild = "WARCHAMPIONSHIP";

	public const string DL_Badges = "BADGES";

	public const string DL_HuntingGround = "HUNTINGGROUND";

	public const string DL_Friend = "FRIEND";

	public const string DL_Region = "REGION";

	public const string DL_Global = "GLOBAL";

	public const string DL_Country = "COUNTRY";

	public const string DL_Province = "PROVINCE";

	public const string DL_City = "CITY";

	public const string DL_LadderMatch = "LadderMatch";

	public const string DL_WeaponPower = "WeaponPower";

	public const string DL_Peak = "Peak";

	public const string DL_CsPeak = "CsPeak";

	public const string DL_LimitedTimeRank = "LimitedTimeRank";

	public const string DL_Kill = "KILL";

	public const string DL_Win = "WIN";

	public const string DL_KD = "KD";

	public const string DL_Score = "SCORE";

	public const string DL_GuildWeek = "GUILDWEEK";

	public const string DL_GuildTotal = "GUILDTOTAL";

	public const string DL_SOLO = "SOLO";

	public const string DL_DUO = "DUO";

	public const string DL_SQUA = "SQUA";

	public const string DL_PVETimeLimit = "PVETimeLimit";

	public const string DL_PVEInfinite = "Infinite";

	public const string DL_ROUND = "ROUND";

	public const string DL_HIPPOCRISIS = "HIPPOCRISIS";

	public const string DL_WORTH = "WORTH";

	public const string DL_PROFIT = "PROFIT";

	public const string DL_PRIME = "PRIME";

	public const string DL_WISHLIST = "WISHLIST";

	public const string DL_WEEK = "WEEK";

	public const string DL_TOTAL = "TOTAL";

	public const string DL_MONTH = "MONTH";

	public const string DL_YEAR = "YEAR";

	public static readonly string DL_RankFriendKillSOLO;

	public static readonly string DL_RankFriendKillDUO;

	public static readonly string DL_RankFriendKillSQUA;

	public static readonly string DL_RankFriendWinSOLO;

	public static readonly string DL_RankFriendWinDUO;

	public static readonly string DL_RankFriendWinSQUA;

	public static readonly string DL_RankFriendKDSOLO;

	public static readonly string DL_RankFriendKDDUO;

	public static readonly string DL_RankFriendKDSQUA;

	public static readonly string DL_RankRegionKillSOLO;

	public static readonly string DL_RankRegionKillDUO;

	public static readonly string DL_RankRegionKillSQUA;

	public static readonly string DL_RankRegionWinSOLO;

	public static readonly string DL_RankRegionWinDUO;

	public static readonly string DL_RankRegionWinSQUA;

	public static readonly string DL_RankRegionKDSOLO;

	public static readonly string DL_RankRegionKDDUO;

	public static readonly string DL_RankRegionKDSQUA;

	public static readonly string DL_CSRankFriendKill;

	public static readonly string DL_CSRankFriendWin;

	public static readonly string DL_CSRankFriendKD;

	public static readonly string DL_CSRankRegionKill;

	public static readonly string DL_CSRankRegionWin;

	public static readonly string DL_CSRankRegionKD;

	public static readonly string DL_GuildHonorRegionWeek;

	public static readonly string DL_GuildHonorRegionTotal;

	public static readonly string DL_GuildHonorGlobal;

	public static readonly string DL_GuildGlobalActive;

	public static readonly string DL_GuildCountryActive;

	public static readonly string DL_GuildProvinceActive;

	public static readonly string DL_GuildCityActive;

	public static readonly string DL_GuildWarIndivdual;

	public static readonly string DL_GuildWarGuild;

	public static readonly string DL_GuildWarGuildChampionship;

	public static readonly string DL_GuildWarGuildChampionshipCountry;

	public static readonly string DL_EPBadgesFriend;

	public static readonly string DL_EPBadgesRegion;

	public static readonly string DL_EPBadgesGlobal;

	public static readonly string DL_FriendPVETimeLimit;

	public static readonly string DL_RegionPVETimeLimit;

	public static readonly string DL_FriendPVEInfinite;

	public static readonly string DL_RegionPVEInfinite;

	public static readonly string DL_FriendHippoCrisisRank;

	public static readonly string DL_RegionHippoCrisisRank;

	public static readonly string DL_FriendHippoCrisisWorth;

	public static readonly string DL_RegionHippoCrisisWorth;

	public static readonly string DL_FriendHippoCrisisProfit;

	public static readonly string DL_RegionHippoCrisisProfit;

	public static readonly string DL_PrimeFriendMonthly;

	public static readonly string DL_PrimeFriendYearly;

	public static readonly string DL_PrimeFriendTotal;

	public static readonly string DL_PrimeRegionMonthly;

	public static readonly string DL_PrimeRegionYearly;

	public static readonly string DL_PrimeRegionTotal;

	public static readonly string DL_WishListWeek;

	public static readonly string DL_WishListMonth;

	public LeaderBoardInfo m_SelectedInfo;

	private bool m_ClanLocalWeekSelected;

	private bool m_ClanActiveSelected;

	private bool m_NeedToRefreshClanLeaderBoard;

	private Vector3 m_RankTitlePosition;

	public const int RANK_POS_FIX = 20;

	private const float BG_LINE_DEFAULT_POSY = 282f;

	private const float BG_LINE_RANK_POSY = 232f;

	private const int WISH_RANK_SCROLLVIEW_FIX = 580;

	private float m_ScrollViewOriSize;

	private Vector4 m_ScrollViewOriClipRegion;

	private const int WISH_RANK_PREVIEWBORDER_FIX = 20;

	private const string LOG_WISH_LIST_RANKING_TAB = "WishListRankingTab";

	private const string LOG_WISH_LIST_RANKING_WEEK = "WishListRankingWeek";

	private const string LOG_WISH_LIST_RANKING_MONTH = "WishListRankingMonth";

	private const string LOG_WISH_LIST_RANKING_GO_TO_GET = "WishListRankingGoToGet";

	private bool m_CurrentShowRuleBtn;

	public int CurRequestPropIDs => 0;

	private int GuildWarRound => 0;

	private UILadderLeaderBoardController LadderLeaderCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void InitDelayShowUIs()
	{
	}

	private void InitGuildWarSelectAction()
	{
	}

	private void InitSeasonInfo()
	{
	}

	private void InitPVEBoardInfo()
	{
	}

	private void InitBGWidth()
	{
	}

	private void InitTabInfoList()
	{
	}

	private List<TabInfo> InitGuildSubTabs()
	{
		return null;
	}

	private void InitCallBackDic()
	{
	}

	private void InitToggleButton()
	{
	}

	private void InitFilterDic()
	{
	}

	private void SetBPTitleLabel()
	{
	}

	private void AddRankKillFilter()
	{
	}

	private void AddCSRankKillFilter()
	{
	}

	private void AddRankWinFilter()
	{
	}

	private void AddCSRankWinFilter()
	{
	}

	private void AddRankKDFilter()
	{
	}

	private void AddCSRankKDFilter()
	{
	}

	private void AddGuildActivityFilter()
	{
	}

	private void AddGuildHonorFilter()
	{
	}

	private void AddGuildWarIndividualFilter()
	{
	}

	private void AddGuildWarChampionshipGuildFilter()
	{
	}

	private void AddGuildWarGuildFilter()
	{
	}

	private void AddBadgesFilter()
	{
	}

	private void AddPVEFilter()
	{
	}

	private void AddHCFilter()
	{
	}

	private void AddPrimeFilter()
	{
	}

	private void AddWishListRankingFilter()
	{
	}

	private void CreateTabs()
	{
	}

	private void SwitchLadderLeaderBoard(bool ladderleaderboard)
	{
	}

	private void OnRankLadderMatch()
	{
	}

	private void OnCsRankLadderMatch()
	{
	}

	private void OnPeakTabClick()
	{
	}

	private void OnCsPeakTabClick()
	{
	}

	private void OnLimitedTimeRankLadderMatch(uint gameMode)
	{
	}

	private void OnPeriodicLadderMatch()
	{
	}

	private void OnRankWeaponPowerClick()
	{
	}

	private void OnCSRankWeaponPowerClick()
	{
	}

	private void OnRankKillTabClick()
	{
	}

	private void OnRankWinTabClick()
	{
	}

	private void OnRankKDTabClick()
	{
	}

	private void OnCSRankKillTabClick()
	{
	}

	private void OnCSRankWinTabClick()
	{
	}

	private void OnCSRankKDTabClick()
	{
	}

	private void OnHCRankTabClick()
	{
	}

	private void OnHCWorthTabClick()
	{
	}

	private void OnHCProfitTabClick()
	{
	}

	private void OnPrimeTabClick()
	{
	}

	private void OnWishListRankingTabClick()
	{
	}

	private void OnWishListWeekRankingTabClick()
	{
	}

	private void OnWishListMonthRankingTabClick()
	{
	}

	private bool IsWishListRankingFilter()
	{
		return false;
	}

	private void OnWishListWeekRankingSelected()
	{
	}

	private void OnWishListMonthRankingSelected()
	{
	}

	private void OnWishListRankingSelected(WishListLeaderboardPeriod period)
	{
	}

	private void CheckClanAreaInfoIsReady()
	{
	}

	private void OnGuildTabClick()
	{
	}

	private void OnGuildActiveTabClick()
	{
	}

	private void InitGuildActiveToggleAndWeekTips()
	{
	}

	private void OnPlayerClanStateChanged(object[] data)
	{
	}

	private void InitGuildWarGuildToggle()
	{
	}

	private void InitGuildWarChampionshipToggle()
	{
	}

	private void OnGuildHonorTabClick()
	{
	}

	private void OnGuildWarIndividualTabClick()
	{
	}

	private void OnGuildWarGuildTabClick()
	{
	}

	private void OnGuildWarChampionshipTabClick()
	{
	}

	private void OnElitePassTabClick()
	{
	}

	private void OnPVETimeLimitTabClick()
	{
	}

	private void OnPVEInfiniteTabClick()
	{
	}

	private void RefreshPveAwardBtn()
	{
	}

	private void InitFilterByConfig(Func<FilterData, List<PopMenuData>> func, string tabFilter, string defaultToggleDL = "")
	{
	}

	private void SetWishListToggleLabel(string locKey)
	{
	}

	private void SetWishListToggleLabel(GameObject labelRoot, string locKey)
	{
	}

	private void SetRuleBtnView(bool show)
	{
	}

	private List<PopMenuData> GenerateFilterData(FilterData filterData)
	{
		return null;
	}

	private void OnFilterSelected(object data)
	{
	}

	private void OnGuildHonorRegionFilterSelected(object data)
	{
	}

	private void OnGuildHonorGlobalFilterSelected(object data)
	{
	}

	private void OnGuildWeekTotalFilterSelected(object data)
	{
	}

	private void RefreshUI()
	{
	}

	private string BuildDeepLink()
	{
		return null;
	}

	private string GetDeepLink(DeepLinkLayer layer)
	{
		return null;
	}

	private void SetFilter(string filter1 = null, string filter2 = null, string filter3 = null, string filter4 = null)
	{
	}

	private void UpdateStyle()
	{
	}

	private void SetScrollViewPanelSize(float size)
	{
	}

	private int GetListBGWidth(EStyle style)
	{
		return 0;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void SelectDefaultTab()
	{
	}

	private IEnumerator DelayCreateUI(Action action = null)
	{
		return null;
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public override void OnNavigationClosed()
	{
	}

	private void NavigationToLeaderBoard()
	{
	}

	private void SetPopMenuData(DeepLinkLayer layer, string filter)
	{
	}

	private void OnPlayerFriendKillsSoloSelected()
	{
	}

	private void OnPlayerFriendKillsDuoSelected()
	{
	}

	private void OnPlayerFriendKillsTeamSelected()
	{
	}

	private void OnPlayerFriendWinsSoloSelected()
	{
	}

	private void OnPlayerFriendWinsDuoSelected()
	{
	}

	private void OnPlayerFriendWinsTeamSelected()
	{
	}

	private void OnPlayerFriendKDSoloSelected()
	{
	}

	private void OnPlayerFriendKDDuoSelected()
	{
	}

	private void OnPlayerFriendKDTeamSelected()
	{
	}

	private void OnPlayerRegionKillsSoloSelected()
	{
	}

	private void OnPlayerRegionKillsDuaSelected()
	{
	}

	private void OnPlayerRegionKillsTeamSelected()
	{
	}

	private void OnPlayerRegionWinsSoloSelected()
	{
	}

	private void OnPlayerRegionWinsDuoSelected()
	{
	}

	private void OnPlayerRegionWinsTeamSelected()
	{
	}

	private void OnPlayerRegionKDSoloSelected()
	{
	}

	private void OnPlayerRegionKDDuoSelected()
	{
	}

	private void OnPlayerRegionKDTeamSelected()
	{
	}

	private void OnPlayerFriendCSKillsSelected()
	{
	}

	private void OnPlayerFriendCSWinsSelected()
	{
	}

	private void OnPlayerFriendCSKDSelected()
	{
	}

	private void OnPlayerRegionCSKillsSelected()
	{
	}

	private void OnPlayerRegionCSWinsSelected()
	{
	}

	private void OnPlayerRegionCSKDSelected()
	{
	}

	private void RequestClanActiveLeaderBoard()
	{
	}

	private void OnGuildActiveRankSelectedBase()
	{
	}

	private void OnGuildActiveGlobalRankSelected()
	{
	}

	private void OnGuildActiveCountryRankSelected()
	{
	}

	private void OnGuildActiveCityRankSelected()
	{
	}

	private void OnGuildActiveProvinceRankSelected()
	{
	}

	private void OnGuildRegionWeekHonorSelected()
	{
	}

	private void OnGuildRegionTotalHonorSelected()
	{
	}

	private void OnGuildGlobalHonorSelected()
	{
	}

	private void OnGuildWarIndividual_RoundSelect(int round)
	{
	}

	private void OnGuildWarGuild_RoundSelect(ELeaderBoardTitleRegionType type, int round)
	{
	}

	private void OnGuildWarGuild_RegionSelect(int round)
	{
	}

	private void OnGuildWarChampionshipGuildCountrySelect()
	{
	}

	private void OnPlayerFriendBadgesSelected()
	{
	}

	private void OnPlayerRegionBadgesSelected()
	{
	}

	private void OnPlayerGlobalBadgesSelected()
	{
	}

	private void OnFriendPVEInfiniteDataSelected()
	{
	}

	private void OnRegionPVEInfiniteDataSelected()
	{
	}

	private void SetPVEItemDisplayType(uint leaderBoardMainType)
	{
	}

	private void OnFriendPVETimeLimitSelected()
	{
	}

	private void OnRegionPVETimeLimitSelected()
	{
	}

	private void OnRegionHCRankSelected()
	{
	}

	private void OnFriendHCRankSelectd()
	{
	}

	private void OnRegionHCWorthSelected()
	{
	}

	private void OnFriendHCWorthSelectd()
	{
	}

	private void OnRegionHCProfitSelected()
	{
	}

	private void OnFriendHCProfitSelectd()
	{
	}

	private void OnPrimeFriendMonthlySelected()
	{
	}

	private void OnPrimeFriendYearlySelected()
	{
	}

	private void OnPrimeFriendTotalSelected()
	{
	}

	private void OnPrimeRegionMonthlySelected()
	{
	}

	private void OnPrimeRegionYearlySelected()
	{
	}

	private void OnPrimeRegionTotalSelected()
	{
	}

	private void BeforeRequestData(int propID, uint boardV2ID = 0u)
	{
	}

	private void BeforeRequestWishListRanking()
	{
	}

	private void RequestFriendData(int propID, uint boardV2ID = 0u)
	{
	}

	private void RequestData(int propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true, uint boardV2ID = 0u)
	{
	}

	private void SwitchListTitle()
	{
	}

	private void SetWishListListTitle()
	{
	}

	private void SetListTitleLabel(UILabel label, string locKey)
	{
	}

	private void HideAllListTitle()
	{
	}

	private void RefreshListFriendPlayer()
	{
	}

	private void RefreshListGuildWarPlayer()
	{
	}

	private void RefreshListPlayer()
	{
	}

	private void RefreshListWishListRanking()
	{
	}

	private void RefreshListGuildActive()
	{
	}

	private void RefreshListGuild()
	{
	}

	private void RefreshListGuildWithInfo()
	{
	}

	private void SetSelfTipsInfoActive(bool show)
	{
	}

	public void OnWishListRankingItemSelected(WishListLeaderboardItem item)
	{
	}

	private void OnWishListGotoBtnClick()
	{
	}

	private void SetWishListGotoBtnState(bool show)
	{
	}

	public void OnWishListRankingGoToGet(WishListLeaderboardItem item)
	{
	}

	private void SetWishListRankingPreviewSource()
	{
	}

	private void RefreshWishListRankingPreview()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void SetItemBGInfo(UILeaderBoardItemNewController ctrl)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public int GetBGWidth1()
	{
		return 0;
	}

	public int GetBGWidth2()
	{
		return 0;
	}

	public int GetBGWidth3()
	{
		return 0;
	}

	public void SetBGLinePosY(bool isDefault)
	{
	}

	public void ShowLine(bool isShow)
	{
	}

	private void SetSeasonBtnState(bool show)
	{
	}

	private void SetCSSeasonBtnState(bool show)
	{
	}

	private void SetHCSeasonBtnState(bool show = false)
	{
	}

	private void SetPrimeBtnState(bool show = false)
	{
	}

	private void SetGuildWarGuildTips(bool show)
	{
	}

	private void SetGuildWarIndividualTips(bool show)
	{
	}

	private void SetAwardBtnState(bool show)
	{
	}

	private void SetShareBtnState(bool share1Show, bool share2Show)
	{
	}

	private void SetProfileBtnState(bool show)
	{
	}

	private void OnSeasonTipsBtnClick()
	{
	}

	private void OnAwardBtnClick()
	{
	}

	private void OnCSSeasonTipsBtnClick()
	{
	}

	private void OnHCSeasonTipsBtnClick()
	{
	}

	private void RefreshGuildWeekTips(uint refresh_time)
	{
	}

	private void RefreshGuildWeekTipsAndContentList()
	{
	}

	private void HideGuildWeekTipsInfo()
	{
	}

	private void AddPVETab()
	{
	}

	private void RefreshClanLeaderBoard()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnShareClick()
	{
	}

	private void OnProfileClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnLeaderBoardItemSelected(object[] param)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void TryShowPreviewAvatar(ulong accountID, bool isAnonymous = false)
	{
	}

	public void ShowAvatarLadderLeaderBoard(uint avatarID, List<uint> clothList, uint weaponID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, List<uint> checkOptionalIds = null, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unlockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needRefreshUI = true, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	private bool ShowAvatar(ulong accountID, bool isAnonymous = false)
	{
		return false;
	}

	private void ClearSelectedAccountID()
	{
	}

	public void ShowLoading(bool show)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public void ShowClanBriefBox(ClanInfo info)
	{
	}

	private void OnSlefQuickBtnClick()
	{
	}

	private void OnLocationBtnClick()
	{
	}

	private void ShowLocationWind()
	{
	}

	private void OnGuildWarGuildTipsClick()
	{
	}

	private void OnGuildWarIndividualTipsClick()
	{
	}

	public void ShowLaunchTag(bool show)
	{
	}

	public void TryShowLaunchTagData(List<ItemTagInfo> launchTagList)
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

	public void SetScrollToSelfBtnShow(bool show)
	{
	}

	private void OnScrollToSelfBtnClick()
	{
	}

	public int GetEasylistMaxCount()
	{
		return 0;
	}

	private void ChangeAvatarMaterial(UIMaleAvatar MaleAvatar)
	{
	}

	private void ApplyFresnelMaterial(UMAData umaData)
	{
	}

	private void _003CInitToggleButton_003Eb__200_0()
	{
	}

	private void _003CInitToggleButton_003Eb__200_1()
	{
	}

	private void _003CInitToggleButton_003Eb__200_2()
	{
	}

	private void _003CInitToggleButton_003Eb__200_3()
	{
	}

	private void _003CInitToggleButton_003Eb__200_4()
	{
	}

	private void _003CInitToggleButton_003Eb__200_5()
	{
	}

	private void _003CInitToggleButton_003Eb__200_6()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
