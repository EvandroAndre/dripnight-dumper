using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Audio;

public abstract class GAudioEmitterBase : GAudioComponentBase
{
	private sealed class _003CDelayPlaySound_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GAudioEmitterBase _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayPlaySound_003Ed__8(int _003C_003E1__state)
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

	public string soundID;

	private ResourceID _003CSoundID_003Ek__BackingField;

	private Coroutine m_DelayPlayCoroutine;

	public ResourceID SoundID
	{
		get
		{
			return _003CSoundID_003Ek__BackingField;
		}
		protected set
		{
			_003CSoundID_003Ek__BackingField = value;
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	private IEnumerator DelayPlaySound()
	{
		return null;
	}

	public abstract void PlaySound();

	protected virtual void OnDisable()
	{
	}
}
