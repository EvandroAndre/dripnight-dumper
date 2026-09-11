using GCommon;
using UnityEngine;

namespace COW;

public class UISplashBannerFullScreenView : UIBaseView
{
	public UIPanel WebViewPanel;

	public UISplashBannerItemCDNHelperUtil CDNHelper;

	public GameObject Container;

	public TweenScale ScaleTween;

	public TweenPosition PosTween;

	public UIPanel ContainerPanel;

	public UILabel Title;

	public UISprite BG;

	public UINetworkTexture NetworkTextureBG;

	public UIButton DetailsBtn;

	public UIButton CloseBtn;

	public GameObject DontShowContainer;

	public UIToggle DontShowBtn;

	public UILabel DontShowLabel;

	public UIWidget TriggerWidget;

	public Transform WishListBtnContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
