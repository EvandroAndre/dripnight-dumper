using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIModelBRTutorialTask : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UIModelBRTutorialTask _003C_003E4__this;

		public uint nextPhaseId;

		internal void _003CSchedulePhaseSwitch_003Eb__0()
		{
		}
	}

	public const uint PropID_TaskStateChanged = 2u;

	public const uint PropID_TaskCompleted = 4u;

	private const int RequiredEquipmentLevel = 3;

	private const float FinalTaskPhaseSwitchDelay = 1.2f;

	private readonly BRTutorialTaskConfig m_TaskConfig;

	private readonly HashSet<uint> m_CompletedTasks;

	private readonly HashSet<uint> m_PendingCompletedTasks;

	private uint m_CurrentPhaseId;

	private uint m_PendingPhaseSwitchDelayId;

	private uint m_PendingPhaseSwitchFromPhaseId;

	private uint m_PendingPhaseSwitchToPhaseId;

	private bool m_IsTaskFeatureActive;

	private bool m_IsEventRegistered;

	private EventDispatcher m_RegisteredEventDispatcher;

	public override uint GetModelType()
	{
		return 0u;
	}

	public string GetPhaseTitle(uint phaseId)
	{
		return null;
	}

	public string GetTaskDescription(uint taskId)
	{
		return null;
	}

	public bool TryMatchTrigger(EBRTutorialTaskTriggerType triggerType, out uint taskId)
	{
		taskId = default(uint);
		return false;
	}

	public int GetTaskProgressCount(uint taskId)
	{
		return 0;
	}

	private static int GetEquippedPrimaryWeaponCount()
	{
		return 0;
	}

	public bool TryGetCurrentPhaseContent(List<uint> uncompletedTasks, out uint phaseId)
	{
		phaseId = default(uint);
		return false;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void OnLocalMapMarkChanged(EILKGGIDJEH markPointType)
	{
	}

	private void OnTreasuryStateUpdated(object[] param)
	{
	}

	private bool TryMatchLocalMapMarkTask(EILKGGIDJEH markPointType, out uint taskId)
	{
		taskId = default(uint);
		return false;
	}

	public void ResetForMatchStart()
	{
	}

	public void StartTaskFeature()
	{
	}

	private void ResetTaskState()
	{
	}

	private void OnLocalPlayerLanding(object[] data)
	{
	}

	private void OnBigMapVisibilityChange(object[] data)
	{
	}

	private void OnEquipmentEquipStateChanged(GEvent data)
	{
	}

	private void OnInGameShopBuyResult(int buyResult)
	{
	}

	private void CheckEquipmentTaskCompletion()
	{
	}

	private static bool IsEquipmentTaskSlot(HDAEFOANBGJ slot)
	{
		return false;
	}

	private static OMELKCOGCBK GetLocalInventoryManager()
	{
		return null;
	}

	private static int GetEquippedItemLevel(OMELKCOGCBK inventoryManager, HDAEFOANBGJ slot)
	{
		return 0;
	}

	private static bool IsSuccessfulInGameShopBuyResult(JMHFAMKMIOB result)
	{
		return false;
	}

	private void CompleteTutorialTaskByTrigger(EBRTutorialTaskTriggerType triggerType)
	{
	}

	private void CompleteTutorialTask(uint taskId)
	{
	}

	private void SetTaskPhase(uint phaseId)
	{
	}

	private void SchedulePhaseSwitch(uint nextPhaseId, float delaySeconds)
	{
	}

	private void RequestPhaseSwitch(uint nextPhaseId)
	{
	}

	private void OnPhaseSwitchReady(object[] data)
	{
	}

	private static bool TryGetPhaseSwitchEventData(object[] data, out uint fromPhaseId, out uint nextPhaseId)
	{
		fromPhaseId = default(uint);
		nextPhaseId = default(uint);
		return false;
	}

	private void CancelPendingPhaseSwitch()
	{
	}

	private bool ShouldWaitForLandingBeforePhaseSwitch(uint nextPhaseId)
	{
		return false;
	}

	private bool ShouldIgnoreOutOfPhaseTaskCompletion(uint taskId)
	{
		return false;
	}

	private bool IsPostLandingPhase(uint phaseId)
	{
		return false;
	}

	private uint GetPostLandingPhaseOrInvalid()
	{
		return 0u;
	}

	private bool TrySwitchToPostLandingPhase()
	{
		return false;
	}

	public static bool IsLocalPlayerLanded()
	{
		return false;
	}

	private bool AreAllPhaseTasksCompleted(uint phaseId)
	{
		return false;
	}

	private bool IsTaskInPhase(uint phaseId, uint taskId)
	{
		return false;
	}

	private void CompletePendingTasksForCurrentPhase()
	{
	}

	private void RegisterGameEvents()
	{
	}

	private void UnregisterGameEvents()
	{
	}

	private void ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
