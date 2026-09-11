using GCommon;
using UnityEngine;

namespace COW;

public class UISplashBannerItemLiveTVView : UIBaseView
{
	public UIPanel WebViewPanel;

	public GameObject Container;

	public TweenScale ScaleTween;

	public TweenPosition PosTween;

	public UIPanel ContainerPanel;

	public UILabel Title;

	public UISprite BG;

	public UINetworkTexture NetworkTextureBG;

	public GameObject Content;

	public UIButton LiveCloseBtn;

	public UIButton DetailBtn;

	public UISprite DetailBtnWidget;

	public UIButton FullScreenPlayBtn;

	public UISprite FullScreenBtnWidget;

	public UITexture LiveWebViewWidget;

	public UINetworkTexture liveBgTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
