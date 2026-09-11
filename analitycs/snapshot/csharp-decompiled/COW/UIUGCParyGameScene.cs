using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCParyGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCParyGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__0(int _003C_003E1__state)
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

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	protected override void OnOpenHudInPregame()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnOpenHudInPregame_003Eb__2_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}
}
