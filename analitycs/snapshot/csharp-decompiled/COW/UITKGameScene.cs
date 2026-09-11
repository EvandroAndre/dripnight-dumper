using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UITKGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITKGameScene _003C_003E4__this;

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

	private UIHudTKScoreInfoController m_UIHudTKScoreInfoController;

	private UIHudTKProgressBarController m_UIHudTKProgressBarController;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OnOpenHudInPregame()
	{
	}

	protected override void OnOpenHudBeginFight()
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnOpenHudInPregame_003Eb__3_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
