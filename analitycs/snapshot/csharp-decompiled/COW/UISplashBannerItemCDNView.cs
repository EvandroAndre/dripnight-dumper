using GCommon;
using UnityEngine;

namespace COW;

public class UISplashBannerItemCDNView : UIBaseView
{
	public UIPanel WebViewPanel;

	public UISplashBannerItemCDNHelperUtil UISplashBannerItemCDNHelperUtil;

	public UILabel Title;

	public UIButton close;

	public UINetworkTexture NetworkTextureContent;

	public UIButton NetworkTextureContentButton;

	public GameObject EventTrigger;

	public UIButton SpecialBtn;

	public UILabel BtnDontShowLabel;

	public UIToggle BtnDontShow;

	public GameObject DontShowContainer;

	public Transform WishBtnContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
