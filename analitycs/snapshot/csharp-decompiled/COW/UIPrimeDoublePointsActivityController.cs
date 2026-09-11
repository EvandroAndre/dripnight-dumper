using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIPrimeDoublePointsActivityController : UIBaseController
{
	private sealed class _003CDelayStartTrailEffectPosition_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPrimeDoublePointsActivityController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayStartTrailEffectPosition_003Ed__26(int _003C_003E1__state)
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

	private sealed class _003CTrailEffectMoveCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPrimeDoublePointsActivityController _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

		private float _003CcontainerGrowthStartTime_003E5__4;

		private float _003CcontainerGrowthEndTime_003E5__5;

		private int _003CcachedPoints_003E5__6;

		private int _003CcurrentEarnedPoints_003E5__7;

		private int _003CmaxEarnedPoints_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTrailEffectMoveCoroutine_003Ed__28(int _003C_003E1__state)
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

	private UIPrimeDoublePointsActivityView m_View;

	private UIModelPrime m_ModelPrime;

	private object m_Desc;

	private UICountDownController m_CountDownCtrl;

	private Vector3 m_OriContainerPosition;

	private GameObject m_TrailEffect;

	private const float EffectTime = 0.5f;

	private const float ContainerGrowthTime = 0.5f;

	private const float HoldTime = 0.2f;

	private int m_LastCachedPoints;

	private Vector3 deltaContainerPosition;

	private Vector3 m_TargetPosition;

	private float m_ContainerStartProgress;

	private float m_ContainerEndProgress;

	private Coroutine m_Coroutine;

	private int m_LastCurrentProcessDigits;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitActivityCountDown()
	{
	}

	private void InitDoublePointsActivityCND()
	{
	}

	private void RefreshDoublePointsActivity()
	{
	}

	private void RefreshContainerState()
	{
	}

	private void InitContainerEffectStartState()
	{
	}

	private void RefreshContainerFinalState()
	{
	}

	private void CheckPrimeEventGemsChanged()
	{
	}

	private void StartTrailEffectPosition()
	{
	}

	private IEnumerator DelayStartTrailEffectPosition()
	{
		return null;
	}

	private Vector3 CalculateTargetPosition(float progress)
	{
		return default(Vector3);
	}

	private IEnumerator TrailEffectMoveCoroutine()
	{
		return null;
	}

	public void SetContainerProgress(float progress)
	{
	}

	public void SetMaskState(bool isActive)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnSyncSettingTipClick()
	{
	}

	private void OnJumpToChargeClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
