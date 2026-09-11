using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIForceTutorialGameScene : UIInGameScene
{
	public enum HudType
	{
		None,
		FIRE,
		SIGHT,
		SPEEDUP,
		WEAPON_INFO,
		MINI_MAP,
		QUICK_USE_MEDKIT,
		RESCUE,
		TEAMMATE_INFO,
		MOVING_JOYSTICK,
		QUICK_CHAT,
		ICEWALL,
		GRENADE,
		SKILL,
		QuickReload
	}

	private sealed class _003COpenHud_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIForceTutorialGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__22(int _003C_003E1__state)
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

	private UIHudTutorialGamePopupWndController m_TutorialGamePopupWnd;

	private UIHudTutorialMainTaskGuideController m_TutorialMainTaskCtrl;

	private UIHudSightController m_HudSightCtrl;

	private UIHudQuickUseMedkitController m_HudQuickUseMedkitCtrl;

	private UIHudRescureController m_HudRescureCtrl;

	private new Dictionary<BHGGAEEHJCO, UIBaseController> m_PlayerNames;

	private UIBaseController m_TargetHud;

	private UIHudGrenadeBtnController m_HudGrenadeBtnController;

	private UIHudGrenadeDefenceBtnController m_HudGrenadeDefenceBtnController;

	private UIHudTutorialSniperScopeTypeController m_HudTutorialSniperScopeTypeController;

	private UIHudTutorialChangeHudTypeController m_HudTutorialHudTypeController;

	private UIHudActiveSkillController m_HudActiveSkillController;

	private UIForceTutorialSkillIntroduceController m_ForceTutorialSkillIntroduceController;

	private UIHudGrenadeCancelController m_HudGrenadeCancelController;

	private UIHudAuxFireController m_HudAuxFireController;

	private UIHudPortalMaskController m_HudPortalMaskController;

	private bool m_IsSniperTypePopWndShow;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDestory()
	{
	}

	public void InitPortalMask()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	private void DelegateAsyncLoadFinish(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	public void OnShowTutorialSniperScopeType(Action hideAction)
	{
	}

	public void OnSkillIntroduce(BJFAEJPOLOA type, Action<bool, float> startCallBack, Action<uint> closeCallBack, bool isPause = false, float existTime = 2f, float timeScale = 0f)
	{
	}

	public void OnShowTutorialHudType(Action hideAction)
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void RequestQuitMatch()
	{
	}

	private void OnShowTutorialMainTaskShow(object[] data)
	{
	}

	private void OnGameEnd(object[] data)
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void OnHudChange(object[] data)
	{
	}

	private void OnNewItemOnHand(object[] data)
	{
	}

	protected new void OnShowPortalMask(object[] data)
	{
	}

	protected void OnTutorialShowPortalMask(object[] data)
	{
	}

	public void AddTargetGuideHud(BHGGAEEHJCO id, bool isEnemy = true)
	{
	}

	public void RecycleTargetGuideHud(BHGGAEEHJCO id)
	{
	}

	public void AddTargetGuideHud(Vector3 pos)
	{
	}

	public void RecycleTargetGuideHud()
	{
	}

	public bool IsTriggerGrenadeCtrlVisible()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}
}
