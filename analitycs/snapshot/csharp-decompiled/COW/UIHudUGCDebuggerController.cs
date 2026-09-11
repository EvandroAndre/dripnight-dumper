using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudUGCDebuggerController : UIBaseController
{
	private UIHudUGCDebuggerView m_View;

	private bool isExpand;

	private const string NEWBIE_EXIT_GUIDE_HINT_LOC_KEY = "T_54_XJ_NEWBIE_QUIT_PLAYTEST";

	private uint m_NewbieExitGuideDelayCallId;

	private uint m_NewbieExitGuideAutoHideDelayCallId;

	private bool m_NewbieExitGuideShown;

	private UITutorialIndicatorController m_NewbieExitGuideController;

	private bool m_isPaused;

	private UIUGCDebuggerConsole m_debugConsoleWindow;

	private float m_lastDebugActiveTime;

	private float m_maxDebugIdleTime;

	private float m_enterAutoExitDebugTime;

	private bool m_isHealing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshDebugButtons()
	{
	}

	private void OnDebugAttachChanged(object[] data)
	{
	}

	private void OnGamePauseChanged(object[] data)
	{
	}

	private void OnBtnDrop()
	{
	}

	private void OnPauseGameBtn()
	{
	}

	private void OnClickOpenGMCmdBtn()
	{
	}

	private void OnClickOpenConsoleBtn()
	{
	}

	private void OnGodStateChanged(object[] data)
	{
	}

	private void Update()
	{
	}

	private bool IsDebugIdle()
	{
		return false;
	}

	private void CheckDebugIdleExit()
	{
	}

	private void OnClickGodBtn()
	{
	}

	private void OnHealBuffBtn()
	{
	}

	private void OnKillSelfBtn()
	{
	}

	private void OnTeleportBornBtn()
	{
	}

	private void OnEndCurrentPhaseBtn()
	{
	}

	private void OnLogAdded(object[] data)
	{
	}

	private void RefreshBgSprite(Bounds bounds)
	{
	}

	private void UpdatePosByScreenQuadrant(Bounds oriBound, ref Bounds newBounds)
	{
	}

	private void InitDragDropItemBound(Bounds bounds)
	{
	}

	private void ExpandOrShrinkDebuggerPanel(bool isToExpand)
	{
	}

	private void InitSpaceBtnColliderSize()
	{
	}

	private void TryScheduleNewbieDebuggerExitGuide()
	{
	}

	private void CancelNewbieDebuggerExitGuideTimer()
	{
	}

	private void OnNewbieDebuggerExitGuideTimeReached()
	{
	}

	private void ShowNewbieDebuggerExitGuide(UIWidget targetWidget)
	{
	}

	private void ResetNewbieDebuggerExitGuideController()
	{
	}

	private void ScheduleNewbieDebuggerExitGuideAutoHide()
	{
	}

	private void CancelNewbieDebuggerExitGuideAutoHideTimer()
	{
	}

	private void OnNewbieDebuggerExitGuideAutoHide()
	{
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	private void _003CCheckDebugIdleExit_003Eb__25_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
