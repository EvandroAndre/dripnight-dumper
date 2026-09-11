using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIForceTutorialSkillIntroduceController : UIPopupWindowController
{
	private sealed class _003CAnimationSequenceNoPause_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIForceTutorialSkillIntroduceController _003C_003E4__this;

		private float _003CanimOutTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimationSequenceNoPause_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CAnimatorSequenceWithPause_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIForceTutorialSkillIntroduceController _003C_003E4__this;

		private float _003CanimOutTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimatorSequenceWithPause_003Ed__17(int _003C_003E1__state)
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

	private float m_UIExistTime;

	private float m_TimeScale;

	private UIForceTutorialSkillIntroduceView m_View;

	private Action<bool, float> m_StartCallBack;

	private Action<uint> m_CloseCallBack;

	private BJFAEJPOLOA m_ForcetutorialSkillCameraType;

	private Coroutine m_AnimSequenceCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetSkillLabel(BJFAEJPOLOA type)
	{
	}

	private void SetCDN(BJFAEJPOLOA type)
	{
	}

	public void SetViewData(BJFAEJPOLOA type, Action<bool, float> startCallBack, Action<uint> closeCallBack, float existTime, float timeScale)
	{
	}

	public void SetViewDataWithPause(BJFAEJPOLOA type, Action<bool, float> startCallBack, Action<uint> closeCallBack, float existTime, float timeScale)
	{
	}

	private IEnumerator AnimationSequenceNoPause()
	{
		return null;
	}

	private IEnumerator AnimatorSequenceWithPause()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
