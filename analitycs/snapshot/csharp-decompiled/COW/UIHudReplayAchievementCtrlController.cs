using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReplayAchievementCtrlController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UIHudReplayAchievementCtrlController _003C_003E4__this;

		public ReplayHighlightEvent evt;
	}

	private sealed class _003C_003Ec__DisplayClass41_1
	{
		public int currentIndex;

		public _003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals1;

		internal void _003COnGotoHighlightCallback_003Eb__0()
		{
		}

		internal void _003COnGotoHighlightCallback_003Eb__1()
		{
		}
	}

	private sealed class _003CSmoothTimeScaleCoroutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReplayAchievementCtrlController _003C_003E4__this;

		public bool useEaseIn;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSmoothTimeScaleCoroutine_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CTraceKillMoment_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReplayAchievementCtrlController _003C_003E4__this;

		public int index;

		public ReplayHighlightEvent evt;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTraceKillMoment_003Ed__40(int _003C_003E1__state)
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

	private UIHudReplayAchievementCtrlView m_View;

	private List<uint> m_HighlightStartDelayCallList;

	private List<uint> m_HighlightEndDelayCallList;

	private Coroutine m_TraceKillMomentCoroutine;

	private Vector3 m_TraceKillMomentCameraStartPos;

	private Quaternion m_TraceKillMomentCameraStartRot;

	private Vector3 m_TraceKillMomentCameraEndPos;

	private Quaternion m_TraceKillMomentCameraEndRot;

	private Vector3 m_StartOffset;

	private Vector3 m_EndOffset;

	private Coroutine m_SmoothTimeScaleCoroutine;

	private float m_InitialTimeScale;

	private float m_TargetTimeScale;

	private float m_TransitionDuration;

	private float m_TransitionStartTime;

	private uint m_AceEffectDelayCall;

	private float m_AceEffectShowTime;

	private bool m_HasInitCurve;

	private float m_TraceKillMomentDuration;

	private float m_CurveLastFrameTime;

	private bool m_StartPlayKillEffectAnim;

	private float m_AnimationStartTime;

	private int m_CurrentShowPeriodIndex;

	private float m_HighlightDefaultShakeTime;

	private float m_HighlightDefaultShakeX;

	private float m_HighlightDefaultShakeY;

	private uint m_KillCountInAceRound;

	private uint m_CurrentAceRound;

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

	private bool IsCsAceLastPeriod(ReplayHighlightEvent evt, int index)
	{
		return false;
	}

	private void RefreshHighlightEffect(ReplayHighlightEvent evt, int index)
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void ShowUIEffect(ReplayHighlightEvent evt, int index)
	{
	}

	private void ShowFlashEffect()
	{
	}

	private void ShowKnockDownEffect(int count)
	{
	}

	private bool CanShowCameraEffect(ReplayHighlightEvent evt, int index)
	{
		return false;
	}

	private void ShowCameraEffect(ReplayHighlightEvent evt, int index)
	{
	}

	private IEnumerator TraceKillMoment(ReplayHighlightEvent evt, int index)
	{
		return null;
	}

	private void OnGotoHighlightCallback(object[] data)
	{
	}

	public void SmoothTimeScaleTransition(float startTimeScale, float duration, bool useEaseIn = true)
	{
	}

	private IEnumerator SmoothTimeScaleCoroutine(bool useEaseIn)
	{
		return null;
	}

	public void StopSmoothTimeScaleTransition()
	{
	}

	public bool IsSmoothTimeScaleTransitionActive()
	{
		return false;
	}

	private void _003CShowFlashEffect_003Eb__36_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
