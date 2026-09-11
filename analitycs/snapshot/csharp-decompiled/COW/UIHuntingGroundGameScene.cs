using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHuntingGroundGameScene : UIInGameScene, IAIHPRecycler
{
	private sealed class _003COpenCommonHud_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHuntingGroundGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003COpenHud_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHuntingGroundGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__40(int _003C_003E1__state)
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

	public const uint VISIBILITY_STATE_EventMask = 1073741824u;

	private Dictionary<int, HuntingGroundRoundInfoData> m_RoundInfos;

	private HuntingGroundRoundInfoData m_CurRoundInfo;

	protected PMFDLKMCHKA m_CurPhaseType;

	protected float m_CurPhaseEndTimeSec;

	private UIHudAvatarAttributeEntryController entryController;

	public UIHudAvatarAttributeController attributeCtrl;

	private UIHudHGRoundStartInfoController m_RoundStartUI;

	private UIHudHGRoundTopInfoController m_RoundTopUI;

	private UIHudHGRoundTopTwoBossInfoController m_RoundTwoBossTopUI;

	private UIHudHGArriveEndPointTopInfoController m_RoundEndPointTopUI;

	private UIHudHGGatherController m_GatherUI;

	private UIHudHGBuffTalentController m_BuffTalentUI;

	private UIHudHGReviveWaitTipController m_WaitReviveTipUI;

	private UIHUDHGReviveFinishTipController m_ReviveFinishUI;

	private UIHudHGTokenFlyController m_TokenAnimUI;

	private UIHudTokenController m_TokenUI;

	private UIHudReviveConfirmPageController m_ReviveConfirmUI;

	private UIHudHGRoundMinimapInfoController m_MiniMapRoundInfo;

	private UIHudHGMarkPointController m_EndPointUI;

	private HGEndPointEventParam m_EndPointUIEventParam;

	private int m_TokenNum;

	private uint m_DelayShowBuffTalentID;

	public int m_CurRoundID;

	private bool m_IsShowingWaitingOtherPlayerUI;

	private bool m_TriggerShowCountDown;

	private Dictionary<BHGGAEEHJCO, UIBaseController> m_AIHPControllers;

	private uint m_DelayCallOpenAttributeHUD;

	private UIBaseController m_CurActiveRoundTopController;

	private UIBaseController m_CurEventHideRoundTopController;

	private List<UIBaseController> m_AllRountTopUIList;

	private UIHudHGEventTopInfoController m_EventTopUI;

	protected int m_LastHidedObjectCutsceneIndex;

	private UIBaseController m_CurOserverRevivePanle;

	private UIHUDHGReviveTeammateController m_ReviveTeammateCtrl;

	public bool m_HasRoundTargetEndPoint;

	public Vector3 m_CurRoundFinalTargetPointPos;

	private UIHudHGColdBarController m_ColdBarUI;

	public float PhaseEndTime => 0f;

	public PMFDLKMCHKA Phase => PMFDLKMCHKA.EHuntingGroundPhase_MatchPregame;

	protected override void OnInit()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override void OpenGameTokenUI()
	{
	}

	protected override bool IsNeedSafeZoneInfoController()
	{
		return false;
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override bool IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void LoadRoundInfoConfig()
	{
	}

	private void OnShowGatherEnergy(object[] data)
	{
	}

	private void OnGatherEnergyChange(object[] data)
	{
	}

	protected virtual void OnAvatarAttributeReceived(object[] data)
	{
	}

	protected virtual void OnNewPhase(object[] data)
	{
	}

	private void CancelDelayCall()
	{
	}

	private void ShowAvatarAttributeEntry(bool show)
	{
	}

	private void ShowAvatarAttribute(bool show)
	{
	}

	private void ReOpenAvatarAttribute(object[] data)
	{
	}

	protected void OpenRoundStartUI()
	{
	}

	protected void UpdateGatherUI()
	{
	}

	protected void UpdateRoundTopUI()
	{
	}

	private void RefreshAllRoundTopControllerVisible()
	{
	}

	private void SetUIShow(UIBaseController uiController, bool isShow)
	{
	}

	private void AddNewRoundTopController(UIBaseController topController)
	{
	}

	public string GetCurRoundStageName()
	{
		return null;
	}

	protected void OpenWaitOtherPlayerJoinUI()
	{
	}

	protected void CloseWaitOhterPlayerJoinUI()
	{
	}

	private void OnLocalPlayerStartPendingRevive()
	{
	}

	private void OnLocalPlayerStopPendingRevive(object[] data)
	{
	}

	protected void PlayBossCutscene(int index)
	{
	}

	protected void StopBossCutscene()
	{
	}

	protected void CheckShowObjectHidedInCutscene()
	{
	}

	protected void InitDragonHeadType(GameObject cutSceneVfx)
	{
	}

	protected virtual void OpenAvatarAttribute()
	{
	}

	protected void OnNotify(object[] data)
	{
	}

	private void OpenRoundResultTipUI(bool isTimeOut)
	{
	}

	public virtual void OnGameUpdate()
	{
	}

	public override string GetDefeatEndShowKey()
	{
		return null;
	}

	private void OnTokenChanged(int data)
	{
	}

	private void OnAIHPChanged(object[] data)
	{
	}

	public void RecycleAIHPHud(BHGGAEEHJCO id)
	{
	}

	protected override void OpenObserverHud(object[] data)
	{
	}

	protected void OnPlayreRequestHelpRevive(uint playerID, uint reviveLeftTimeMS)
	{
	}

	protected void OnShowRevivePage(uint tokenCost, uint reviveType)
	{
	}

	protected void UpdateMiniMapRoundInfo(PMFDLKMCHKA phaseType)
	{
	}

	private void UpdateRoundTargetEndPoint()
	{
	}

	public void UpdateMarkPointControllerShowInfo(Vector3 pos)
	{
	}

	public void HideMarkPointController()
	{
	}

	protected void OnCurRunningEventInfoCome(GEvent gEvent)
	{
	}

	private void ProcessCurRunningEventTopUI(OKCLPONBOCI param)
	{
	}

	private void ProcessCurRunningEventMarkPoint(bool isEventEnable, bool isHideMarkPoint, Transform markPoint)
	{
	}

	protected void OnPlayerColdValueChange(float newValue)
	{
	}

	protected override Type GetMiniMapInZoneStateUIType()
	{
		return null;
	}

	protected override Type GetMatchEndShowHUD()
	{
		return null;
	}

	protected override Type BRScoreBoardType()
	{
		return null;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private IEnumerator _003C_003En__1()
	{
		return null;
	}

	private void _003COpenAvatarAttribute_003Eb__71_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OpenGameTokenUI()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetDefeatEndShowKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OpenObserverHud(object[] P0)
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMiniMapInZoneStateUIType()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchEndShowHUD()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_BRScoreBoardType()
	{
		return null;
	}
}
