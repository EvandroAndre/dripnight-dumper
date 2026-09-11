using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace COW.Gameplay.UGC;

public class SceneEditUploadTask
{
	private sealed class _003CUploadOneFileWithRetry_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadInfo info;

		public SceneEditUploadTask _003C_003E4__this;

		private int _003CretryCount_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadOneFileWithRetry_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CUploadRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneEditUploadTask _003C_003E4__this;

		private bool _003Csuccess_003E5__2;

		private List<UploadInfo>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadRoutine_003Ed__10(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private MonoBehaviour m_MonoBehaviour;

	private int m_TaskId;

	private List<UploadInfo> m_UploadList;

	private string m_UploadError;

	private Coroutine m_Coroutine;

	private Action<int> m_SuccessCallback;

	private Action<int> m_FailureCallback;

	public SceneEditUploadTask(MonoBehaviour mono, int taskId, List<UploadInfo> data, Action<int> onSuccess, Action<int> onFailure)
	{
	}

	public void StartTask()
	{
	}

	public void StopTask()
	{
	}

	private IEnumerator UploadRoutine()
	{
		return null;
	}

	private IEnumerator UploadOneFileWithRetry(UploadInfo info)
	{
		return null;
	}
}
