using System.Collections.Generic;
using COW.GamePlay;

namespace COW.Gameplay.UGC;

public class UGCTutorialFlowManager
{
	private const string TASK_COMPLETE_HINT_LOC_KEY = "T_54_XJ_NEWBIE_TASK_COMP";

	private UGCTutorialSequenceData m_SequenceData;

	private UGCTutorialGuideManager m_GuideManager;

	private UGCTutorialRestrictionManager m_RestrictionManager;

	private UGCTutorialAtomicTaskBase m_CurrentAtomicTask;

	private int m_LevelIndex;

	private int m_TaskIndex;

	private int m_AtomicIndex;

	private bool m_IsRunning;

	private bool m_IsSequenceComplete;

	private bool m_AvoidSendEventLog;

	private bool m_TaskAcceptLogged;

	private float m_TaskAcceptedRealtime;

	private float m_TaskAccumulatedDialogueSec;

	private bool m_InDialoguePhase;

	private float m_DialoguePhaseStartRealtime;

	private int m_DelayDialogue;

	private uint m_TaskCompletePresentationDelayCallId;

	private bool m_IsWaitingTaskCompletePresentation;

	private Dictionary<string, UGCTutorialContextData> m_ContextStore;

	public UGCTutorialGuideManager GuideManager => null;

	public UGCTutorialRestrictionManager RestrictionManager => null;

	public bool IsRunning => false;

	public int CurrentLevelIndex => 0;

	public int CurrentTaskIndex => 0;

	public int CurrentAtomicIndex => 0;

	public int DelayDialogue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool AvoidSendEventLog
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(UGCTutorialSequenceData data)
	{
	}

	public void StartFlow()
	{
	}

	public void Dispose()
	{
	}

	private void StartCurrentAtomicTask()
	{
	}

	private void CacheCurrentLevelConfigForLoading()
	{
	}

	private void ApplyCameraPoseForCurrentTask(UGCTutorialAtomicTaskData atomicData)
	{
	}

	private void ApplyCameraPose(UGCTutorialCameraPoseData pose, string taskId)
	{
	}

	private bool TryParseCameraMode(string value, out BJJBCNEJPEF mode)
	{
		mode = default(BJJBCNEJPEF);
		return false;
	}

	private bool TryParseCameraProjection(string value, out DEEMJPOOMMK projection)
	{
		projection = default(DEEMJPOOMMK);
		return false;
	}

	private bool StringEquals(string a, string b)
	{
		return false;
	}

	private void OnAllBlockingGuidesComplete()
	{
	}

	private void OnAtomicTaskComplete()
	{
	}

	private void AdvanceToNext()
	{
	}

	private void AdvanceToNext(UGCTutorialAtomicTaskData completedData)
	{
	}

	private bool HasNextTaskInCurrentLevel()
	{
		return false;
	}

	private bool ShouldSkipTaskCompletePresentation(UGCTutorialAtomicTaskData completedData)
	{
		return false;
	}

	private void StartTaskCompletePresentation()
	{
	}

	private void FinishTaskCompletePresentation()
	{
	}

	private void CancelTaskCompletePresentationDelay()
	{
	}

	private void CancelTaskCompletePresentationDelayOnly()
	{
	}

	private void CompleteCurrentTaskAndAdvance()
	{
	}

	private void OnLevelComplete()
	{
	}

	private void OnSequenceComplete()
	{
	}

	private void ApplyLevelDefaultTab()
	{
	}

	private void SaveProgress()
	{
	}

	private void NotifyTaskCompleteHintChanged()
	{
	}

	private void NotifyTaskHintChanged()
	{
	}

	private string GetLocalizedHint(string locKey)
	{
		return null;
	}

	private void DispatchTaskHintChanged(string hint, bool isTaskComplete)
	{
	}

	private UGCTutorialLevelData GetLevelData(int levelIndex)
	{
		return null;
	}

	private UGCTutorialTaskData GetTaskData(int levelIndex, int taskIndex)
	{
		return null;
	}

	private UGCTutorialAtomicTaskData GetAtomicTaskData(int levelIndex, int taskIndex, int atomicIndex)
	{
		return null;
	}

	public UGCTutorialLevelData GetCurrentLevel()
	{
		return null;
	}

	public UGCTutorialTaskData GetCurrentTask()
	{
		return null;
	}

	public UGCTutorialAtomicTaskData GetCurrentAtomicTask()
	{
		return null;
	}

	public UGCTutorialAtomicTaskData GetNextAtomicTaskData()
	{
		return null;
	}

	private void CollectOutputContext(UGCTutorialAtomicTaskBase task)
	{
	}

	private void OnTaskAccepted()
	{
	}

	private void OnTaskCompleted()
	{
	}

	private void SendMidExitEventLogIfNeeded()
	{
	}

	private void OnDialoguePhaseStart()
	{
	}

	private void OnDialoguePhaseEnd()
	{
	}

	private uint ComputeCurrentTaskDurationSeconds()
	{
		return 0u;
	}

	private string GetCurrentLevelIdString()
	{
		return null;
	}

	private string GetCurrentTaskIdString()
	{
		return null;
	}

	private void InjectInputContext(UGCTutorialAtomicTaskBase task, UGCTutorialAtomicTaskData data)
	{
	}
}
