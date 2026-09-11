using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIDebugUploadder : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIDebugUploadder _003C_003E4__this;

		public byte[] data;

		public bool showTips;

		public bool isAutoUpload;

		internal void _003CProcessUpload_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003CUploadOneFileWithRetry_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public byte[] data;

		public UIDebugUploadder _003C_003E4__this;

		public bool isAutoUpload;

		public bool showTips;

		public bool deleteAfterSuccess;

		private bool _003CisSucc_003E5__2;

		private float _003CretryDuration_003E5__3;

		private int _003CretryCount_003E5__4;

		private UnityWebRequest _003Cwww_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadOneFileWithRetry_003Ed__13(int _003C_003E1__state)
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

	private const int RETRY_MAX_COUNT = 3;

	private static FileInfo m_FileInfo;

	private static bool m_DuringUpload;

	private string m_LatestError;

	private static bool m_AutoUploadSuccess;

	public static bool DuringUpload => false;

	public static bool AutoUploadSuccess
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void AutoTaskDebugUpload(FileInfo fileInfo)
	{
	}

	public static void DebugUpload(FileInfo fileInfo, ECloudStorage.ClientDebuggerType type, bool showTips = true, bool isAutoUpload = false)
	{
	}

	private void ProcessUpload(ECloudStorage.ClientDebuggerType type, bool showTips, bool isAutoUpload)
	{
	}

	private IEnumerator UploadOneFileWithRetry(string url, byte[] data, bool deleteAfterSuccess, bool showTips, bool isAutoUpload)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
