using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCScreenshotHelper : MonoBehaviour
{
	public enum EErrorCode
	{
		SUCCESS = 0,
		FILE_NAME_EMPTY = -1,
		FILE_NAME_INVALID = -2
	}

	private sealed class _003CCaptureRoutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string baseName;

		public UGCScreenshotHelper _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureRoutine_003Ed__2(int _003C_003E1__state)
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

	public EErrorCode CaptureScreenshot(string fileName)
	{
		return EErrorCode.SUCCESS;
	}

	private IEnumerator CaptureRoutine(string baseName)
	{
		return null;
	}
}
