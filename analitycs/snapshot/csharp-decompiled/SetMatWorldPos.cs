using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMatWorldPos : MonoBehaviour
{
	private sealed class _003CDoSet_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SetMatWorldPos _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoSet_003Ed__5(int _003C_003E1__state)
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

	public Material Mat;

	protected Transform CachedTrans;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void InitRefs()
	{
	}

	private IEnumerator DoSet()
	{
		return null;
	}
}
