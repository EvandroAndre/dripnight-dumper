using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

internal abstract class UIImageSharePreviewWindowBaseController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private class TakeScreenShotForEditorShareContext
	{
		public enum ContextType
		{
			None,
			Download,
			Share
		}

		public ContextType EContextType;

		public EventLogger.SharePlatform SharePlatform;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__184_0;

		public static Converter<BundleShowData, uint> _003C_003E9__194_0;

		internal void _003CDoneShare_003Eb__184_0(HttpErrorCode errCode, object obj)
		{
		}

		internal uint _003CCheckItemIsUponOrangeQuailty_003Eb__194_0(BundleShowData i)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass196_0
	{
		public int hashCode;

		internal bool _003CDeleteEditableSticker_003Eb__0(UIEditableIconBaseController e)
		{
			return false;
		}

		internal bool _003CDeleteEditableSticker_003Eb__1(UIEditableIconBaseController e)
		{
			return false;
		}
	}

	private sealed class _003CTakeScreenShotForWebView_003Ed__187 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIImageSharePreviewWindowBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTakeScreenShotForWebView_003Ed__187(int _003C_003E1__state)
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

	protected Vector2 ScreenShotForEditorOffset;

	public Action OnClose;

	public bool IsShareGridBtnClick;

	protected ShareSettingDesc m_ShareSetting;

	protected UIBaseController m_Target;

	protected const uint HEIGHTOFFSETINPORTRAIT = 24u;

	protected const uint HELPBTNOFFSET = 30u;

	protected UIModelChat m_ModelChat;

	protected UIModelTakePhoto m_ModelTakePhoto;

	protected uint m_ShareWeaponSkinId;

	protected uint m_SharActivityId;

	protected uint m_AwardItemID;

	protected bool m_HasTopBar;

	protected bool m_HasLeftBar;

	protected bool m_IsProfileInfo;

	protected bool m_IsShowIIVLogo;

	protected EShareLadderIconType m_IconType;

	protected EventLogger.EventShareExtraInfoBase m_EventLogExtraInfo;

	protected uint m_EventLogMatchResultPosterCommentsId;

	private Camera m_CameraForShareEditor;

	private GameObject m_SharePreviewForEditor;

	protected UIImageShareCaptureWidgetController ImageShareCaptureWidgetCtrl;

	protected GameObject LeftTopBarBg;

	protected GameObject LeftBottomBg;

	private UICommonGuideController m_CommonGuidController;

	protected Dictionary<uint, List<UIEditableIconBaseController>> m_EditableIconDict;

	protected Dictionary<uint, uint> m_EditableIconNumDict;

	protected List<UIEditableIconBaseController> m_EditableIconForDepthList;

	private Dictionary<int, int> m_FrameClickUseCnt;

	private Dictionary<int, int> m_StickerClickUseCnt;

	public bool HasEditPhotoAfterLastSave;

	private Vector2 m_StickerRandomOffset;

	protected float CallSignSizeX;

	protected UIImageShareEmojiSelectPopController m_ImageShareEmojiSelectPopCtrl;

	protected UIImageShareFrameSelectPopController m_ImageShareFrameSelectPopCtrl;

	protected string CurFilePath;

	private TextureIconCDNResource m_NowCDNRes;

	private ResourceID m_CurFrameRes;

	private uint m_CurFrameID;

	private UIClickMask m_StickerUnSelectMask;

	private TakeScreenShotForEditorShareContext m_ShareContext;

	protected UIButton BtnClose;

	protected UIButton BtnClosePortrait;

	protected Transform ShareBtnGroupContainer;

	protected Transform LandscapeGroup;

	protected UIButton BtnDownloadToAlbum;

	protected UIButton CopyShareLink;

	protected UIGrid Grid;

	protected UILabel ShareHint;

	protected UIButton BtnLineShare;

	protected UIButton BtnFBShare;

	protected UIButton BtnVKShare;

	protected UIButton BtnGarenaShare;

	protected UIButton BtnOtherShare;

	protected Transform PortraitGroup;

	protected UIButton CopyShareLink_P;

	protected UIButton BtnDownloadToAlbum_P;

	protected UIGrid Grid_P;

	protected UIButton BtnLineShare_P;

	protected UIButton BtnFBShare_P;

	protected UIButton BtnVKShare_P;

	protected UIButton BtnGarenaShare_P;

	protected UIButton BtnOtherShare_P;

	protected UIPanel TipsPanel;

	protected TweenAlpha TipsTween;

	protected UILabel TipTxt;

	protected GameObject FBMessageIcon;

	protected GameObject FaceBookIcon;

	protected UIButton BtnWorldChannelShare;

	protected UIButton BtnGuildChannelShare;

	protected GameObject Line;

	protected UISprite SpriteWorldChannelShare;

	protected UITable TableAppShare;

	protected UIGrid Grid_New;

	protected UIAnchor AppShare;

	protected UIButton BtnWhatsAppShare;

	protected UIButton BtnInstgramShare;

	protected UIButton BtnWhatsAppShare_P;

	protected UIButton BtnInstagramShare_P;

	protected UILabel PageTitle;

	protected UITexture SharePreviewTexture;

	protected Transform EmojiItemContainer;

	protected UIButton BtnFrame;

	protected UIButton BtnFrame_P;

	protected UIButton BtnEmoji;

	protected UIButton BtnEmoji_P;

	protected Transform FrameSelectPopTransform;

	protected Transform FrameSelectPopTransform_P;

	protected Transform EmojiSelectPopTransform;

	protected Transform EmojiSelectPopTransform_P;

	protected UITexture CurFrameCDN;

	protected UITexture FrameCDN;

	protected UITexture FrameCDN_P;

	protected UITexture FrameCDN_IOS;

	protected UITexture FrameCDN_P_IOS;

	protected UINetworkTexture CurFrameCDNNetworkTexture;

	protected UINetworkTexture FrameCDNNetworkTexture;

	protected UINetworkTexture FrameCDNNetworkTexture_P;

	protected UINetworkTexture FrameCDNNetworkTexture_IOS;

	protected UINetworkTexture FrameCDNNetworkTexture_P_IOS;

	protected UIButton BtnHelp;

	protected UISprite BtnHelpSprite;

	protected UIPanel EmojiItemScrollViewPanel;

	protected GameObject FrameContainer;

	protected GameObject EmojiContainer;

	protected GameObject FrameContainer_P;

	protected GameObject EmojiContainer_P;

	protected GameObject FFlogoLandScapeView;

	protected UISprite FFLogo;

	protected UISprite FFLogoMax;

	protected GameObject FFLogoPortraitView;

	protected UISprite FFLogo_P;

	protected UISprite FFLogoMax_P;

	protected GameObject SeasonInfo;

	protected UILabel SeasonIdLabel;

	protected UILabel TimeSpanLabel;

	protected UISprite CobrandedLogo;

	protected UISprite CobrandedLogo_P;

	protected UISprite CobrandedDesc;

	protected UISprite CobrandedDesc_P;

	protected Transform SharePreviewLeftTop;

	protected Transform SharePreviewLeftBottom;

	protected Transform SharePreviewRightTop;

	protected Transform SharePreviewRightBottom;

	protected UIWidget FrameAndStickerGuideWidget;

	protected UIButton PosterPageBtn;

	protected UIButton OriginPageBtn;

	protected GameObject ImageChangeContainer;

	protected UIButton StickerUnSelectBtn;

	protected byte[] m_OriginPageImage;

	protected byte[] m_PosterPageImage;

	protected Transform QRCodeContainer;

	protected UIToggle ShowQRCodeToggle;

	protected UIButton ShowQRCodeBtn;

	protected UIWidget ShowQRCodeBtnWidget;

	protected UIAnchor EditContainer;

	protected UIGrid LeftGrid;

	protected int m_TextureHeight;

	protected int m_TextureWidth;

	protected Vector2 m_EditContainerOffset;

	protected bool m_IsUseQRCode;

	protected ShareImageData m_Data;

	protected bool m_ShareUrl;

	private Thread _Thread_SaveImageToAlbum;

	private const uint IIVHorizontalFrameID = 926005201u;

	protected UICommonGuideController CommonGuidController => null;

	protected virtual void BeforeShareEditorScreenshot()
	{
	}

	protected virtual void AfterShareEditorScreenshot()
	{
	}

	protected virtual bool ShouldTakeScreenShotForEditorByPreviewRegion()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnCloseClick()
	{
	}

	public void ShareImage(UIBaseController target, ShareImageData data, bool shareUrl = false, ShareSettingDesc shareSetting = null, uint shareWeaponSkinId = 0u, uint sharActivityId = 0u, string pageTile = null, uint awardItemID = 0u, bool hasLeftBar = false, EShareLadderIconType iconType = EShareLadderIconType.None, EventLogger.EventShareExtraInfoBase eventLogExtraInfo = null, uint brSeasonId = 0u, uint csSeasonId = 0u, bool showIIVLogo = false, bool isProfileInfo = false)
	{
	}

	protected abstract void UpdateShareImage();

	protected virtual int GetCurrentShareLogPageId()
	{
		return 0;
	}

	private void UpdateUI()
	{
	}

	private void RefreshWeaponChannelShareGuid(uint weaponSkinID)
	{
	}

	private void RefreshHelpBtn()
	{
	}

	private void ShowGuidWithWidgetAndTime(UIWidget widget, float time, UIAnchor.Side side, int depth)
	{
	}

	private void OnShareClick(EventLogger.SharePlatform platform)
	{
	}

	private void Share(EventLogger.SharePlatform platform)
	{
	}

	private void SendBigEventShareLog(bool success, uint platform)
	{
	}

	private void SendLimitedEventShareLog(uint id, uint platform, uint pageId, uint type, bool success)
	{
	}

	private void SendPortraitCloseupShareLog(uint platform)
	{
	}

	private bool OnShareLineBtnClick()
	{
		return false;
	}

	private bool OnShareVKBtnClick()
	{
		return false;
	}

	private bool OnOtherShareBtnClick()
	{
		return false;
	}

	private bool OnShareFBBtnClick()
	{
		return false;
	}

	private bool OnShareWhatsAppBtnClick()
	{
		return false;
	}

	private bool OnShareInstagramBtnClick()
	{
		return false;
	}

	private bool OnShareWorldChannelBtnClick()
	{
		return false;
	}

	private bool OnShareGuildChannelBtnClick()
	{
		return false;
	}

	public void OnDownloadToAlbumBtnClick()
	{
	}

	private void _SaveImageToAlbum(object param)
	{
	}

	private void DownloadToAlbum()
	{
	}

	private void OnImageSaveToAlbumDone(string originalFilePath, string nativeId, string error)
	{
	}

	private void OnCopyLink()
	{
	}

	private void OnBtnHelpClick()
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	protected virtual void OnPosterPageBtnClick()
	{
	}

	protected virtual void OnOriginPageBtnClick()
	{
	}

	private void ChangeShareImage()
	{
	}

	public void ClearCurStickerAndFrame()
	{
	}

	private void DoneShare(bool success, EventLogger.SharePlatform sharePlatform)
	{
	}

	private EChannel.ChannelType GetChatType(EventLogger.SharePlatform sharePlatform)
	{
		return EChannel.ChannelType.ChannelType_GROUP;
	}

	protected void TakeScreenShotForEditor()
	{
	}

	private IEnumerator TakeScreenShotForWebView()
	{
		return null;
	}

	private void AfterShareEditorScreenShot()
	{
	}

	protected virtual void CreateEditableSticker(object[] data)
	{
	}

	public Vector3 GetWorldPosByDefaultShow(float[] defaultShowPos)
	{
		return default(Vector3);
	}

	private Vector3 GetRandomCreatePosition()
	{
		return default(Vector3);
	}

	private void CheckDepthLimitAndResetDepth()
	{
	}

	public void SetStickerToMaxDepth(int hashCode)
	{
	}

	private bool CheckItemIsUponOrangeQuailty(uint itemID)
	{
		return false;
	}

	private void ChangeEditableIconNum(uint key, bool isPlus)
	{
	}

	protected virtual void DeleteEditableSticker(object[] data)
	{
	}

	private bool CheckStickerIsNumLimit(StickerConfigDesc stickerConfig)
	{
		return false;
	}

	private uint GetCurStickerExistNum(StickerConfigDesc stickerConfig)
	{
		return 0u;
	}

	private Vector3 TransDefaultShowPosToWorldPos(Vector2 defaultPos)
	{
		return default(Vector3);
	}

	private void CheckAndCreateDefaultSticker()
	{
	}

	private void CreateProfileInfoSticker()
	{
	}

	public void UnselectAllCurSticker()
	{
	}

	public void SetStickerUnSelectBtn(bool enable)
	{
	}

	private void ChangeCurFrame(object[] data)
	{
	}

	public void SetPrimeBadge(ResourceID res)
	{
	}

	public void SetPrimeBadge(string cdnUrl)
	{
	}

	protected virtual void SetCobrandedView(FrameSelectItemData frameData)
	{
	}

	protected void HideCobrandedView()
	{
	}

	private void UnRegisterCDNUrl()
	{
	}

	private void OnClickFrameBtn(bool isVertical)
	{
	}

	private void OnClickEmojiBtn(bool isVertical)
	{
	}

	private void SetEditFlag()
	{
	}

	private List<uint> GetCurStickerList()
	{
		return null;
	}

	private void TryShowIIVCobrandLogo()
	{
	}

	private void UpdateSeasonInfo(uint brSeasonId = 0u, uint csSeasonId = 0u)
	{
	}

	private void RefreshFrameAndStickerGuide()
	{
	}

	private void CheckAndSetEventLogMatchResultPosterCommentsId()
	{
	}

	private void RecordStickerClick(int stickerID)
	{
	}

	private void RecordFrameClick(int frameID)
	{
	}

	private void SendShareFrameStickerUseLog(int platform, int pageId, bool share_out)
	{
	}

	private List<EventLogger.EventTypeShareStickerClickInfo> GetCurStickerClickInfo()
	{
		return null;
	}

	private List<EventLogger.EventTypeShareFrameClickInfo> GetCurFrameClickInfo()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] data)
	{
	}

	public virtual bool IsUGCPreviewWindow()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__147_0()
	{
	}

	private void _003COnUIInit_003Eb__147_1()
	{
	}

	private void _003COnUIInit_003Eb__147_2()
	{
	}

	private void _003COnUIInit_003Eb__147_3()
	{
	}

	private void _003COnUIInit_003Eb__147_4()
	{
	}

	private void _003COnUIInit_003Eb__147_5()
	{
	}

	private void _003COnUIInit_003Eb__147_6()
	{
	}

	private void _003COnUIInit_003Eb__147_7()
	{
	}

	private void _003COnUIInit_003Eb__147_8()
	{
	}

	private void _003COnUIInit_003Eb__147_9()
	{
	}

	private void _003COnUIInit_003Eb__147_10()
	{
	}

	private void _003COnUIInit_003Eb__147_11()
	{
	}

	private void _003COnUIInit_003Eb__147_12()
	{
	}

	private void _003COnUIInit_003Eb__147_13()
	{
	}

	private void _003COnUIInit_003Eb__147_14()
	{
	}

	private void _003COnUIInit_003Eb__147_15()
	{
	}

	private void _003COnUIInit_003Eb__147_16()
	{
	}

	private void _003COnUIInit_003Eb__147_17()
	{
	}

	private void _003C_SaveImageToAlbum_003Eb__174_0(string _filePath, string nativeId, string saveError)
	{
	}

	private void _003CDownloadToAlbum_003Eb__175_0(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus auth, string error)
	{
	}

	private void _003CSetPrimeBadge_003Eb__205_0(bool result)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
