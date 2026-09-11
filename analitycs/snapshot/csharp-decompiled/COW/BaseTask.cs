using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class BaseTask : MonoBehaviour
{
	public delegate void CompleteCallBack();

	private sealed class _003CFailureCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseTask _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFailureCoroutine_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CSuccessCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseTask _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSuccessCoroutine_003Ed__18(int _003C_003E1__state)
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

	public GameObject SuccessObj;

	public GameObject FailureObj;

	public Animation[] animations;

	public float SuccessShowTime;

	public float FailureShowTime;

	public string successSound;

	public string FailSound;

	public string loopSound;

	private CompleteCallBack callBack;

	private CompleteCallBack postCallBack;

	private ResourceID m_resSuccessSound;

	private ResourceID m_resFailSound;

	private ResourceID m_loopSound;

	private AudioResource m_loopAudio;

	private bool m_IsShowedSuccess;

	public virtual void OnStart()
	{
	}

	public void ShowSuccess()
	{
	}

	private IEnumerator SuccessCoroutine()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public virtual void OnSuccess()
	{
	}

	public void ShowFailure()
	{
	}

	private IEnumerator FailureCoroutine()
	{
		return null;
	}

	public virtual void OnFailure()
	{
	}

	public void SetCompleteCallBack(CompleteCallBack value, CompleteCallBack post)
	{
	}

	public virtual void OnPostSuccess()
	{
	}

	protected void PlayAnimation()
	{
	}

	protected void StopAnimation()
	{
	}

	protected void PlayLoopSound()
	{
	}

	protected void StopLoopSound()
	{
	}

	public virtual void Pause()
	{
	}

	public virtual void Resume()
	{
	}

	private void OnDestroy()
	{
	}
}
