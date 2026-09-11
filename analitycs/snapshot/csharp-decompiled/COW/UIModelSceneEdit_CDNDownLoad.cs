using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIModelSceneEdit_CDNDownLoad : MonoBehaviour
{
	public enum EDownLoadType
	{
		WorkShop,
		PreviewWorkShop,
		SecEdit,
		InGameSecEdit
	}

	public delegate void DownLoadSuccess(byte[] b);

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public byte[] projectBytes;

		public byte[] exportBytes;

		public byte[] coverBytes;

		internal void _003CDownLoad_003Eb__0(byte[] downLoadBytes)
		{
		}

		internal void _003CDownLoad_003Eb__1(byte[] downLoadBytes)
		{
		}

		internal void _003CDownLoad_003Eb__2(byte[] downLoadBytes)
		{
		}

		internal void _003CDownLoad_003Eb__3(byte[] downLoadBytes)
		{
		}
	}

	private sealed class _003CDownLoad_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelSceneEdit_CDNDownLoad _003C_003E4__this;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		private string _003CexportUrl_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownLoad_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CDownLoadOneFileWithRetry_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public UIModelSceneEdit_CDNDownLoad _003C_003E4__this;

		public DownLoadSuccess suc;

		private bool _003CisSucc_003E5__2;

		private float _003CretryDuration_003E5__3;

		private int _003CretryCount_003E5__4;

		private double _003CrecordTime_003E5__5;

		private UnityWebRequest _003Cwww_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownLoadOneFileWithRetry_003Ed__23(int _003C_003E1__state)
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

	public EDownLoadType downLoadType;

	public EWorkshop.SlotType curSlotType;

	public uint curSlotID;

	public uint dstSlotID;

	public EWorkshop.SlotType dstSlotType;

	public CSDownloadWorkshopRes workShopUrlRes;

	public UIModelSceneEdit.EWorkshopDownloadType workshopDownloadType;

	public Action callback;

	private bool needTips;

	public CSPreviewWorkshopCodeRes previewUrlRes;

	public string code;

	public CSAllowRecreateRes allowRecreateUrlRes;

	public SceneEditSlotInfo srcInfo;

	public SceneEditSlotInfo slotInfo;

	public bool showDownloadPop;

	private string m_lastDownLoadError;

	public float downloadTimeElapsed;

	public static UIModelSceneEdit_CDNDownLoad DownloadOneFileWithRetry(string url, DownLoadSuccess suc)
	{
		return null;
	}

	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSDownloadWorkshopRes urlRes, UIModelSceneEdit.EWorkshopDownloadType downloadType, EWorkshop.SlotType type, uint slotID, uint destId, EWorkshop.SlotType destType = EWorkshop.SlotType.SlotType_AUTHOR, Action callback = null, bool needTips = true)
	{
		return null;
	}

	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSPreviewWorkshopCodeRes urlRes, string code, EDownLoadType type = EDownLoadType.PreviewWorkShop)
	{
		return null;
	}

	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSAllowRecreateRes urlRes, SceneEditSlotInfo srcInfo, uint destId)
	{
		return null;
	}

	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSAllowRecreateRes urlRes, uint slotID)
	{
		return null;
	}

	private IEnumerator DownLoadOneFileWithRetry(string url, DownLoadSuccess suc)
	{
		return null;
	}

	private IEnumerator DownLoad()
	{
		return null;
	}

	private void NotifySucc(byte[] projectBytes, byte[] runtimeBytes, byte[] coverBytes)
	{
	}

	private void NotifyFail()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
