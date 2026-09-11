using GCommon;
using UnityEngine;

namespace COW;

public class UIImageSharePreviewWindowView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnClosePortrait;

	public Transform ShareBtnGroupContainer;

	public Transform LandscapeGroup;

	public UIButton BtnDownloadToAlbum;

	public UIButton CopyShareLink;

	public UIGrid Grid;

	public UILabel ShareHint;

	public UIButton BtnLineShare;

	public UIButton BtnFBShare;

	public UIButton BtnVKShare;

	public UIButton BtnGarenaShare;

	public UIButton BtnOtherShare;

	public Transform PortraitGroup;

	public UIButton CopyShareLink_P;

	public UIButton BtnDownloadToAlbum_P;

	public UIGrid Grid_P;

	public UIButton BtnLineShare_P;

	public UIButton BtnFBShare_P;

	public UIButton BtnVKShare_P;

	public UIButton BtnGarenaShare_P;

	public UIButton BtnOtherShare_P;

	public UITexture SharePreview;

	public UIPanel TipsPanel;

	public TweenAlpha TipsTween;

	public UILabel TipTxt;

	public GameObject FBMessageIcon;

	public GameObject FaceBookIcon;

	public UIButton BtnWorldChannelShare;

	public UIButton BtnGuildChannelShare;

	public GameObject Line;

	public UISprite SpriteWorldChannelShare;

	public UITable TableAppShare;

	public UIGrid Grid_New;

	public UIAnchor AppShare;

	public UIButton BtnWhatsAppShare;

	public UIButton BtnInstgramShare;

	public UIButton BtnWhatsAppShare_P;

	public UIButton BtnInstagramShare_P;

	public UILabel PageTitle;

	public UIButton FrameBtn;

	public GameObject FrameContainer;

	public GameObject EmojiContainer;

	public UIButton EmojiBtn;

	public GameObject FrameContainer_P;

	public GameObject EmojiContainer_P;

	public UIButton FrameBtn_P;

	public UIButton EmojiBtn_P;

	public Transform EmojiItemContainer;

	public UIPanel EmojiItemScrollView;

	public Transform FrameWindowPos_P;

	public Transform StickerWindowPos_P;

	public Transform FrameWindowPos;

	public Transform StickerWindowPos;

	public UITexture FrameCDN;

	public UINetworkTexture FrameCDNNetworkTexture;

	public Transform BarContainer;

	public UIButton HelpBtn;

	public UISprite HelpBtnSprite;

	public UITexture FrameCDN_P;

	public UINetworkTexture FrameCDNNetworkTexture_P;

	public UITexture FrameCDN_IOS;

	public UINetworkTexture FrameCDNNetworkTexture_IOS;

	public UITexture FrameCDN_P_IOS;

	public UINetworkTexture FrameCDNNetworkTexture_P_IOS;

	public Transform StickerRedTip;

	public Transform StickerRedTip_P;

	public GameObject FFlogoLandScapeView;

	public UISprite FFLogo;

	public UISprite FFLogoMax;

	public GameObject SeasonInfo;

	public UILabel SeasonIdLabel;

	public UILabel TimeSpanLabel;

	public GameObject FFlogoPortraitView;

	public UISprite FFLogo_P;

	public UISprite FFLogoMax_P;

	public UISprite CobrandedLogo;

	public UISprite CobrandedLogo_P;

	public UISprite CobrandedDesc_P;

	public UISprite CobrandedDesc;

	public Transform SharePreviewLeftTop;

	public Transform SharePreviewLeftBottom;

	public Transform SharePreviewRightTop;

	public Transform SharePreviewRightBottom;

	public UIWidget FrameAndStickerGuideWidget;

	public GameObject ImageChangeContainer;

	public GameObject PosterPageContainer;

	public GameObject OriginPageContainer;

	public UIButton PosterPageBtn;

	public UIButton OriginPageBtn;

	public UIButton RightArrowBtn;

	public UIButton LeftArrowBtn;

	public GameObject PosterPageUnSelected;

	public GameObject PosterPageSelected;

	public GameObject OriginPageUnSelected;

	public GameObject OriginPageSelected;

	public Transform PhotoFrameNewTip;

	public Transform PhotoFrameNewTip_P;

	public UIButton LeftArrowBtn_Vertical;

	public UIButton RightArrowBtn_Vertical;

	public UIButton UnSelectStickerBtn;

	public Transform HighlightPhotoContainer;

	public Transform QRCodeContainer;

	public UIPanel InfoContainer;

	public UIButton BtnShowQRCode;

	public UIWidget BtnShowQRCodeWidget;

	public UIToggle ShowQRCodeToggle;

	public GameObject Checkmark;

	public UIAnchor EditContainer;

	public UIGrid LeftGrid;

	public GameObject FunResultPageContainer;

	public UIPanel FramePanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
