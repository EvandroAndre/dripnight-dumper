using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDLLMChatMessageItemView : UIBaseView
{
	public GameObject RightView;

	public GameObject LeftView;

	public GameObject RightContentContainer;

	public GameObject RightContentLoadingIcon;

	public UILabel RightContent;

	public BoxCollider RightBannerBoxCollider;

	public UIButton RightBannerButton;

	public UISprite RightBanner;

	public GameObject LeftContentContainer;

	public GameObject LeftContentLoadingIcon;

	public UILabel LeftContent;

	public BoxCollider LeftBannerBoxCollider;

	public UIButton LeftBannerButton;

	public UISprite LeftBanner;

	public UITable LeftContentTable;

	public UITable RightContentTable;

	public UISprite LeftHeadIcon;

	public UISprite RightHeadIcon;

	public UIColor ColorBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
