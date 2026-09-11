using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using Lean.Touch;
using UnityEngine;

namespace COW;

public class UIPhotoWallCuttingWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public AlbumPhotoInfo albumPhotoInfo;

		public UIPhotoWallCuttingWndController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}
	}

	private sealed class _003CCaptureTargetFrameRegionCoroutine_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPhotoWallCuttingWndController _003C_003E4__this;

		private Rect _003CcaptureRect_003E5__2;

		private bool _003CshouldRestoreTarget_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureTargetFrameRegionCoroutine_003Ed__78(int _003C_003E1__state)
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

	private UIPhotoWallCuttingWndView m_View;

	public UITexture capturePreviewTexture;

	private Material m_CropMaskMat;

	public bool resizePreviewToCaptureSize;

	public bool enableTargetFrameDrag;

	public bool keepTargetFrameInsideBackground;

	public bool enableBackgroundPinchZoom;

	private float minBackgroundScale;

	private float maxBackgroundScale;

	public Texture defaultBackgroundTexture;

	public bool captureOnStart;

	public bool hideTargetFrameDuringCapture;

	public string outputFilePath;

	private Texture2D m_LastCapturedTexture;

	private AlbumPhotoInfo m_LastSavedAlbumPhotoInfo;

	private Texture2D m_RuntimeBackgroundTexture;

	private PhotoWallDraggableFrame m_BackgroundDrag;

	private PhotoWallDraggableFrame m_TargetFrameDrag;

	private LeanTouch m_RuntimeLeanTouch;

	private Camera m_ResolvedUICamera;

	private Vector4 m_CropMaskCenter;

	private Vector4 m_CropMaskRadius;

	private Vector3 m_DefaultBackgroundLocalPosition;

	private Vector3 m_DefaultBackgroundLocalScale;

	private Quaternion m_DefaultBackgroundLocalRotation;

	private Vector3 m_InitialBackgroundLocalPosition;

	private Vector3 m_InitialBackgroundLocalScale;

	private Quaternion m_InitialBackgroundLocalRotation;

	private Vector3 m_DefaultTargetFrameLocalPosition;

	private Vector3 m_DefaultTargetFrameLocalScale;

	private Quaternion m_DefaultTargetFrameLocalRotation;

	private Vector3 m_InitialTargetFrameLocalPosition;

	private Vector3 m_InitialTargetFrameLocalScale;

	private Quaternion m_InitialTargetFrameLocalRotation;

	private int m_DefaultTargetFrameWidth;

	private int m_DefaultTargetFrameHeight;

	private int m_InitialTargetFrameWidth;

	private int m_InitialTargetFrameHeight;

	private bool m_IsInitialized;

	private bool m_IsCaptureButtonBound;

	private bool m_IsGestureRegistered;

	private bool m_HasInitialLayoutState;

	public Action<AlbumPhotoInfo> OnCapturedPhotoSavedToAlbum;

	public Texture2D LastCapturedTexture => null;

	public AlbumPhotoInfo LastSavedAlbumPhotoInfo => null;

	public long LastSavedAlbumTimeTicks => 0L;

	public string LastSavedAlbumFilePath => null;

	public string LastSavedAlbumThumbnailPath => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void InitializeController()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(string filePath, bool isVertical)
	{
	}

	public void SetViewData(AlbumPhotoInfo albumPhotoInfo)
	{
	}

	private void OnCloseButtonClick()
	{
	}

	private void OnResetButtonClick()
	{
	}

	private void RegisterRuntimeEvents()
	{
	}

	private void UnregisterRuntimeEvents()
	{
	}

	private void CleanupController()
	{
	}

	private void LateUpdate()
	{
	}

	public void CaptureTargetFrameRegion()
	{
	}

	public void SetBackgroundTexture(Texture texture)
	{
	}

	public bool SetBackgroundTextureFromFile(string filePath)
	{
		return false;
	}

	private void RefreshBackgroundTextureSize(Texture texture)
	{
	}

	private void ReplaceRuntimeBackgroundTexture(Texture2D texture)
	{
	}

	private static Texture2D DuplicateTexture(Texture2D source)
	{
		return null;
	}

	public void SetTargetFrameSize(int width, int height)
	{
	}

	private IEnumerator CaptureTargetFrameRegionCoroutine()
	{
		return null;
	}

	private Camera ResolveUICamera()
	{
		return null;
	}

	private static Rect GetScreenRect(UIWidget widget, Camera captureCamera)
	{
		return default(Rect);
	}

	private static Rect IntersectRects(Rect a, Rect b)
	{
		return default(Rect);
	}

	private static Rect ClampRectToScreen(Rect rect)
	{
		return default(Rect);
	}

	private string GetOutputFilePath()
	{
		return null;
	}

	private void SaveCapturedPhotoToAlbum(string filePath)
	{
	}

	private static AlbumPhotoInfo FindNewAlbumPhotoInfo(List<AlbumPhotoInfo> beforeInfos, List<AlbumPhotoInfo> afterInfos)
	{
		return null;
	}

	private void SetupTargetFrameInteraction()
	{
	}

	private void SetupBackgroundInteraction()
	{
	}

	private void CacheDefaultLayoutState()
	{
	}

	private void ResetLayoutToDefault()
	{
	}

	private void RestoreInitializationBaseline()
	{
	}

	private void InitializeLayoutForCurrentBackground(bool isVertical)
	{
	}

	private void FitBackgroundToBounds(bool updateDefaultLayout)
	{
	}

	private void UpdateDefaultBackgroundLayoutState()
	{
	}

	private void FitTargetFrameWithinBackground(bool updateDefaultLayout)
	{
	}

	private void UpdateDefaultTargetFrameLayoutState()
	{
	}

	private void ApplyBackgroundOrientation(bool isVertical)
	{
	}

	private static bool AreWidgetAxesSwapped(Transform widgetTransform, Transform relativeTo)
	{
		return false;
	}

	private static void CenterWidgetToRect(Transform widgetTransform, Transform relativeTo, Vector2 targetCenter)
	{
	}

	private static void AlignWidgetVerticallyToRect(Transform widgetTransform, Transform relativeTo, float targetCenterY)
	{
	}

	private static void SetWidgetSizeFromVisualRect(UIWidget widget, Transform relativeTo, float desiredVisualWidth, float desiredVisualHeight)
	{
	}

	private void UpdateCropMask()
	{
	}

	private void RefreshTargetFrameInteraction()
	{
	}

	private void RefreshBackgroundInteraction()
	{
	}

	private void OnBackgroundTransformChanged()
	{
	}

	private void OnTargetFrameTransformChanged()
	{
	}

	private void EnsureLeanTouch()
	{
	}

	private void SyncCropMaskTransform()
	{
	}

	private void OnCropMaskRender(Material mat)
	{
	}

	private void OnBackgroundGesture(List<LeanFinger> fingers)
	{
	}

	private bool TryGetGestureWorldPoint(Camera targetCamera, Transform planeTransform, List<LeanFinger> fingers, out Vector3 worldPoint)
	{
		worldPoint = default(Vector3);
		return false;
	}

	private static Vector2 GetGestureCenter(List<LeanFinger> fingers)
	{
		return default(Vector2);
	}

	private void ClampBackgroundWithinTargetFrame()
	{
	}

	private void ClampTargetFrameWithinAllowedBounds()
	{
	}

	private Rect GetAllowedTargetFrameRect(Transform relativeTo, Rect backgroundRect)
	{
		return default(Rect);
	}

	private float GetMaxBackgroundScaleToStayInsideLimitRange(float currentScale, Vector3 pinchLocalPoint)
	{
		return 0f;
	}

	private float GetMinBackgroundScaleToContainTarget(float currentScale, Vector3 pinchLocalPoint)
	{
		return 0f;
	}

	private float GetConfiguredMinBackgroundScale()
	{
		return 0f;
	}

	private float GetConfiguredMaxBackgroundScale()
	{
		return 0f;
	}

	private float GetDefaultBackgroundScaleBase()
	{
		return 0f;
	}

	private static Vector2 GetAnchorPointInRelativeSpace(Transform bgTransform, Transform relativeTo, Vector3 pinchLocalPoint)
	{
		return default(Vector2);
	}

	private static float GetAbsoluteScaleLowerBound(float currentScale, Vector2 anchorPoint, Rect backgroundRect, Rect targetRect)
	{
		return 0f;
	}

	private static float GetAbsoluteScaleUpperBound(float currentScale, Vector2 anchorPoint, Rect backgroundRect, Rect limitRect)
	{
		return 0f;
	}

	private static Rect GetRectInSpace(UIWidget widget, Transform relativeTo)
	{
		return default(Rect);
	}

	private bool IsPinchBlockedByTargetFrame(List<LeanFinger> fingers)
	{
		return false;
	}

	private bool IsAnyFingerInsideWidget(List<LeanFinger> fingers, UIWidget widget)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
