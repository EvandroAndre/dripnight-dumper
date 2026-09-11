using GCommon;
using UnityEngine;
using VoxelBusters.ReplayKit;

namespace COW;

public class UIBRMatchReviewRecordController : UIBaseController
{
	private const float AutoStopAfterPlaybackEndSeconds = 10f;

	private const float MinRecordSecondsBeforeStop = 1f;

	private UIBRMatchReviewRecordView m_View;

	private UIBRMatchReviewController m_Owner;

	private bool m_IsRecordingForReview;

	private bool m_WaitingPreview;

	private bool m_IsClosingReview;

	private bool m_IsRecordStateVisible;

	private bool m_IsCancelingRecordOnClose;

	private bool m_KeepReplayKitCallbacksAfterDestroy;

	private bool m_RefreshRecordUiOnNextUpdate;

	private bool m_IsReviewReplayKitOwner;

	private bool m_HasHiddenExternalReplayKitCtrl;

	private bool m_PendingStopRecord;

	private bool m_LogPendingStopRecord;

	private float m_PlaybackEndRealtime;

	private float m_LastReviewOperationRealtime;

	private float m_RecordStartRealtime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetOwner(UIBRMatchReviewController owner)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnReviewClosed()
	{
	}

	private void FinishReviewReplayKitOwnership()
	{
	}

	private void HideExternalReplayKitCtrl()
	{
	}

	private void RestoreExternalReplayKitCtrl()
	{
	}

	private void CancelReviewReplayKitOnClose()
	{
	}

	private void DeleteCurrentRecordAndFinishCancel(bool resetRecordState)
	{
	}

	private void UnregisterReplayKitCallbacks()
	{
	}

	private bool IsReviewRecordAvailable()
	{
		return false;
	}

	private static bool IsReplayKitBusy()
	{
		return false;
	}

	private void NotifyReviewOperated(GameObject go)
	{
	}

	private bool IsGameObjectInReview(GameObject go)
	{
		return false;
	}

	private void OnReviewUIPress(GameObject go, bool pressed)
	{
	}

	private void OnReviewUIClick(GameObject go)
	{
	}

	private void OnReviewUIDragStart(GameObject go)
	{
	}

	private void OnReviewUIScroll(GameObject go, float delta)
	{
	}

	private void OnShareClick()
	{
	}

	private void StartReviewRecord()
	{
	}

	private void OnRecordStateBtnClick()
	{
	}

	private void OnRecordStateClick(bool log = false)
	{
	}

	private void RequestStopReviewRecord(bool log = false)
	{
	}

	private void StopReviewRecord(bool log = false)
	{
	}

	private float GetCurrentRecordSeconds()
	{
		return 0f;
	}

	private void TryAutoStopAfterPlaybackEnd()
	{
	}

	private void TryStopPendingRecord()
	{
	}

	private void OnStartRecordCallback(bool result, string message)
	{
	}

	private void OnInitialiseCallback(ReplayKitInitialisationState state, string message)
	{
	}

	private void OnReplayKitSwitchCallback(object[] args)
	{
	}

	private void OnRecordAvailableCallback(bool result, string message)
	{
	}

	private void OnStopRecordCallback(bool result, string message)
	{
	}

	private void OnSaveRecordCallback(bool result, string message)
	{
	}

	private void OnVideoRecordStopCallback(object[] args)
	{
	}

	private bool IsValidPreviewVideo(ReplayKitVideoInfo info)
	{
		return false;
	}

	private void FinishInvalidRecordPreview()
	{
	}

	private void RefreshRecordUI()
	{
	}

	private void SetRecordStateVisible(bool visible)
	{
	}

	private void Update()
	{
	}

	private static void ShowTips(string locKey)
	{
	}

	private static void HideWaitingControllersForRecord()
	{
	}

	private static void RestoreWaitingControllersAfterRecord()
	{
	}

	private void _003COnShareClick_003Eb__37_0(bool permission)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
