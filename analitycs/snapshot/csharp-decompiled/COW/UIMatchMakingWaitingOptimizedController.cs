using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMatchMakingWaitingOptimizedController : UIBaseController
{
	private enum MatchMakingTipsType
	{
		Estimate,
		OverTime,
		LongTimeTips
	}

	private UIMatchMakingWaitingOptimizedView m_View;

	private float m_Time;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelGroup m_ModelGroup;

	private UIGroupWaitingDropItem m_DragDropItem;

	public Action OnCancel;

	private float m_EstimateTime;

	private bool m_EstimateLabelDirty;

	private bool m_ShowFriendSpectator;

	private const string ACCELERATE_MATCHING_KEY = "T_43_TSY_SPEED_UP_MATCHMAKING";

	private const string CSPEAK_MATCHMAKING_TIPS_KEY = "T_52_TSY_PEAK_MMWATING_TIPS_2";

	private const string FRIEND_SPECTATE_MATCHMAKING_KEY = "T_43_TT_SPECTATE_WAITTING";

	private const string LOBBY_SOCIAL_AREA_MATCHMAKING_KEY = "T_54_JC_SOCIALHUB_FINDINGPLAYER";

	private readonly Dictionary<uint, string> m_MatchReasonTextKeyDict;

	private readonly List<object> m_MatchMakingTipsObjectList;

	private readonly List<MatchmakingTipsNewDesc> m_MatchmakingTipsDescList;

	private readonly List<UIPostMatchTeammateItemController> m_UITeammateItemCtrls;

	private MutableString m_CountStr;

	private UIModelMatch m_ModelMatch;

	private uint m_DelayForceShowCancleBtn;

	private uint m_InstantSurveyDelayCall;

	private UIHudMatchResultInstantSurveyBoxController m_InstantSurveyCtrl;

	private uint m_InstantSurveyGameMode;

	private uint m_InstantSurveyMatchMode;

	private bool m_WaitingInstantSurveyData;

	private bool m_IsCSPeakMode;

	private bool m_IsLobbySocialAreaMode;

	private uint m_LobbySocialAreaAlphaDelayCall;

	private float m_WaitingOptimizedDefaultAlpha;

	private bool m_HasSetLobbySocialAreaAlpha;

	private bool m_HasPlayMatchMakingSound;

	private int m_UpdateSecond;

	private MatchMakingTipsType MatchMakingTipsState => MatchMakingTipsType.Estimate;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void PrepareFixTimeCarouselData()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ChangeUseSpecialCameraRenderHangOutUI(object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void ScheduleInstantSurvey(uint gameMode, uint matchMode)
	{
	}

	private void TryOpenInstantSurvey(uint gameMode, uint matchMode)
	{
	}

	private bool ShouldBlockInstantSurveyByInvitationTips()
	{
		return false;
	}

	private void OnInstantSurveyDataUpdate()
	{
	}

	private void CloseInstantSurvey()
	{
	}

	private void CancelInstantSurveyDelayCall()
	{
	}

	public void InitDrag()
	{
	}

	private Vector2 GetBound()
	{
		return default(Vector2);
	}

	private void Update()
	{
	}

	public void CheckAndRefreshTeammateItems()
	{
	}

	public void RefreshTeammateItems()
	{
	}

	public void OnBtnCancel()
	{
	}

	private void SetVeteranlogs()
	{
	}

	public void SetTime(uint time)
	{
	}

	public void SetEstimateTime(uint time, bool getTime = true)
	{
	}

	public void ChangeEstimateTimeLabel()
	{
	}

	public void ShowCancelBtn(object[] data)
	{
	}

	public bool IsShowTeammatesList()
	{
		return false;
	}

	public void SetFriendSpectate(bool isFriendSpectate)
	{
	}

	private void SetMatchMakingCancelLogs()
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	public bool IsDragging()
	{
		return false;
	}

	public void SetMatchWatingBg(uint gameMode, uint matchMode)
	{
	}

	private void TryPlayMatchMakingSound(uint gameMode)
	{
	}

	private void UpdateLobbySocialAreaMatchMakingAlpha(uint gameMode)
	{
	}

	private void RestoreLobbySocialAreaMatchMakingAlpha()
	{
	}

	private void CancelLobbySocialAreaAlphaDelayCall()
	{
	}

	private IFixTimeCarouselItem CarouselItemControllerGenerator(Transform carouselContainer)
	{
		return null;
	}

	private void PrepareFixTimeCarousel()
	{
	}

	private void PlayFixTimeCarousel()
	{
	}

	public void SetMatchMakingTips(uint gameMode, uint matchMode)
	{
	}

	public void RefreshRematchMatchMakingState()
	{
	}

	public void RefreshRematchInfo(uint reasonKey = 0u)
	{
	}

	private void _003CScheduleInstantSurvey_003Eb__40_0()
	{
	}

	private void _003CSetEstimateTime_003Eb__55_0()
	{
	}

	private void _003CUpdateLobbySocialAreaMatchMakingAlpha_003Eb__65_0()
	{
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
