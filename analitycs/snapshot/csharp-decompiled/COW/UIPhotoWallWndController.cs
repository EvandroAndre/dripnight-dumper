using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIPhotoWallWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AlbumPhotoInfo> _003C_003E9__45_0;

		public static Comparison<PhotoWallEditableItemData> _003C_003E9__96_0;

		internal int _003CFilterAlbumPhotos_003Eb__45_0(AlbumPhotoInfo a, AlbumPhotoInfo b)
		{
			return 0;
		}

		internal int _003CRestoreEditPanelDataCoroutine_003Eb__96_0(PhotoWallEditableItemData a, PhotoWallEditableItemData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public UIPhotoWallWndController _003C_003E4__this;

		public long uploadVersion;

		public Texture2D savedTexture;

		internal void _003CCaptureEditPanelAndSaveCoroutine_003Eb__0(bool success, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UIPhotoWallWndController _003C_003E4__this;

		public AlbumPhotoInfo photoInfo;

		internal void _003CCreateEditableImageInPanel_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public int hashCode;

		internal bool _003CRemoveEditableImage_003Eb__0(UIEditableImageController e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public int hashCode;

		internal bool _003COnDeleteStickerEvent_003Eb__1(UIEditableIconBaseController e)
		{
			return false;
		}

		internal bool _003COnDeleteStickerEvent_003Eb__0(UIEditableIconBaseController e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public bool isImageRestoreDone;

		internal void _003CRestoreEditPanelDataCoroutine_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public int restoreVersion;

		public UIPhotoWallWndController _003C_003E4__this;

		public PhotoWallEditableItemData item;

		public Action restoreDoneCallback;

		public AlbumPhotoInfo photoInfo;

		internal void _003CRestoreEditableImage_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}
	}

	private sealed class _003CCaptureEditPanelAndSaveCoroutine_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPhotoWallWndController _003C_003E4__this;

		private _003C_003Ec__DisplayClass113_0 _003C_003E8__1;

		private PhotoWallCacheData _003CdataToPublish_003E5__2;

		private Camera _003CcaptureCamera_003E5__3;

		private Rect _003CcaptureRect_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureEditPanelAndSaveCoroutine_003Ed__113(int _003C_003E1__state)
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

	private sealed class _003CRestoreEditPanelDataCoroutine_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhotoWallCacheData dataToRestore;

		public UIPhotoWallWndController _003C_003E4__this;

		public int restoreVersion;

		private _003C_003Ec__DisplayClass96_0 _003C_003E8__1;

		private List<PhotoWallEditableItemData> _003CrestoreItems_003E5__2;

		private int _003Ccount_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRestoreEditPanelDataCoroutine_003Ed__96(int _003C_003E1__state)
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

	private sealed class _003CUploadPhotoWallToGCS_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhotoWallGCSUploadRequest request;

		public UIPhotoWallWndController _003C_003E4__this;

		private bool _003Csuccess_003E5__2;

		private string _003CuploadError_003E5__3;

		private bool _003CshowWaiting_003E5__4;

		private UnityWebRequest _003Cwww_003E5__5;

		private int _003CuploadTimeout_003E5__6;

		private UnityWebRequestAsyncOperation _003Coperation_003E5__7;

		private float _003CtimeoutTime_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadPhotoWallToGCS_003Ed__115(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const int ItemType_Image = 0;

	private const int ItemType_Sticker = 1;

	private const float CacheDataEpsilon = 0.001f;

	private const AdType PhotoWallBGAdType = AdType.ADTYPE_PHOTOWALL_EDITING_BG;

	private const AdType PhotoWallFrameBGAdType = AdType.ADTYPE_PHOTOWALL_EDITING_BOARD;

	private UIPhotoWallWndView m_View;

	private UIModelTakePhoto m_Model;

	private PhotoWallLocalData m_LocalData;

	private PhotoWallCacheData m_DirtyBaselineCacheData;

	private UIPopMenuSmallControler m_FilterPopMenuCtrl;

	private List<AlbumPhotoInfo> m_AllAlbumPhotoInfos;

	private EPhotoWallFilter m_CurrentFilter;

	private int m_NextGlobalDepth;

	private List<UIEditableImageController> m_EditableImageDepthList;

	private Dictionary<int, AlbumPhotoInfo> m_EditableImagePhotoInfoMap;

	private List<UIEditableIconBaseController> m_StickerDepthList;

	private Dictionary<uint, List<UIEditableIconBaseController>> m_StickerDict;

	private Dictionary<uint, uint> m_StickerNumDict;

	private UIImageShareEmojiSelectPopController m_EmojiSelectPopCtrl;

	private Coroutine m_RestoreCoroutine;

	private GameObject m_DragPreviewGo;

	private Coroutine m_SaveCoroutine;

	private Coroutine m_PhotoWallGCSUploadCoroutine;

	private UnityWebRequest m_PhotoWallGCSUploadRequest;

	private bool m_IsStoppingPhotoWallGCSUpload;

	private bool m_IsSavingPhotoWall;

	private bool m_HasMissingLocalCacheItem;

	private bool m_IsAlbumPhotoInfosReady;

	private bool m_HasRestoredEditPanelData;

	private int m_RestoreVersion;

	private const string FilterLocKeyAll = "T_54_TT_PHOTOWALL_ALBUM_ALL";

	private const string FilterLocKeyOriginal = "T_54_TT_PHOTOWALL_ALBUM_ORIGINAL";

	private const string FilterLocKeyEdited = "T_54_TT_PHOTOWALL_ALBUM_EDITED";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void InitBackground()
	{
	}

	private void OnCDNAdProcessed()
	{
	}

	private void TryLoadBackground()
	{
	}

	private void TryLoadFrameBackground()
	{
	}

	private void OnBackgroundLoaded()
	{
	}

	private void InitFilterDropdown()
	{
	}

	private void GenerateFilterMenuData()
	{
	}

	private void OnFilterSelected(object data)
	{
	}

	private string GetFilterDisplayText(EPhotoWallFilter filter)
	{
		return null;
	}

	private List<AlbumPhotoInfo> FilterAlbumPhotos()
	{
		return null;
	}

	private void RefreshList()
	{
	}

	public void OnAlbumItemDragStart(Texture tex, AlbumPhotoInfo photoInfo, int width, int height)
	{
	}

	public void OnAlbumItemDrag()
	{
	}

	public void OnAlbumItemDragEnd(AlbumPhotoInfo photoInfo)
	{
	}

	public void OnAlbumItemClick(AlbumPhotoInfo photoInfo)
	{
	}

	private void UpdateDragPreviewPosition()
	{
	}

	private bool IsPointerInsideEditPanel()
	{
		return false;
	}

	private void CreateEditableImageInPanel(AlbumPhotoInfo photoInfo)
	{
	}

	private Bounds ComputeEditPanelBounds()
	{
		return default(Bounds);
	}

	private static Texture2D DuplicateTexture(Texture2D source)
	{
		return null;
	}

	private void DestroyDragPreview()
	{
	}

	private void RefreshImageNumLabel()
	{
	}

	private void RefreshEmptyEditPanelLabel()
	{
	}

	private bool IsEditPanelEmpty()
	{
		return false;
	}

	private bool IsEditableImageAtLimit()
	{
		return false;
	}

	private void RegisterEditableImage(UIEditableImageController ctrl)
	{
	}

	public void UnselectAllEditableImages()
	{
	}

	public void SetEditableImageToMaxDepth(int hashCode)
	{
	}

	public void RemoveEditableImage(int hashCode)
	{
	}

	public void CopyEditableImage(Texture texture, bool isVertical, Bounds? dragBounds, Quaternion rotation, Vector3 localScale, int sourceHashCode = 0)
	{
	}

	private void OnClickPanelClick()
	{
	}

	private void OnStickerBtnClick()
	{
	}

	private void OnCreateStickerEvent(object[] data)
	{
	}

	private void OnDeleteStickerEvent(object[] data)
	{
	}

	private void SetStickerDragBounds(UIEditableIconBaseController stickCtrl)
	{
	}

	public void SetStickerToMaxDepth(int hashCode)
	{
	}

	public void UnselectAllStickers()
	{
	}

	private bool CheckStickerGroupLimit(StickerConfigDesc stickerConfig)
	{
		return false;
	}

	private void ChangeStickerNum(uint groupID, bool isAdd)
	{
	}

	private int AllocGlobalDepth()
	{
		return 0;
	}

	private void ResetAllGlobalDepths()
	{
	}

	private Vector3 GetRandomCreatePosition()
	{
		return default(Vector3);
	}

	private Vector3 GetRandomizedCreatePosition(Vector3 basePosition)
	{
		return default(Vector3);
	}

	private Vector3 GetRandomCreateOffset(Bounds panelBounds)
	{
		return default(Vector3);
	}

	private PhotoWallCacheData CollectCurrentEditPanelData()
	{
		return null;
	}

	private bool HasEditPanelDataDirty()
	{
		return false;
	}

	private bool HasEditPanelDataDirty(PhotoWallCacheData currentData)
	{
		return false;
	}

	private static PhotoWallCacheData CloneCacheData(PhotoWallCacheData source)
	{
		return null;
	}

	private static bool AreCacheDataEqual(PhotoWallCacheData left, PhotoWallCacheData right)
	{
		return false;
	}

	private static List<PhotoWallEditableItemData> GetSortedCacheItems(PhotoWallCacheData data)
	{
		return null;
	}

	private static int CompareCacheItemOrder(PhotoWallEditableItemData left, PhotoWallEditableItemData right)
	{
		return 0;
	}

	private static bool AreCacheItemsEqual(PhotoWallEditableItemData left, PhotoWallEditableItemData right)
	{
		return false;
	}

	private static bool AreNearlyEqual(double left, double right)
	{
		return false;
	}

	private long SavePublishedData(PhotoWallCacheData publishedData)
	{
		return 0L;
	}

	private bool HasUnuploadedPublishedData()
	{
		return false;
	}

	private void MarkPublishedDataUploadSuccess(long uploadVersion)
	{
	}

	private void RestoreEditPanelData()
	{
	}

	private void TryRestoreEditPanelDataWhenReady()
	{
	}

	private bool ShouldWaitAlbumPhotoInfosForRestore()
	{
		return false;
	}

	private void StopRestoreCoroutine()
	{
	}

	private IEnumerator RestoreEditPanelDataCoroutine(PhotoWallCacheData dataToRestore, int restoreVersion)
	{
		return null;
	}

	private void SetSaveBtnLoadingState(bool loading)
	{
	}

	private void RestoreEditableImage(PhotoWallEditableItemData item, int restoreVersion, Action restoreDoneCallback)
	{
	}

	private void RestoreSticker(PhotoWallEditableItemData item)
	{
	}

	private AlbumPhotoInfo FindAlbumPhotoByTimeTicks(long timeTicks)
	{
		return null;
	}

	private static string GetPhotoWallDir()
	{
		return null;
	}

	private static string GetLocalDataPath()
	{
		return null;
	}

	private static PhotoWallLocalData LoadLocalData()
	{
		return null;
	}

	private static void SaveLocalData(PhotoWallLocalData data)
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnCloseBtnClick()
	{
	}

	private void ShowPhotoWallSecondConfirm(string titleKey, string contentKey, Action confirmAction)
	{
	}

	public void OnSaveBtnClick()
	{
	}

	private void StartSavePhotoWall()
	{
	}

	private IEnumerator CaptureEditPanelAndSaveCoroutine()
	{
		return null;
	}

	private void OnPhotoWallUploadToGCSEvent(object[] data)
	{
	}

	private IEnumerator UploadPhotoWallToGCS(PhotoWallGCSUploadRequest request)
	{
		return null;
	}

	private void AbortPhotoWallGCSUploadRequest()
	{
	}

	private void StopPhotoWallGCSUploadCoroutine()
	{
	}

	private void ShowPhotoWallUploadWaiting()
	{
	}

	private void HidePhotoWallUploadWaiting()
	{
	}

	private static Rect GetScreenRect(UIPanel panel, Camera captureCamera)
	{
		return default(Rect);
	}

	private static Rect ToPixelRect(Rect rect)
	{
		return default(Rect);
	}

	private static Rect ClampRectToScreen(Rect rect, Camera captureCamera)
	{
		return default(Rect);
	}

	private Texture2D CaptureEditPanelToTransparentTexture(Camera captureCamera, Rect captureRect)
	{
		return null;
	}

	private void RestoreEditPanelAfterCapture()
	{
	}

	private static int GetCaptureLayer(Camera captureCamera)
	{
		return 0;
	}

	private static void SetLayer(Transform root, int layer)
	{
	}

	private static void SetGameObjectLayer(GameObject go, int layer)
	{
	}

	private static void ForceRefreshUIPanels(Transform root)
	{
	}

	public void OnResetBtnClick()
	{
	}

	private void ClearAllEditPanelElements()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnCloseBtnClick_003Eb__109_0()
	{
	}

	private void _003COnSaveBtnClick_003Eb__111_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
