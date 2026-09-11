using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatWindowView : UIBaseView
{
	public UILabel Title;

	public UIButton BtnClose;

	public GameObject MessageContainer;

	public UIInput InputContainer;

	public UIButton EnterBtn;

	public UIWidget ContainerWidget;

	public UIHUDAIChatDragItem DragItem;

	public GameObject DisableMask;

	public UIButton MicrophoneBtn;

	public GameObject MicrophoneSprite;

	public GameObject CancelSprite;

	public GameObject RecordContainer;

	public GameObject RecordIcon;

	public UILabel RecordLabel;

	public UIProgressBar RecordProgress;

	public UILabel RecordCountDown;

	public TweenScale CountDownTweenScale;

	public TweenAlpha CountDownTweenAlpha;

	public UISprite InputDefaultBg;

	public UILabel InputDefaultLabel;

	public UISprite ForeGround;

	public GameObject EnableMask;

	public GameObject Stand;

	public GameObject UIFX;

	public UIPanel WindowPanel;

	public UIButton ScrollToBottomBtn;

	public GameObject SendMessageContainer;

	public GameObject ForbiddenContainer;

	public UICountDownLabel CountDownLabel;

	public UIButton HelpBtn;

	public GameObject RecordContainerV2;

	public UIButton MicrophoneV2Btn;

	public GameObject MicrophoneV2Sprite;

	public GameObject CancelV2Sprite;

	public GameObject MircophoneVFX;

	public UIPanel Bottom;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
