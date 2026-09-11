using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBotAgentMarkBtnView : UIBaseView
{
	public UIEventListener EventListener;

	public Transform BtnMark;

	public UISprite CDProgress;

	public GameObject cancelIcon;

	public GameObject cancelActiveIcon;

	public GameObject NormalIcon;

	public GameObject MoveTipContainer;

	public UISprite MoveTipIcon;

	public UISprite bg;

	public UISprite Sprite;

	public GameObject CtrlPanel;

	public UITable Table;

	public UIButton CloseBtn;

	public UISlider VolumeSlider;

	public BotAgentQuestionItem AskTemplate;

	public Transform EndTrans;

	public UIWidget ExtraMarkGroup;

	public UIWidget BubbleContainer;

	public UISprite BubbleBG;

	public UILabel BubbleLabel;

	public UISprite CtrlBg;

	public GameObject LeftArrow;

	public GameObject RightArrow;

	public UILabel ModelNameLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
