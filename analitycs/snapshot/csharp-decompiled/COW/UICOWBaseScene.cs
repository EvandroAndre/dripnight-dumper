using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UICOWBaseScene : UIBaseScene
{
	public enum WaitFor
	{
		Default,
		GMSDK,
		IAP,
		HTTP,
		MatchRequest,
		MatchResult,
		CreateRoom,
		TraceRoute,
		GoogleEngagementRewards,
		LoginLoading,
		UGCCDNLoading,
		RoomMatchReques,
		UGCModeRuleLoading,
		UGCHodini,
		PhotoWallUpload,
		MatchResultPoster,
		MsdkRegForm
	}

	public class Wait
	{
		public string Log;

		public bool Block;
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public Action onClose;

		public UICOWBaseScene _003C_003E4__this;

		public UIBaseController target;

		internal void _003CShowShareImageFileMessageBox_003Eb__0()
		{
		}

		internal void _003CShowShareImageFileMessageBox_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UICOWBaseScene _003C_003E4__this;

		public Action onClose;

		internal void _003CShowCoverImageFileMessageBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UICOWBaseScene _003C_003E4__this;

		public UIImageShareCaptureWidgetController shareCaptureWidget;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public string filePath;

		public UIUtils.EShareScreenType screenType;

		public string extraFilePath;

		public bool shareUrl;

		public ShareSettingDesc shareSetting;

		public uint shareWeaponSkinId;

		public uint shareActivityId;

		public bool autoSave;

		public uint awardItemID;

		public bool hasLeftBar;

		public EShareLadderIconType iconType;

		public EventLogger.EventShareExtraInfoBase eventLogExtraInfo;

		internal void _003C_TakeScreenshot_003Eb__0(Texture2D screenshot)
		{
		}

		internal void _003C_TakeScreenshot_003Eb__1(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public Action afterScreenShot;

		internal void _003C_TakeScreenshotForShareEditor_003Eb__0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public Action afterScreenShot;

		internal void _003C_TakeScreenshotForShareEditor2_003Eb__0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public Camera gameCamera;

		public int savedCullingMask;

		public UIBaseController ugcShareCaptureWidget;

		public UIImageShareCaptureWidgetController ffShareCaptureWidget;

		public UIBaseController target;

		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		internal void _003C_UGCTakeScreenshot_003Eb__0(Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		public UIUtils.ScreenshotType screenshotType;

		public UIBaseController target;

		public bool hasTopBar;

		public Action onClose;

		public bool hasLeftBar;

		public UIUtils.EShareScreenType screenType;

		public bool hideUserID;

		public bool shareUrl;

		internal void _003C_TakeScreenshotForCoverWithAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UICOWBaseScene _003C_003E4__this;

		public UIImageShareCaptureWidgetController shareCaptureWidget;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public string filePath;

		public UIUtils.EShareScreenType screenType;

		public string extraFilePath;

		public Action onClose;

		public bool shareUrl;

		public ShareSettingDesc shareSetting;

		public uint shareWeaponSkinId;

		public uint shareActivityId;

		public string pageTile;

		public uint awardItemID;

		public bool hasLeftBar;

		public EventLogger.EventShareExtraInfoBase eventLogExtraInfo;

		public uint brSeasonId;

		public uint csSeasonId;

		public bool showIIVLogo;

		public bool isProfileInfo;

		internal void _003C_TakeScreenshotAction_003Eb__0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public string filePath;

		public AlbumPhotoInfo highlightAlbumPhotoInfo;

		internal void _003CSaveHighlightScreenshotInGame_003Eb__0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		internal void _003CTakeScreenshotInSystem_003Eb__0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public RenderTexture renderTexture;

		public bool NeedRotationResultPic;

		public Action<Texture2D> onScreenShotFinish;

		public UICOWBaseScene _003C_003E4__this;

		public UIImageShareCaptureWidgetController shareCaptureWidget;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		internal void _003C_TakeScreenShotWithoutSave_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public RenderTexture renderTexture;

		public Texture2D screenshot;

		public int count;

		public int height;

		public UIImageShareCaptureWidgetController shareCaptureWidget;

		public ICombineShare combine_share;

		public int i;

		public Action _003C_003E9__0;

		internal void _003C_TakeCombineScreenshotAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public Action onClose;

		public UICOWBaseScene _003C_003E4__this;

		public UIBaseController target;

		internal void _003CShowCombineShareImageFileMessageBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_TakeCombineScreenshotAction_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int count;

		public UIBaseController target;

		public UICOWBaseScene _003C_003E4__this;

		private _003C_003Ec__DisplayClass76_0 _003C_003E8__1;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public string filePath;

		public Action onClose;

		public bool shareUrl;

		public ShareSettingDesc shareSetting;

		public uint shareWeaponSkinId;

		public uint shareActivityId;

		public string pageTile;

		private UICombineScreenshotLoadingController _003CscreenShotLoadingCtrl_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeCombineScreenshotAction_003Ed__76(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenShotWithoutSave_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Texture2D> onScreenShotFinish;

		public UICOWBaseScene _003C_003E4__this;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public bool hasTopBar;

		public bool hasLeftBar;

		public UIUtils.EShareScreenType screenType;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenShotWithoutSave_003Ed__60(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenshot_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICOWBaseScene _003C_003E4__this;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public string filePath;

		public UIUtils.EShareScreenType screenType;

		public string extraFilePath;

		public bool shareUrl;

		public ShareSettingDesc shareSetting;

		public uint shareWeaponSkinId;

		public uint shareActivityId;

		public bool autoSave;

		public uint awardItemID;

		public bool hasLeftBar;

		public EShareLadderIconType iconType;

		public EventLogger.EventShareExtraInfoBase eventLogExtraInfo;

		public bool hasTopBar;

		public float logoScale;

		public EShareFFLogoAnchorPos ffLogoAnchorPos;

		public bool isHideFFlogo;

		public bool needWaitMoreOneFrame;

		public bool optReadTexture;

		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		public int width;

		public int height;

		public bool isIgnoreUI;

		public bool waitForOneFrame;

		private bool _003CNeedRotationResultPic_003E5__2;

		private int _003CcycleWaitTimes_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenshot_003Ed__42(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenshotAction_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICOWBaseScene _003C_003E4__this;

		public UIBaseController target;

		public UIUtils.ScreenshotType screenshotType;

		public bool hideUserID;

		public string filePath;

		public UIUtils.EShareScreenType screenType;

		public string extraFilePath;

		public Action onClose;

		public bool shareUrl;

		public ShareSettingDesc shareSetting;

		public uint shareWeaponSkinId;

		public uint shareActivityId;

		public string pageTile;

		public uint awardItemID;

		public bool hasLeftBar;

		public EventLogger.EventShareExtraInfoBase eventLogExtraInfo;

		public uint brSeasonId;

		public uint csSeasonId;

		public bool showIIVLogo;

		public bool isProfileInfo;

		public bool hasTopBar;

		public EShareLadderIconType iconType;

		public EShareFFLogoAnchorPos ffLogoAnchorPos;

		public bool isHideFFlogo;

		public int frameCount;

		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

		public Camera[] cameras;

		private bool _003CNeedRotationResultPic_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenshotAction_003Ed__53(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenshotForCoverWithAction_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		public UIUtils.ScreenshotType screenshotType;

		public UIBaseController target;

		public bool hasTopBar;

		public Action onClose;

		public bool hasLeftBar;

		public UIUtils.EShareScreenType screenType;

		public bool hideUserID;

		public bool shareUrl;

		private _003C_003Ec__DisplayClass51_0 _003C_003E8__1;

		public Action<byte[]> onSave;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenshotForCoverWithAction_003Ed__51(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenshotForShareEditor2_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action afterScreenShot;

		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		public bool needRotationResultPic;

		public int width;

		public int height;

		public Camera camera;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenshotForShareEditor2_003Ed__46(int _003C_003E1__state)
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

	private sealed class _003C_TakeScreenshotForShareEditor_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action afterScreenShot;

		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		public bool needRotationResultPic;

		public Camera camera;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_TakeScreenshotForShareEditor_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003C_UGCTakeScreenshot_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBaseController target;

		public UICOWBaseScene _003C_003E4__this;

		public string filePath;

		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		public bool isIgnoreUI;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_UGCTakeScreenshot_003Ed__48(int _003C_003E1__state)
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

	public SceneRootFinder RootFinder;

	private UIModelClan m_ModelClan;

	private UIModelInvitation m_ModelInvitation;

	private UIWaitingForRequestController m_WaitingForRequestController;

	private UIWaitingForRequestCircleController m_WaitingForRequestCircleController;

	private UIMatchResultWaitingController m_MatchResultWaitingController;

	private UIPopupMessageBoxController m_PopupMessageController;

	public UIImageSharePreviewWindowController m_ImageSharePreviewWindowController;

	public UIImageCombineSharePreviewWindowController m_ImageCombineSharePreviewWindowController;

	public UIHighlightShareWindowController m_HighlightShareWindowController;

	private UIImageCoverPreviewWindowController m_ImageCoverPreviewWindowController;

	protected UIMaskController m_MaskController;

	protected UIMaskController m_MaskBelowUICtrl;

	protected UIInvitationTipsBoxController m_CurInviteTipsController;

	private UIScreenShotShareMessageWindowController UIScreenShotMessageWindow;

	private Dictionary<int, Wait> _Waits;

	protected UIModelClan ModelClan => null;

	protected UIModelInvitation ModelInvitation => null;

	public bool ShowingShareImageFileMessageBox => false;

	private bool IsScreenshotNeededInAlbum => false;

	protected override void OnInit()
	{
	}

	protected override void OnDestory()
	{
	}

	public void ShowStandardMessageBox(string info, UIPopupMessageBoxController.EStandardMessageBoxType mbType, Action onOK = null, Action onCancel = null, UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.OKOnly, string note = "", string okTextKey = "", Func<bool> confirmDelayCallFunc = null, Action onBeforeForceClose = null, string cancelTextKey = "", Action onClose = null)
	{
	}

	public void ShowMatchResultShareFileMessageBox(MatchResultHighlightWindowInfo highlightWindowInfo, bool hasHighlightVideo, MatchStats matchStats = null)
	{
	}

	public void ShowShareImageFileMessageBox(UIBaseController target, ShareImageData data, Action onClose = null, uint changedepth = 0u, bool shareUrl = false, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool autoSave = false, uint awardItemID = 0u, bool hasLeftBar = false, EShareLadderIconType iconType = EShareLadderIconType.None, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, uint brSeasonId = 0u, uint csSeasonId = 0u, bool showIIVLogo = false, bool isProfileInfo = false)
	{
	}

	public void ShowUGCShareImageFileMessageBox(UIBaseController target, ShareImageData data, EventLogger.EventUGCShareTakePhotoExtraInfo extraInfo = null)
	{
	}

	public void ShowCoverImageFileMessageBox(string filePath, Action onClose = null, uint changedepth = 0u, Action onShare = null, Action<byte[]> onSave = null)
	{
	}

	public void ShowNetworkErrorMessageBox(string detailErrorMessage = "")
	{
	}

	public int GetWaitingCout()
	{
		return 0;
	}

	public void ShowWaiting(WaitFor reason, Wait wait, LoadingType loadingType = LoadingType.CircleLoading, string waitRemind = "")
	{
	}

	public void HideWaiting(WaitFor reason)
	{
	}

	public void PrintWaiting()
	{
	}

	private void _SetWaitingUI(bool value, WaitFor reason, Wait wait, LoadingType loadingType = LoadingType.CircleLoading, string waitRemind = "")
	{
	}

	public void ClosePopupBox()
	{
	}

	public void SetMask(bool mask, Color color)
	{
	}

	public override UIBaseNavigationController PushNavigation(Type type, UINavigationData navigationData, bool isRoot = false, UIControllerContext context = null)
	{
		return null;
	}

	public void TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false, bool shareUrl = false, EShareLadderIconType iconType = EShareLadderIconType.None, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, int width = 0, int height = 0, bool isHideFFlogo = false, bool autoSave = false, bool isIgnoreUI = false, bool waitForOneFrame = false, uint awardItemID = 0u, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, bool optReadTexture = false, string extraFilePath = null, bool needWaitMoreOneFrame = false)
	{
	}

	private IEnumerator _TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false, bool shareUrl = false, EShareLadderIconType iconType = EShareLadderIconType.None, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, int width = 0, int height = 0, bool isHideFFlogo = false, bool autoSave = false, bool isIgnoreUI = false, bool waitForOneFrame = false, uint awardItemID = 0u, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, bool optReadTexture = false, string extraFilePath = null, bool needWaitMoreOneFrame = false)
	{
		return null;
	}

	public void TakeScreenshotForShareEditor(string filePath, Camera camera, Action afterScreenShot, bool needRotationResultPic)
	{
	}

	private IEnumerator _TakeScreenshotForShareEditor(string filePath, Camera camera, Action afterScreenShot, bool needRotationResultPic)
	{
		return null;
	}

	public void TakeScreenshotForShareEditor2(string filePath, Camera camera, Action afterScreenShot, bool needRotationResultPic, int width = 0, int height = 0)
	{
	}

	private IEnumerator _TakeScreenshotForShareEditor2(string filePath, Camera camera, Action afterScreenShot, bool needRotationResultPic, int width = 0, int height = 0)
	{
		return null;
	}

	public void UGCTakeScreenshot(string filePath, UIBaseController target, bool isIgnoreUI = false)
	{
	}

	private IEnumerator _UGCTakeScreenshot(string filePath, UIBaseController target, bool isIgnoreUI = false)
	{
		return null;
	}

	private bool CheckMyProfilePicDownloadFinished()
	{
		return false;
	}

	public void TakeScreenshotForCoverWithAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, Action onClose = null, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false, Action<byte[]> onSave = null)
	{
	}

	private IEnumerator _TakeScreenshotForCoverWithAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, Action onClose = null, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false, Action<byte[]> onSave = null)
	{
		return null;
	}

	public void TakeScreenshotWithAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, Action onClose = null, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool isHideFFlogo = false, int frameCount = 1, uint awardItemID = 0u, uint brSeasonId = 0u, uint csSeasonId = 0u, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, EShareLadderIconType iconType = EShareLadderIconType.None, bool showIIVLogo = false, bool isProfileInfo = false, string extraFilePath = null, Camera[] cameras = null)
	{
	}

	private IEnumerator _TakeScreenshotAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, Action onClose = null, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool isHideFFlogo = false, int frameCount = 1, uint awardItemID = 0u, uint brSeasonId = 0u, uint csSeasonId = 0u, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, EShareLadderIconType iconType = EShareLadderIconType.None, bool showIIVLogo = false, bool isProfileInfo = false, string extraFilePath = null, Camera[] cameras = null)
	{
		return null;
	}

	public void ShowRectTweenTips(string tips)
	{
	}

	public void SaveHighlightScreenshotInGame(string filePath, AlbumPhotoInfo highlightAlbumPhotoInfo, RenderTexture rt)
	{
	}

	public void TakeScreenshotInSystem(string filePath, bool isShowScreenShotMessageWindow)
	{
	}

	public void TakeScreenShotWithoutSave(UIUtils.ScreenshotType screenshotType, UIBaseController target, Action<Texture2D> onScreenShotFinish, bool hasTopBar = true, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false)
	{
	}

	private IEnumerator _TakeScreenShotWithoutSave(UIUtils.ScreenshotType screenshotType, UIBaseController target, Action<Texture2D> onScreenShotFinish, bool hasTopBar, bool hasLeftBar, UIUtils.EShareScreenType screenType, bool hideUserID, bool shareUrl)
	{
		return null;
	}

	protected virtual bool OnCheckGroupNtf()
	{
		return false;
	}

	protected void OnInviteNtf(object[] data)
	{
	}

	protected void OnJoinRequestNtf(object[] data)
	{
	}

	protected void OnAcceptJoinNtf(object[] data)
	{
	}

	protected void ProcessInviteTip(object[] data)
	{
	}

	protected virtual void ProcessInviteTipImmediately(object[] data)
	{
	}

	protected void OpenInvitationTipsBox(object[] args)
	{
	}

	protected void OnInvitationTipsClose(object[] data)
	{
	}

	public bool HasInvitationTipsBoxData()
	{
		return false;
	}

	public void CacheAndCloseInvitationTipsBox()
	{
	}

	public void RestoreInvitationTipsBox()
	{
	}

	protected bool CheckUGCAcceptFriendInvite(ulong account_id)
	{
		return false;
	}

	public override bool NavigationCanAccess(string navigationName)
	{
		return false;
	}

	public void ShowDynamicLayoutDetailTips<T>(Vector3 worldPosition, object contentViewData, bool screenClippingCheck = false) where T : UIBaseController, IDynamicLayoutDetailTipsContent
	{
	}

	public void TakeCombineScreenshotWithAction(string filePath, int count, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, Action onClose = null, bool hasLeftBar = true, bool hideUserID = false, bool shareUrl = false, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool isHideFFlogo = false)
	{
	}

	private IEnumerator _TakeCombineScreenshotAction(string filePath, int count, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, Action onClose = null, bool hasLeftBar = true, bool hideUserID = false, bool shareUrl = false, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool isHideFFlogo = false)
	{
		return null;
	}

	public void ShowCombineShareImageFileMessageBox(UIBaseController target, ShareImageData data, Action onClose = null, uint changedepth = 0u, bool shareUrl = false, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint shareActivityId = 0u, string pageTile = null, bool autoSave = false)
	{
	}

	public virtual UIUGCBridgingGameScene GetUIUGCScene()
	{
		return null;
	}

	public virtual void ShowPopupMessage(string message, float duration = 2f, bool forceShow = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public UIBaseNavigationController _003C_003EiFixBaseProxy_PushNavigation(Type P0, UINavigationData P1, bool P2, UIControllerContext P3)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NavigationCanAccess(string P0)
	{
		return false;
	}
}
