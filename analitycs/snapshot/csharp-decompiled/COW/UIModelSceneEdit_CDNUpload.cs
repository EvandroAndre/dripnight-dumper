using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using message;
using proto;

namespace COW;

public class UIModelSceneEdit_CDNUpload : MonoBehaviour
{
	private sealed class _003CUpload_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelSceneEdit_CDNUpload _003C_003E4__this;

		public CSGetUploadWorkshopURLRes urlRes;

		public byte[] runtimeData;

		public byte[] projectData;

		public byte[] coverData;

		public uint localSlotId;

		private List<byte[]> _003Cscreen_shot_bytes_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpload_003Ed__7(int _003C_003E1__state)
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

	private sealed class _003CUploadOneFileWithRetry_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public byte[] data;

		public UIModelSceneEdit_CDNUpload _003C_003E4__this;

		private bool _003CisSucc_003E5__2;

		private float _003CretryDuration_003E5__3;

		private int _003CretryCount_003E5__4;

		private double _003CrecordTime_003E5__5;

		private UnityWebRequest _003Cwww_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadOneFileWithRetry_003Ed__6(int _003C_003E1__state)
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

	private KKMFBJGIEBD m_cachedInfo;

	private bool m_IsUpdate;

	private EWorkshop.SlotType m_SlotType;

	private EWorkshop.SlotState m_SlotState;

	private string m_lastUploadError;

	public static UIModelSceneEdit_CDNUpload BeginUpload(KKMFBJGIEBD info, CSGetUploadWorkshopURLRes urlRes, byte[] runtimeData, byte[] projectData, byte[] coverData, bool update, EWorkshop.SlotType slotType, EWorkshop.SlotState slotState)
	{
		return null;
	}

	private IEnumerator UploadOneFileWithRetry(string url, byte[] data)
	{
		return null;
	}

	private IEnumerator Upload(CSGetUploadWorkshopURLRes urlRes, byte[] runtimeData, byte[] projectData, byte[] coverData, uint localSlotId)
	{
		return null;
	}

	private void NotifySucc(long timekey)
	{
	}

	private void NotifyFail(CSGetUploadWorkshopURLRes urlRes)
	{
	}

	private void OnDestroy()
	{
	}

	private void _003CNotifySucc_003Eb__8_0(HttpErrorCode errorCode, object res)
	{
	}
}
