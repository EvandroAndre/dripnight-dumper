using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudMatchResultInstantSurveyController : UIPopupWindowController
{
	private const int SCORE_RANGE_MIN = 1;

	private const int SCORE_RANGE_MAX = 5;

	private const int SCORE_OKAY_VALUE = 3;

	private const int ANSWER_VALUE_YES = 1;

	private const int ANSWER_VALUE_NO = 2;

	private UIHudMatchResultInstantSurveyView m_View;

	private UIModelInstantSurvey m_Model;

	private EQuickFeedbackTriggerScene m_Scene;

	private uint m_GameMode;

	private uint m_MatchMode;

	private UIModelInstantSurvey.QuickFeedbackQuestionGroup m_CurrentQuestionGroup;

	private QuickFeedbackQuestDesc m_CurrentQuestion;

	private readonly List<UIHudMatchResultInstantSurveyScoreItemController> m_ScoreItemCtrls;

	private readonly HashSet<uint> m_AskedQuestionIdsThisSession;

	private readonly HashSet<uint> m_AnsweredQuestionIdsThisSession;

	private readonly List<EventLogger.QuickFeedbackAnswerRecord> m_AnswerRecordsThisSession;

	private int m_SelectedScore;

	private bool m_Submitting;

	private uint m_AutoCloseDelayCall;

	private uint m_AnswerVFXDelayCall;

	private uint m_CloseDelayCall;

	private bool m_HasStarted;

	private bool m_IsAutoCloseTimerShowing;

	private bool m_SurveyAutoCloseStarted;

	private float m_AutoCloseDuration;

	private float m_AutoCloseElapsedTime;

	private int m_LastAutoCloseDisplaySeconds;

	private bool m_HasExpired;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void Update()
	{
	}

	public bool SetData(EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode)
	{
		return false;
	}

	public void SetContentDepth(int depth)
	{
	}

	private bool SetDataInternal(EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode, bool ensureDataReady, bool recordPopupShown)
	{
		return false;
	}

	private void PlayInAnimation()
	{
	}

	private void BuildScoreItems()
	{
	}

	private void RefreshCurrentQuestion()
	{
	}

	private void OnClickScore(int score)
	{
	}

	private void OnClickYes()
	{
	}

	private void OnClickNo()
	{
	}

	private void StartAnswerVFXAndSubmit(int answerValue, UIHudMatchResultInstantSurveyScoreItemController scoreItemCtrl, GameObject optionUIFX)
	{
	}

	private bool RecordCurrentQuestionAnswer(int answerValue)
	{
		return false;
	}

	private void MoveToNextQuestionAfterAnswer()
	{
	}

	private void ShowFinish()
	{
	}

	private void OnClickClose()
	{
	}

	public void OnTipsBoxClose()
	{
	}

	private void PlayOutAnimation()
	{
	}

	private void CloseSelfOrParentBox()
	{
	}

	private void SetSurveyMaskActive(bool active)
	{
	}

	private void ScheduleNoAnswerAutoClose(QuickFeedbackQuestDesc question)
	{
	}

	private void CancelAutoClose()
	{
	}

	private void CancelAnswerVFXDelay()
	{
	}

	private void CancelCloseDelay()
	{
	}

	private void StartAutoCloseTimer(float duration)
	{
	}

	private void StopAutoCloseTimer()
	{
	}

	private void RefreshAutoCloseTimer()
	{
	}

	private int GetAutoCloseDisplaySeconds()
	{
		return 0;
	}

	private void StopAnswerVFX()
	{
	}

	private static void PlayVFX(VFXCreateHelper helper)
	{
	}

	private static void StopVFX(VFXCreateHelper helper)
	{
	}

	private static void PlayUIFX(GameObject uiFX)
	{
	}

	private static void StopUIFX(GameObject uiFX)
	{
	}

	private void RecordQuestionAnswer(QuickFeedbackQuestDesc question, int answerValue)
	{
	}

	private void SendCurrentSessionLog()
	{
	}

	private uint GetCurrentStageForLog()
	{
		return 0u;
	}

	private ulong GetCurrentMatchIdForLog()
	{
		return 0uL;
	}

	private void _003CStartAnswerVFXAndSubmit_003Eb__42_0()
	{
	}

	private void _003CPlayOutAnimation_003Eb__48_0()
	{
	}

	private void _003CScheduleNoAnswerAutoClose_003Eb__51_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
