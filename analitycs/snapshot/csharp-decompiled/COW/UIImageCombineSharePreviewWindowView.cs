using GCommon;
using UnityEngine;

namespace COW;

public class UIImageCombineSharePreviewWindowView : UIBaseView
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

	public UIPanel Scrollview;

	public UITexture PreviewTexture;

	public UIWidget SharePreview;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
