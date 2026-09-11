using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewCommonController : UIBaseController
{
	private sealed class _003CRecoverPreview3DItemRotation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFrontEndPreviewCommonController _003C_003E4__this;

		private GameObject _003Ccurgo_003E5__2;

		private Transform _003Ctrans_003E5__3;

		private Quaternion _003Clerproate_003E5__4;

		private float _003Ctime_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRecoverPreview3DItemRotation_003Ed__31(int _003C_003E1__state)
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

	private UIFrontEndPreviewCommonView m_View;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	private FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	private bool m_NeedAutoCheckPreviewBorder;

	private UIWidget m_AutoCheckCachedPreviewBorder;

	private Vector3 m_OriginalHotFixPos;

	private bool m_IsDragItemDirty;

	private GameObject m_CachedPreview3DItem;

	private Transform m_CachedPreview3DItemTrans;

	private Coroutine m_DragCorotine;

	private const float DRAG_ROTATE_RATE = 0.5f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	public void SetViewData(FrontEndPreviewComponent comp)
	{
	}

	public void ClearCache()
	{
	}

	public void OnClosePreview()
	{
	}

	private void CloseAutoCheckPreviewBorder()
	{
	}

	public void SetAutoCheckPreviewBorder(UIWidget widget)
	{
	}

	private bool CheckDirty(UIWidget widget)
	{
		return false;
	}

	private void UpdateCachedPreviewBorder()
	{
	}

	private void Update()
	{
	}

	public virtual UIFrontEndPreview2DItemController GetFrontEndPreview2DItemCtrl()
	{
		return null;
	}

	public virtual UIFrontEndPreviewHotFixDownloadBaseController GetHotFixDownloadBaseController()
	{
		return null;
	}

	public bool CheckAbReadyWhenClick()
	{
		return false;
	}

	private void ClearDragCorotinue()
	{
	}

	private void OnDraging(GameObject go, Vector2 delta)
	{
	}

	private void OnDragStart(GameObject go)
	{
	}

	private void OnDragEnd(GameObject go)
	{
	}

	private IEnumerator RecoverPreview3DItemRotation()
	{
		return null;
	}

	public void SetDragEventListenerVisible(bool isVisible)
	{
	}

	public void SetDragEventListenerEnable(bool enable)
	{
	}

	public void SetDragItemDirty(bool isDirty)
	{
	}

	private void OnRefreshDragEvnetListener(object[] data)
	{
	}

	private void OnShowEmoteBtnClick()
	{
	}

	public void SetShowEmoteBtnVisible(bool isVisible)
	{
	}

	public virtual UIFrontEndPreviewVideoPlayerController GetVideoPlayerController()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
