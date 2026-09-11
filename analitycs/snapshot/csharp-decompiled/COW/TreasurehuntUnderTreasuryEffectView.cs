using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TreasurehuntUnderTreasuryEffectView : MonoBehaviour
{
	private sealed class _003CChannelEffectCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasurehuntUnderTreasuryEffectView _003C_003E4__this;

		private int _003CintensityCount_003E5__2;

		private int _003CsegmentCount_003E5__3;

		private int _003Ci_003E5__4;

		private float _003CstartValue_003E5__5;

		private float _003CendValue_003E5__6;

		private float _003Cduration_003E5__7;

		private float _003Celapsed_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChannelEffectCoroutine_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CTreasuryIntensityEffectCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasurehuntUnderTreasuryEffectView _003C_003E4__this;

		private float _003Celapsed_003E5__2;

		private float _003CstartValue_003E5__3;

		private float _003CendValue_003E5__4;

		private float _003Cduration_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTreasuryIntensityEffectCoroutine_003Ed__18(int _003C_003E1__state)
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

	public Renderer Channel;

	public List<float> ChannelIntensity;

	public List<float> ChannelIntensityTime;

	public List<GameObject> ChannelFireVFX;

	public Renderer Treasury;

	public float TreasuryIntensityStart;

	public float TreasuryIntensityTime;

	public List<GameObject> TreasuryFireVFX;

	public GameObject TopLightContainer;

	public GameObject ItemLightContainer;

	private Coroutine m_ChannelRoutine;

	private Coroutine m_TreasuryIntensityRoutine;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void PlayChannelEffect()
	{
	}

	private IEnumerator ChannelEffectCoroutine()
	{
		return null;
	}

	public void PlayTreasuryIntensityEffect()
	{
	}

	private IEnumerator TreasuryIntensityEffectCoroutine()
	{
		return null;
	}

	public void SetMaterialIntensity(Renderer renderer, float value)
	{
	}

	public void SetChannelFireVFXState(bool show)
	{
	}

	public void SetTreasuryFireVFXState(bool show)
	{
	}

	public void SetItemLightContainerState(bool show)
	{
	}

	public void ReSetState()
	{
	}
}
