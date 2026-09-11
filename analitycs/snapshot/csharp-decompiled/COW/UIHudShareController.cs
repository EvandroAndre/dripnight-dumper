using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudShareController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UnityEngine.Object cameraResObj;

		public bool cameraLoadDone;

		internal void _003CRefreshAvatarPreviewCoroutine_003Eb__0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_1
	{
		public UnityEngine.Object lightResObj;

		public bool lightLoadDone;

		internal void _003CRefreshAvatarPreviewCoroutine_003Eb__1(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UIHudShareController _003C_003E4__this;

		public int width;

		public int height;

		internal void _003CCaptureAvatar_003Eb__0(Texture2D texture2D)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public byte[] pngBytes;

		public UIHudShareController _003C_003E4__this;

		public Action<byte[], string, string> _003C_003E9__1;

		internal void _003CRequestSaveToAlbum_003Eb__0(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus auth, string error)
		{
		}

		internal void _003CRequestSaveToAlbum_003Eb__1(byte[] data, string nativeId, string saveError)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_1
	{
		public string nativeId;

		public string saveError;

		public _003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals1;

		internal void _003CRequestSaveToAlbum_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public Transform parent;

		public UIHudShareController _003C_003E4__this;

		public bool done;

		internal void _003CLoadCallSignAvatarFrameRoutine_003Eb__0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public UIHudShareController _003C_003E4__this;

		public string name;

		internal void _003COnSearchBtnClick_003Eb__0()
		{
		}

		internal bool _003COnSearchBtnClick_003Eb__1(FriendAccountInfo a)
		{
			return false;
		}
	}

	private sealed class _003CCaptureAvatarToTextureCoroutine_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudShareController _003C_003E4__this;

		public Action<Texture2D> callback;

		public int width;

		public int height;

		private Camera _003CavatarCamera_003E5__2;

		private RenderTexture _003CrenderTexture_003E5__3;

		private bool _003CuseTemporary_003E5__4;

		private RenderTexture _003CoriginalTargetTexture_003E5__5;

		private RenderTexture _003CcurrentRT_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureAvatarToTextureCoroutine_003Ed__63(int _003C_003E1__state)
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

	private sealed class _003CCaptureNGUIWidget_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudShareController _003C_003E4__this;

		public Action<byte[]> callback;

		public UIWidget widget;

		private Vector3 _003CoriginalQRCodeLocalPosition_003E5__2;

		private Vector3 _003CoriginalHUDContainerLocalPosition_003E5__3;

		private Vector3 _003CoriginalInfoContainerLocalPosition_003E5__4;

		private Vector3 _003CoriginalHUDContainerLocalScale_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureNGUIWidget_003Ed__70(int _003C_003E1__state)
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

	private sealed class _003CLoadCallSignAvatarFrameRoutine_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform parent;

		public UIHudShareController _003C_003E4__this;

		public ResourceID resId;

		private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadCallSignAvatarFrameRoutine_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003CRefreshAvatarPreviewCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudShareController _003C_003E4__this;

		private _003C_003Ec__DisplayClass58_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass58_1 _003C_003E8__2;

		private uint _003CavatarId_003E5__2;

		private List<uint> _003CclothList_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshAvatarPreviewCoroutine_003Ed__58(int _003C_003E1__state)
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

	protected UIHudShareView m_View;

	private UIQRCodeController m_QRCodeCtrl;

	private UIPopupWindowTopBtnController m_CloseBtn;

	private UIModelShare m_ModelShare;

	private UIModelFriends m_ModelFriends;

	private UIModelQRCode m_ModelQRCode;

	private UIModelUser m_ModelUser;

	private UIModelAvatar m_ModelAvatar;

	private const UIUtils.ShareUrlType m_ShareUrlType = UIUtils.ShareUrlType.HUDShare;

	private string m_ShareCode;

	private string m_PlayerName;

	private Texture2D m_HudScreenshot;

	private byte[] m_HudSettingsBytes;

	private UIKolHudFastPreviewController m_HudPreviewController;

	private UIMaleAvatar m_ShareAvatar;

	private GameObject m_AvatarCamera;

	private RuntimeAnimatorController m_MatchResultAnimatorController;

	private uint m_AsyncLoadCameraTicket;

	private uint m_AsyncLoadLightTicket;

	private uint m_AsyncLoadAnimCtrlTicket;

	private uint m_AsyncLoadAvatarFrameTicket;

	private Coroutine m_AvatarFrameLoadCoroutine;

	private List<FriendAccountInfo> m_CachedFriends;

	private List<object> m_CachedShareInfos;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private bool m_HasLoadShareBg;

	private Coroutine m_CaptureAvatarCoroutine;

	private Coroutine m_SetAvatarTextureCoroutine;

	private Coroutine m_CaptureNGUIWidgetCoroutine;

	private Coroutine m_RefreshAvatarPreviewCoroutine;

	private RenderTexture m_CaptureAvatarRenderTexture;

	private Texture2D m_CaptureNGUIWidgetTexture;

	private GameObject m_CallSignAvatarFrame;

	private ResourceID m_CallSignAvatarFrameRes;

	private UIPrivilegeIconController m_CallSignPrivilegeIconController;

	private const string LOG_TAG = "[UIHudShareController]";

	private static readonly Vector3 SCREENSHOT_QRCODE_POSITION;

	private static readonly Vector3 SCREENSHOT_HUDCONTAINER_POSITION;

	private static readonly Vector3 SCREENSHOT_HUDCONTAINER_SCALE;

	private static readonly Vector3 SCREENSHOT_INFOCONTAINER_POSITION;

	private static readonly Vector3 SCREENSHOT_AVATAR_TEXTURE_POSITION;

	private static readonly Vector3 AVATAR_CAMERA_POSITION;

	private static readonly Vector3 AVATAR_CAMERA_ROTATION;

	private static readonly Vector3 AVATAR_SCALE;

	private const int AVATAR_CAMERA_DEPTH = 1;

	private const int DESIGN_HEIGHT = 750;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitSocialButtons()
	{
	}

	private void InitSearchUI()
	{
	}

	private void InitImages()
	{
	}

	public void SetViewData(string shareCode)
	{
	}

	private byte[] GetCurrentHudConfigBytes()
	{
		return null;
	}

	private void AdjustCameraFOV(Camera camera)
	{
	}

	private void StartRefreshAvatarPreview()
	{
	}

	private IEnumerator RefreshAvatarPreviewCoroutine()
	{
		return null;
	}

	private void OnAvatarReady(UIStatedAvatar s)
	{
	}

	private void SetMatchResultAnimatorAndPlayMVPIdle()
	{
	}

	private void OnMatchResultAnimCtrlLoaded(uint ticket, bool success, UnityEngine.Object resObj)
	{
	}

	private void CaptureAvatar()
	{
	}

	private IEnumerator CaptureAvatarToTextureCoroutine(int width, int height, Action<Texture2D> callback)
	{
		return null;
	}

	private void RefreshHudPreview()
	{
	}

	private void RefreshQRCode()
	{
	}

	private void CopyShareCodeToClipBoard()
	{
	}

	private void OnSaveToAlbum()
	{
	}

	private void RequestSaveToAlbum(byte[] pngBytes)
	{
	}

	private void OnSaveToAlbumDone(string nativeId, string saveError)
	{
	}

	public IEnumerator CaptureNGUIWidget(UIWidget widget, Action<byte[]> callback)
	{
		return null;
	}

	private void UpdateCallSignInfo()
	{
	}

	private void RefreshCallSignAvatarFrame(BaseProfileInfo profile, Transform parent)
	{
	}

	private void LoadCallSignAvatarFrameAsync(ResourceID resId, Transform parent)
	{
	}

	private IEnumerator LoadCallSignAvatarFrameRoutine(ResourceID resId, Transform parent)
	{
		return null;
	}

	private void RefreshCallSignBadge(Transform parent)
	{
	}

	private void SetCallSignPrivilegeIcon(uint mainType, uint subType, Transform parent)
	{
	}

	private void UpdateCallSignBanner(uint bannerId)
	{
	}

	private void UpdateCallSignBanner(BannerData bannerdata)
	{
	}

	private void HideCallSign()
	{
	}

	private void OnLineClick()
	{
	}

	private void OnWhatsAppClick()
	{
	}

	private void OnInstagramClick()
	{
	}

	private void OnBindInviteClick()
	{
	}

	private void OnOtherClick()
	{
	}

	private void OnCopyLink()
	{
	}

	private void DoneShare(bool success, string platform)
	{
	}

	private void RefreshFriendListData()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void ResetSearchInput()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void RefreshFriendState()
	{
	}

	private List<object> GetShareChannelInfos()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void CancelAsyncLoadTicket(ref uint ticket)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void _003CInitImages_003Eb__53_0()
	{
	}

	private void _003COnSaveToAlbum_003Eb__67_0(byte[] pngBytes)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
