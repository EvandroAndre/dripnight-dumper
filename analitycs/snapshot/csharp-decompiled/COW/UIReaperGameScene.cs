using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UIReaperGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIReaperGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__4(int _003C_003E1__state)
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

	private UIHudReaperProgressBarController m_ScoreProgressBar;

	private UIHudReaperTransformController m_ReaperTransformBtn;

	private UIHudReaperHPBarController m_ReaperHPBar;

	protected override void OnInit()
	{
	}

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

	public void OnEnterPregame()
	{
	}

	public void OnEnterFight()
	{
	}

	public void OnIntroEnd()
	{
	}

	public void OnFirstSecondScoreChange()
	{
	}

	public void OnSoulChange()
	{
	}

	public void OnReaperHPChange(int oldV, int newV)
	{
	}

	public void OnReaperStateChange(bool toReaper = false, bool toNormal = false)
	{
	}

	public void OpenEquipSetSelection()
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

	private void _003COnEnterPregame_003Eb__7_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
