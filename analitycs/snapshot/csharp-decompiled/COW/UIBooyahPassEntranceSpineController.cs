using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine.Playables;

namespace COW;

internal class UIBooyahPassEntranceSpineController : UINavigationController
{
	private enum SpineAnimState
	{
		State1 = 0,
		State2 = 1,
		State3 = 2,
		State4 = 3,
		FallBack = 10
	}

	private sealed class _003CWaitSecondToSwitchState_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpineAnimState curState;

		public UIBooyahPassEntranceSpineController _003C_003E4__this;

		public SpineAnimState nextState;

		private float _003CwaitBtnTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitSecondToSwitchState_003Ed__14(int _003C_003E1__state)
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

	private UIBooyahPassEntranceSpineView m_View;

	private SpineAnimState m_CurSpineAnimState;

	private PlayableDirector m_PlayableDirector;

	private PlayableDirector m_PlayableDirector_02;

	private UIModelBooyahPass m_ModelBooyahPass;

	private ulong m_AccountID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void ShowNext(object[] data)
	{
	}

	private void SwitchStateToPlayAnim(SpineAnimState nextState)
	{
	}

	private bool CheckSpineAnim(SpineAnimState nextState)
	{
		return false;
	}

	private void ShowSpineAnimByState(SpineAnimState nextState)
	{
	}

	private IEnumerator WaitSecondToSwitchState(SpineAnimState curState, SpineAnimState nextState)
	{
		return null;
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnNextStepClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
