using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardView : UIBaseView
{
	public UINetworkTexture Left_TextureTitle;

	public UIButton Left_RuleBtn;

	public UILabel Left_OpenTimeLabel;

	public UIButton Right_BtnClose;

	public GameObject Right_CloseBtnSprite;

	public UINetworkTexture Right_CloseBtnTexture;

	public UIGrid GridLeftBtns;

	public UINetworkTexture TextureBg;

	public UISprite Left_OpenTime;

	public Transform RightContainer;

	public Transform CenterContainer;

	public UIButton InterfaceContentMask;

	public UIGrid GridBottomLeftBtns;

	public UIPanel GuidePanel;

	public GameObject Wish_Token;

	public UINetworkTexture Right_CloseBtnBgTexture;

	public GameObject Draw_Token;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
