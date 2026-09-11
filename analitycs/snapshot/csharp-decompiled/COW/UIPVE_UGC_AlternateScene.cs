using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UIPVE_UGC_AlternateScene : UIUGCCommonInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVE_UGC_AlternateScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__2(int _003C_003E1__state)
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

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OpenObserverHud(object[] data)
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OpenObserverHud(object[] P0)
	{
	}
}
