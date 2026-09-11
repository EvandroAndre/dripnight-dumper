using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchController : UINavigationController, IUIModelDataChangeObserver
{
	public enum EPage
	{
		None = -1,
		Main,
		Team,
		Course,
		Accomplished
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<uint, string> _003C_003E9__73_0;

		internal string _003COnSeasonTipsBtnClick_003Eb__73_0(uint day)
		{
			return null;
		}
	}

	private UICupMatchView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	private CupOpenInfoDesc m_CupOpenInfo;

	private CupSettingDesc m_CupSettingInfo;

	private CupCDNSettingDesc m_CupCDNSetting;

	private MapOpeningInfo m_MapInfo;

	private uint m_CupMatchType;

	private uint m_BtnBGGrey;

	private uint m_CupMatchID;

	private int m_CupMatchKey;

	private bool m_NeedUpdateTeamInfo;

	private bool m_AccomplisedPage;

	private Color m_StartBtnColor;

	private UINavigationData m_LastNavigationData;

	private UIModelCupMatch.CupMatchOpenState m_CupMatchState;

	private List<Transform> m_RewardContainerList;

	private bool m_IsTeamMode;

	private bool m_FromJoinBtn;

	private bool m_TeamTabClickLogged;

	private EPage m_CurSelectPage;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

	private UICupMatchTeamProfileSelfController m_TeamProfileSelfCtrl;

	private UICupMatchCoursePageController m_CoursePageCtrl;

	private UICupMatchAccomplishedController m_AccomplishedCtrl;

	private Dictionary<int, UIToggleButton> m_StateBtnDict;

	private string[] m_DayInWeekStrDict;

	private const float VFX_BLINK_DURATION = 2.15f;

	private const string ACCOMPLISHED_KEY = "T_31_ZZ_ACCOMPLISHED_BTN";

	private const string COURSE_KEY = "T_31_ZZ_COURSE_BTN";

	private const string MAIN_TAB_NAME = "T_24_T_CS_INDEX1";

	private const string TEAM_TAB_NAME = "T_24_T_CS_INDEX2";

	private const string COURSE_TAB_NAME = "T_27_XC_CUP_INDEX_SCHEDULE";

	private List<StandardTabItemViewData> m_MainTabDataList;

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

	private void SetTierInfo()
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

	private void CreateCoursePage()
	{
	}

	private void CreateAccomplishedPage()
	{
	}

	private void RefreshView()
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

	private void RefreshSeasonInfo()
	{
	}

	protected virtual void RefreshCupIcon()
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

	private bool IsShowNotice()
	{
		return false;
	}

	protected virtual void AutoShowNotice()
	{
	}

	private void ShowNoticeWnd()
	{
	}

	private bool IsNoticShow()
	{
		return false;
	}

	private void SetCDNUrlList(List<string> cdnList, string url)
	{
	}

	private void RefreshTicket()
	{
	}

	private void RefreshCourseRedPoint()
	{
	}

	private void RefreshTeamRedPoint()
	{
	}

	public void RefreshFirstReward()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnStartMatchBtnClick()
	{
	}

	private void OnShowAllRewardBtnClick()
	{
	}

	private void OnBtnAccomplishedClick()
	{
	}

	private void ShowAllReward()
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

	public void OnBtnMainPageClick()
	{
	}

	public void OnBtnTeamPageClick()
	{
	}

	public void OnBtnCourseClick()
	{
	}

	private void ShowCupMatchRecruitWnd(object[] param)
	{
	}

	private void OnTicketClick(object[] param)
	{
	}

	public void GotoTeamPage()
	{
	}

	public void GotoPage(EPage page)
	{
	}

	private void ShowMainPage()
	{
	}

	private void ShowTeamPage()
	{
	}

	private void ShowCoursePage()
	{
	}

	private void ShowAccomplisedPage()
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

	private string _003CRefreshMainPageInfo_003Eb__49_0(uint item)
	{
		return null;
	}

	private bool _003CSetCDNBG_003Eb__51_0(AdvertDesc ad)
	{
		return false;
	}

	private void _003COnStartMatchBtnClick_003Eb__69_0()
	{
	}

	private void _003COnStartMatchBtnClick_003Eb__69_1()
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

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
