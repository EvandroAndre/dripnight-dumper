using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialTaskInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public uint taskId;

		internal bool _003CHasActiveTask_003Eb__0(HudTutorialTaskPayload t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public uint taskId;

		internal bool _003CTryPlayNextTaskCompletion_003Eb__0(HudTutorialTaskPayload t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public uint taskId;

		public UIHudTutorialTaskInfoController _003C_003E4__this;

		public int version;

		internal bool _003CPlayTaskCompletionAtIndex_003Eb__0(HudTutorialTaskPayload t)
		{
			return false;
		}

		internal void _003CPlayTaskCompletionAtIndex_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public uint taskId;

		internal bool _003CRemoveCompletedTaskFromHud_003Eb__0(HudTutorialTaskPayload t)
		{
			return false;
		}
	}

	private const uint InvalidPhaseId = 0u;

	private static readonly Color MainGoalDangerColor;

	private UIHudTutorialTaskInfoView m_View;

	private UIModelBRTutorialTask m_TutorialTaskModel;

	private readonly List<HudTutorialTaskPayload> m_ActiveTasks;

	private readonly List<UIHudTutorialTaskItemController> m_TaskItemControllers;

	private readonly Queue<uint> m_PendingCompletionTasks;

	private readonly List<uint> m_UncompletedTaskBuffer;

	private int m_CompletionPresentationVersion;

	private bool m_EnableHud;

	private bool m_PickupListBlocksGoals;

	private bool m_BigMapBlocksGoals;

	private bool m_IsPlayingCompletion;

	private uint m_PlayingCompletionTaskId;

	private uint m_InterruptedCompletionTaskId;

	private bool m_AutoCollapseAfterCompletionBatch;

	private bool m_UserExpanded;

	private bool m_PhasePanelClosedAfterAllTasksCompleted;

	private Color m_MainLabelDefaultColor;

	private string m_LocMainInSafe;

	private string m_LocMainOutside;

	private uint m_AutoCollapseDelayId;

	private uint m_CurrentPhaseId;

	private uint m_PendingPhaseSwitchFromPhaseId;

	private uint m_PendingPhaseSwitchToPhaseId;

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

	public void SetHudEnabled(bool enabled)
	{
	}

	public void SetPhaseContent(uint phaseId, IList<uint> taskIds)
	{
	}

	public void MarkTaskCompleted(uint taskId)
	{
	}

	private bool HasPendingTaskCompletions()
	{
		return false;
	}

	private bool ShouldDeferPhaseSwitch()
	{
		return false;
	}

	private void RefreshFromTaskModel()
	{
	}

	private void OnPhaseSwitchRequest(object[] data)
	{
	}

	private void TryDispatchPendingPhaseSwitchReady()
	{
	}

	private void ClearPendingPhaseSwitchRequest()
	{
	}

	private static bool TryGetPhaseSwitchEventData(object[] data, out uint fromPhaseId, out uint nextPhaseId)
	{
		fromPhaseId = default(uint);
		nextPhaseId = default(uint);
		return false;
	}

	private void SetExpanded(bool expanded)
	{
	}

	private void OnClickToggleExpand()
	{
	}

	private bool HasPhaseContent()
	{
		return false;
	}

	private bool ShouldShowPhasePanel()
	{
		return false;
	}

	private void OnBigMapVisibilityChange(object[] data)
	{
	}

	private void OnEnterPickupArea(GEvent data)
	{
	}

	private void OnExitPickupArea(object[] data)
	{
	}

	private void SyncPickupListBlockState()
	{
	}

	private bool IsPickupListPanelShowing()
	{
		return false;
	}

	private void OnSafeZoneCheckDamageChange(object[] data)
	{
	}

	private void OnGoalGateChanged()
	{
	}

	private bool IsGoalBlocked()
	{
		return false;
	}

	private void InterruptCurrentCompletionAnimation()
	{
	}

	private void SetPickupListBlockState(bool blocksGoals)
	{
	}

	private void SetBigMapBlockState(bool blocksGoals)
	{
	}

	private bool CanPlayTaskCompletion()
	{
		return false;
	}

	private void ApplyGoalVisibility()
	{
	}

	private void ApplyPhasePanelLayout()
	{
	}

	private void RefreshMainGoalFromSafeZone()
	{
	}

	private void ApplyMainGoalSafeZoneState(bool inSafe)
	{
	}

	private static bool ComputeLocalPlayerInSafeZone()
	{
		return false;
	}

	private void ApplyMainGoalVisual(bool inSafeZone)
	{
	}

	private void RefreshTaskList()
	{
	}

	private void RepositionTaskList()
	{
	}

	private void SetGameObjectActiveAndRepositionInfo(GameObject target, bool active)
	{
	}

	private bool HasActiveTask(uint taskId)
	{
		return false;
	}

	private void QueueTaskCompletion(uint taskId)
	{
	}

	private void TryPlayNextTaskCompletion()
	{
	}

	private void PlayTaskCompletionAtIndex(int index)
	{
	}

	private void RefreshActiveTaskProgress(int index)
	{
	}

	private void FinishTaskCompletion(uint taskId, int version)
	{
	}

	private void TryHidePhasePanelAfterAllTasksCompleted()
	{
	}

	private void RemoveCompletedTaskFromHud(uint taskId)
	{
	}

	private void TryAutoCollapseAfterCompletionBatch()
	{
	}

	private void ClearCompletionPresentationState()
	{
	}

	private void StopTaskItemCompletionSequences()
	{
	}

	private void EnsureTaskItemCount(int targetCount)
	{
	}

	private void ClearTaskItems()
	{
	}

	private void ApplyTaskListExpandedState(bool expanded, bool animateExpand)
	{
	}

	private void ResetScrollViewPosition()
	{
	}

	private void BindTaskListDragViewIgnorePlayerInput()
	{
	}

	private void ScheduleAutoCollapse()
	{
	}

	private void CancelAutoCollapseDelay()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private object[] GetDescriptionFormatArgs(uint taskId)
	{
		return null;
	}

	private void _003CScheduleAutoCollapse_003Eb__79_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
