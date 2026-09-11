using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIWeRunGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeRunGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003COpenHud_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeRunGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__10(int _003C_003E1__state)
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

	private UIHudWeRunModeCountdownController m_CountDownCtrl;

	private UIHudWeRunRetreatRetreatCountdownController m_RetreatCountDownCtrl;

	private UIHudCDNGuideController m_CdnGuideEntryCtrl;

	private UIHudHippoCrisisGameInfoController m_GameInfoController;

	private Dictionary<uint, UIHudHippoCrisisRetreatPointMarkShowController> m_RetreatPointMarks;

	private MKEIPDPNLOP m_CurPhase;

	private UIBaseController m_CurOserverRevivePanel;

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

	protected override Type GetMatchResultType()
	{
		return null;
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	private void OnPhaseChanged(object[] data)
	{
	}

	private void OnRetreatTimeChanged(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnAddObserver(uint data)
	{
	}

	private void OnStartBannerEnd(object[] data)
	{
	}

	private void OnRetreatPointChanged(object[] data)
	{
	}

	private void UpdateGuide()
	{
	}

	public void UpdateCdnGuideEntryVisible(bool b)
	{
	}

	private void UpdateTimeUI(uint phaseEndTime, uint phaseStartTime)
	{
	}

	private void OnLocalPlayerGameEnd()
	{
	}

	protected override Type GetMatchEndShowHUD()
	{
		return null;
	}

	public Vector3 GetRetreatPointPosInDirRuler(uint retreatPointID)
	{
		return default(Vector3);
	}

	protected override void OpenObserverHud(object[] data)
	{
	}

	public UIHudWeRunModeCountdownController GetCountDownCtrl()
	{
		return null;
	}

	protected override void OnPreOpenMatchResult()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private IEnumerator _003C_003En__1()
	{
		return null;
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

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchEndShowHUD()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OpenObserverHud(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPreOpenMatchResult()
	{
	}
}
