using GCommon;
using UnityEngine;

namespace COW;

public class ReplayKitVideoPreviewWindowView : UIBaseView
{
	public UIButton BtnClose;

	public UITexture videoTexture;

	public FFVideoPlayer videoPlay;

	public UIButton PauseBtn;

	public UIButton PlayBtn;

	public UILabel DurationText;

	public UISlider GameTimeSlider;

	public UILabel TimeText;

	public UILabel NameText;

	public GameObject PlayError;

	public UIButton UIButtonBtnOtherShare;

	public UIWidget OtherBtnWidget;

	public UIButton BtnTikTok;

	public UIButton BtnSave;

	public UILabel SizeLabel;

	public GameObject RecordPreviewContainer;

	public GameObject ShareBtnGrid;

	public GameObject bg;

	public UISprite PreviewBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
