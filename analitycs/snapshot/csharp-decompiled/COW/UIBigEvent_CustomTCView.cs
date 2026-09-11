using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTCView : UIBaseView
{
	public UINetworkTexture Left_TextureTitle;

	public UIButton Left_RuleBtn;

	public UICountDownLabel Left_CountDown;

	public UIButton Right_BtnClose;

	public GameObject Right_CloseBtnSprite;

	public UINetworkTexture Right_CloseBtnTexture;

	public UIGrid GridLeftBtns;

	public UINetworkTexture TextureBg;

	public UISprite Left_TimeIcon;

	public Transform RightContainer;

	public Transform CenterContainer;

	public UIGrid GridBottomLeftBtns;

	public UIPanel GuidePanel;

	public UINetworkTexture Right_CloseBtnBgTexture;

	public GameObject TokenRoot;

	public GameObject TutorialRoot;

	public Animation MainAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
