using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIWereWolvesGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWereWolvesGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__13(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHudWereWolvesTaskController m_HudTask;

	private UIHudWereWolvesVoteController m_HudVote;

	private UIHUDWolfKillActionController m_WolfKill;

	private UIHUDSelfInfoController m_SelfInfo;

	private UIHudWereWolvesInteractController m_Interact;

	private UIHUDReadyVote m_ReadyVote;

	private UIHUDUseTrapController m_UseTrapController;

	private Dictionary<uint, List<UIBaseController>> m_PhaseShowControllerMap;

	private FIMKFPENGGG m_CurPhase;

	private Dictionary<UIHudTaskNameIconController, bool> m_ActiveTaskNameIconMap;

	private UIHudWereWolvesVoiceEngineController m_VoiceController;

	private UIHudMovingJoystickController m_MoveBtn;

	private UIHudWereWolvesInfoController m_GameInfoHUD;

	private UIBigMapController m_BigMap;

	private UIHudWolfTaskController m_WolfTask;

	private UIHUDWereWolvesPrepareInfoController m_PrepareInfoController;

	private UIHudModeIntroInfoController m_IntroController;

	private UIHUDWereWolvesCampInfoController m_CampInfoController;

	private UIHUDWereWolvesEndShowTime m_EndShowTime;

	private UIHudJumpController m_JumpCtrl;

	private UIHUDTrapActionController m_TrapRescureAction;

	private UIHUDTrapActionController m_InTrapAction;

	private UIHUDWereWolvesUsePredictTool m_UsePredict;

	private UIHUDWereWolvesPredictToolCountDown m_PredictCountDown;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public override UIBigMapController GetBigMap()
	{
		return null;
	}

	private void OnPlayerRoleChange(object[] data)
	{
	}

	private void ProcessLocalPlayerRoleChange(POIGHHJOJEN role)
	{
	}

	private void OnShowTaskPanel(object[] data)
	{
	}

	private void OnShowVotePanel(object[] data)
	{
	}

	private void OnPlayerReadyVote(object[] data)
	{
	}

	private void OnPlayerExitReadyVote(object[] data)
	{
	}

	private void OnBuffNoMap(object[] data)
	{
	}

	private void ShowOrHideTaskName(bool isShow)
	{
	}

	public void OpenMiniMap()
	{
	}

	public void OpenBigMap()
	{
	}

	public void OpenMoveBtn()
	{
	}

	public void OpenInteract()
	{
	}

	public void OpenReadyVote()
	{
	}

	public void OpenVoteResult()
	{
	}

	public void OpenTaskHUD()
	{
	}

	public void OpenVoteHUD()
	{
	}

	private void OpenGameInfoHUD()
	{
	}

	private void OpenTaskList()
	{
	}

	private void OpenTaskWolfList()
	{
	}

	private void OpenWolfTask()
	{
	}

	private void OpenWolfCount()
	{
	}

	private void OpenVoiceEngine()
	{
	}

	private void CloseVoiceEngine()
	{
	}

	private void OpenPrepareHUD()
	{
	}

	private void OpenSpeedUpHUD()
	{
	}

	private void OpenWolfKillHUD()
	{
	}

	private void OpenIntroInfoHUD()
	{
	}

	public void OpenCampInfo(bool isWolf, int wolfCount, List<byte> wolfsColorIndex, bool isPredictToolOwner)
	{
	}

	public void OpenHumanKilledHUD(BHGGAEEHJCO humanPlayerID, BHGGAEEHJCO wolfPlayerID, bool isFinalKill)
	{
	}

	public void OnNewPhaseCome(object[] param)
	{
	}

	public void OpenEndShowTime()
	{
	}

	public void OpenMatchResult()
	{
	}

	public void OpenJumpBtn()
	{
	}

	private void OnLocalPlayerBunkerStateCome(object[] param)
	{
	}

	public T OpenUIByGamePhase<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, List<uint> gamePhases = null) where T : UIBaseController
	{
		return null;
	}

	public void OnAddTaskNameController(UIHudTaskNameIconController controller)
	{
	}

	public void OnRemoveTaskNameController(UIHudTaskNameIconController controller)
	{
	}

	private UIHudTaskNameIconController FindNearestTaskNameIcon()
	{
		return null;
	}

	public void BeginTutorial(bool isWolf)
	{
	}

	private void ShowTaskIconTurorial(bool isWolf)
	{
	}

	private void ShowKillTutorial()
	{
	}

	private void OnShowWolfDestroyTutorial(object[] param)
	{
	}

	private void OnShowWolfFakeTaskTutorial(object[] param)
	{
	}

	public void ShowFinalTaskComplete(string nickName)
	{
	}

	private void OnTrapCountUpdate(object[] param)
	{
	}

	private void OnRefreshTrapRescureShow(object[] param)
	{
	}

	private void OnRefreshInTrapState(object[] param)
	{
	}

	private void InTrapDisableOperationUI(bool isDisable)
	{
	}

	private void OnPredictToolEndTimeCome(object[] param)
	{
	}

	private void _003COpenIntroInfoHUD_003Eb__47_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public UIBigMapController _003C_003EiFixBaseProxy_GetBigMap()
	{
		return null;
	}
}
