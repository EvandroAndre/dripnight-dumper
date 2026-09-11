using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipController : UINavigationController, IUIModelDataChangeObserver
{
	public enum EPage
	{
		Main,
		Team,
		Ladder
	}

	public enum ETeamSubPage
	{
		Info,
		Reward
	}

	public class LeaderBoardEasyList : IEasyList
	{
		private UIChampionshipController championshipController;

		public uint championshipType;

		public LeaderBoardEasyList(UIChampionshipController championshipController)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<uint, string> _003C_003E9__76_0;

		internal string _003COnSeasonTipsBtnClick_003Eb__76_0(uint day)
		{
			return null;
		}
	}

	private UIChampionshipView m_View;

	protected UIModelChampionship m_ModelChampionship;

	protected ChampionshipInfo m_ChampionshipInfo;

	protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	protected uint m_ChampionshipType;

	private MapOpeningInfo m_MapInfo;

	private uint m_BtnBGGrey;

	protected uint m_ChampionshipID;

	private bool m_NeedUpdateCSInfo;

	private Color m_StartBtnColor;

	private UINavigationData m_LastNavigationData;

	private UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

	private List<Transform> m_RewardContainerList;

	private List<Transform> m_NewRewardContainerList;

	private List<Transform> m_RewardParentContainerList;

	private List<Transform> m_ChampionshipRewardContainerList;

	private int m_LastRankPos;

	private bool m_NeedPlayRewardAnim;

	private bool m_TransitionAnimFinish;

	private LeaderBoardEasyList m_LeaderBoardEasyList;

	private UIChampionshipLeaderBoardItem m_LeaderBoardSelfItem;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

	private bool m_FromJoinBtn;

	private bool m_TeamTabClickLogged;

	private string m_MatchStateClockTips;

	private EPage m_CurSelectPage;

	private UIChampionshipTeamProfileSelfController m_TeamProfileSelfCtrl;

	private UICountDownController m_MatchOpenCountDownCtrl;

	private Dictionary<int, UIToggleButton> m_StateBtnDict;

	private string[] m_DayInWeekStrDict;

	private const float VFX_BLINK_DURATION = 2.15f;

	private bool m_IsMatchEnd;

	private bool m_IsTeamMode;

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

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void InitRewardContainer()
	{
	}

	private void InitLookUpDict()
	{
	}

	private void CreateTabs()
	{
	}

	private void CreateTeamPage()
	{
	}

	public UIChampionshipTeamProfileSelfController GetTeamCtrl()
	{
		return null;
	}

	private void RefreshView()
	{
	}

	private void RefreshMatchStateInfo()
	{
	}

	private void RefreshMainPageInfo()
	{
	}

	private void UpdateTabRedPoint()
	{
	}

	protected void SetCDNBG()
	{
	}

	private void RequestLeaderBoardFriend(bool force)
	{
	}

	private void RequestLeaderBoardRegion(bool force)
	{
	}

	private void RefreshLeardBoard()
	{
	}

	private void RefreshSelfLeardBoard()
	{
	}

	private void RefreshGameResult()
	{
	}

	private void RefreshSeasonInfo()
	{
	}

	protected virtual void RefreshCupIcon()
	{
	}

	private void RefreshRankReward()
	{
	}

	private void SetRankReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, List<Transform> parentContainerList = null)
	{
	}

	private bool CheckRankRangUp(int rankBefore, int rankNow)
	{
		return false;
	}

	private void RefreshPosReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, List<Transform> parentContainerList = null)
	{
	}

	private void SetStartMatchBtnState()
	{
	}

	private void SetMainPageTeamBtnState()
	{
	}

	private string CheckCanStartMatch()
	{
		return null;
	}

	private void RefreshNoticeBtn()
	{
	}

	private bool ShowNotice()
	{
		return false;
	}

	protected virtual void AutoShowNotice()
	{
	}

	private void ShowNoticeWnd()
	{
	}

	private void SetCDNUrlList(List<string> cdnList, string url)
	{
	}

	private void RefreshChampionReward()
	{
	}

	private void OnStartMatchBtnClick()
	{
	}

	private void OnShowAllRewardBtnClick()
	{
	}

	private void OnSeasonTipsBtnClick()
	{
	}

	private void OnNoticyBtnClick()
	{
	}

	private void OnMapModeSelecteSuccess(object[] param)
	{
	}

	private void AnimationEventHandler(object[] data)
	{
	}

	public void OnBtnMainPageClick()
	{
	}

	public void OnBtnTeamPageClick()
	{
	}

	public void OnBtnLadderPageClick()
	{
	}

	public void OnBtnMainPageSignUpClick()
	{
	}

	private void ShowChampionshipRecruitWnd(object[] param)
	{
	}

	private void GotoTeamPage()
	{
	}

	private void GotoLadderPage()
	{
	}

	private void ShowMainPage()
	{
	}

	private void ShowTeamPage()
	{
	}

	private void ShowLadderPage()
	{
	}

	private void OnBtnRecuitClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__40_0(UIToggleButton e)
	{
	}

	private void _003CCreateTeamPage_003Eb__47_0()
	{
	}

	private string _003CRefreshMainPageInfo_003Eb__51_0(uint item)
	{
		return null;
	}

	private void _003COnStartMatchBtnClick_003Eb__74_0()
	{
	}

	private void _003COnStartMatchBtnClick_003Eb__74_1()
	{
	}

	private void _003COnStartMatchBtnClick_003Eb__74_2()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
