using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class ControlUMAEffectLoop : MonoBehaviour
{
	private sealed class _003CControlCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ControlUMAEffectLoop _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CControlCoroutine_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CControlCoroutineRevert_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ControlUMAEffectLoop _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CControlCoroutineRevert_003Ed__10(int _003C_003E1__state)
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

	public float onTime;

	public float offTime;

	public bool FirstOpenThenClose;

	public UVSeqPlayer uvScripts;

	public List<GameObject> EffectsA;

	public GameObject EffectsRootA;

	private Coroutine m_Coroutine;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator ControlCoroutine()
	{
		return null;
	}

	private IEnumerator ControlCoroutineRevert()
	{
		return null;
	}

	private void SetEffectActive(bool show = true)
	{
	}
}
