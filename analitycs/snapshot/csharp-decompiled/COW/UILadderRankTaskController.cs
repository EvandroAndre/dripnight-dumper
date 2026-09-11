using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UILadderRankTaskController : UIPreviewBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<StandardTabItemViewData> _003C_003E9__47_0;

		public static Predicate<StandardTabItemViewData> _003C_003E9__47_2;

		public static Predicate<StandardTabItemViewData> _003C_003E9__47_4;

		internal bool _003CGetTabIndexAndSubIndexByTaskSubTab_003Eb__47_0(StandardTabItemViewData x)
		{
			return false;
		}

		internal bool _003CGetTabIndexAndSubIndexByTaskSubTab_003Eb__47_2(StandardTabItemViewData x)
		{
			return false;
		}

		internal bool _003CGetTabIndexAndSubIndexByTaskSubTab_003Eb__47_4(StandardTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public ELadderRankTaskSubTab subtab;

		internal bool _003CGetTabIndexAndSubIndexByTaskSubTab_003Eb__1(StandardSubTabItemViewData x)
		{
			return false;
		}

		internal bool _003CGetTabIndexAndSubIndexByTaskSubTab_003Eb__3(StandardSubTabItemViewData x)
		{
			return false;
		}
	}

	private UILadderRankTaskView m_View;

	private UIModelPeriodicLadderMatch m_UIModelPeriodicLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisisLadderMatch;

	private ELadderRankTaskSubTab m_CurSubTab;

	private ELadderRankTaskSubTab m_CurPreviewRankTab;

	private UIStandardDrawerTabRemakeController m_TabCtrl;

	private UICountDownController m_CDController;

	private UILadderMatchSeasonSwitchController m_SeasonSwtichCtrl;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private List<StandardSubTabItemViewData> m_WinRewardTabDataList;

	private List<StandardSubTabItemViewData> m_PreviewRewardTabDataList;

	private List<uint> m_BRCanClaimStages;

	private List<uint> m_CSCanClaimStages;

	private List<WinRewardData> m_BRWinRewardDataList;

	private List<WinRewardData> m_CSWinRewardDataList;

	private List<UILadderWinRewardItemController> m_WinRewardItems;

	private bool m_NeedForceRefeshPreview;

	private bool m_IsBRWinPassOpen;

	private bool m_IsCSWinPassOpen;

	private ERanking.WinPassType m_BRWinPassType;

	private ERanking.WinPassType m_CSWinPassType;

	private bool m_IsRankMatchUnlock;

	private int m_FirstCupUIFXLevel;

	private int m_SecondCupUIFXLevel;

	private int m_FinalCupUIFXLevel;

	public Vector2 RankRewardSize;

	public Vector2 KickOffSize;

	public UITable2.Margin PreviewRewardMargin;

	public UITable2.Margin KickOffMargin;

	private UITable2.Item m_CurPrevScrollKickOffItem;

	private UILadderKickOffRewardItemController m_KickOffCtrl;

	private string m_TitleTipsDesc;

	private int m_BRWinPassOpenSeasonID;

	private int m_CSWinPassOpenSeasonID;

	private UICSPeakTournamentTaskRewardController m_CSPeakTournmentTaskRewardCtrl;

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

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnVisibilityChanged()
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

	public bool IsPreviewHiding()
	{
		return false;
	}

	public void RecoverPreviewByCondition()
	{
	}

	private void GotoTab(ELadderRankTaskSubTab subtab)
	{
	}

	private void GetTabIndexAndSubIndexByTaskSubTab(ELadderRankTaskSubTab subtab, ref int tabIndex, ref int subTabIndex)
	{
	}

	private void ShowPreviewItem(object[] data)
	{
	}

	private void SetLadderMatchlockView(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}

	private void OnClickTitleTipsBtn()
	{
	}

	private void OnClickGotoRankSystemBtn()
	{
	}

	private void CreateLeftTab()
	{
	}

	private void CreateWinPassTab()
	{
	}

	private void CreateRankRewardTab()
	{
	}

	private void CreateCSPeakRewardTab()
	{
	}

	private void OnSelectTab(ELadderRankTaskSubTab subTab)
	{
	}

	private void SetWinPassTitleByType(ERanking.WinPassType winPassType, DLBMPCCFKKM matchMode)
	{
	}

	private void SetTitleLabel(string title)
	{
	}

	private void ShowNormalPage(bool isWinReward)
	{
	}

	private void SetBRCountDownView()
	{
	}

	private void SetCSCountDownView()
	{
	}

	private void SetPeriodicTitleAndCountDownView()
	{
	}

	private void SetHippoCrisisTitleAndCountDownView()
	{
	}

	private void ShowSeasonSwtichContainer()
	{
	}

	private void ShowSeasonSwtichPage(DLBMPCCFKKM matchmode, bool isWinPassPage = false)
	{
	}

	private bool CheckIsBRSeasonSwitchState()
	{
		return false;
	}

	private bool CheckIsCSSeasonSwitchState()
	{
		return false;
	}

	private void OnRankUPRewardTipsBtnClick()
	{
	}

	private void InitTable2Template()
	{
	}

	private void RefreshRankRewardTitle(bool isShowFirstRankTitle)
	{
	}

	private void OnPreviewRewardScrollMoving()
	{
	}

	private void RefreshBRPreviewRewardView(bool needRefesh = false)
	{
	}

	private void RefreshCSPreviewRewardView(bool needRefresh = false)
	{
	}

	private void RefreshPeriodicPreviewRewardView(bool needRefresh = false)
	{
	}

	private void RefreshHippoCrisisPreviewRewardView(bool needRefresh = false)
	{
	}

	private void BuildTable2(int displayIndex)
	{
	}

	private void ShowWinPassPreheatView(DLBMPCCFKKM matchmode, int openSeasonID)
	{
	}

	private bool CheckNeedShowBRWinPassPreheat()
	{
		return false;
	}

	private bool CheckNeedShowCSWinPassPreheat()
	{
		return false;
	}

	private void OnWinRewardClaimBtnClick()
	{
	}

	private void OnWinRewardGotoBtnClick()
	{
	}

	private void SetBRWinPassView()
	{
	}

	private void SetBRWinRewardBtnView()
	{
	}

	private void SetCSWinPassView()
	{
	}

	private void SetCupUIFXByProcess(uint process)
	{
	}

	private void SetCSWinRewardBtnView()
	{
	}

	private void RefreshWinPass(List<WinRewardData> winRewardDatas)
	{
	}

	private void ResetWinPassSelectedState(object[] data)
	{
	}

	private void OnWinCupTipsBtnClick()
	{
	}

	private void RefreshCSPeakRewardView(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}

	private void HideCSPeakRewardView()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__38_0()
	{
	}

	private void _003CCreateWinPassTab_003Eb__53_0()
	{
	}

	private void _003CCreateWinPassTab_003Eb__53_1()
	{
	}

	private void _003CCreateRankRewardTab_003Eb__54_0()
	{
	}

	private void _003CCreateRankRewardTab_003Eb__54_1()
	{
	}

	private void _003CCreateRankRewardTab_003Eb__54_2()
	{
	}

	private void _003CCreateRankRewardTab_003Eb__54_3()
	{
	}

	private void _003CCreateCSPeakRewardTab_003Eb__55_0()
	{
	}

	private void _003CSetBRCountDownView_003Eb__60_0()
	{
	}

	private void _003CSetBRCountDownView_003Eb__60_1()
	{
	}

	private void _003CSetCSCountDownView_003Eb__61_0()
	{
	}

	private void _003CSetCSCountDownView_003Eb__61_1()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__69_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__69_1()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
