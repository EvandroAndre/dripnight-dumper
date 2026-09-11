using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UIHippoCrisisTutorialGameScene : UIWeRunGameScene
{
	private sealed class _003COpenCommonHud_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHippoCrisisTutorialGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__3(int _003C_003E1__state)
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

	private MKEIPDPNLOP m_CurPhase;

	private UIHudHippoCrisisTutorialOpeningController m_OpeningController;

	private UIHudTutorialMainTaskGuideController m_BannerGuideController;

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

	private void OnSearchBox(object[] data)
	{
	}

	private void OnGamePhaseChanged(object[] data)
	{
	}

	private void OnGuidePhaseChanged(object[] data)
	{
	}

	public UIHudTutorialMainTaskGuideController GetBannerGuideCtrl()
	{
		return null;
	}

	private void StartSearchBoxGuide()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
