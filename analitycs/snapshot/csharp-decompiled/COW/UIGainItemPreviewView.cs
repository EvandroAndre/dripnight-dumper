using GCommon;
using UnityEngine;

namespace COW;

public class UIGainItemPreviewView : UIBaseView
{
	public GameObject Content;

	public UIButton btnClose;

	public UISprite ScreenshotTopBanner;

	public UINetworkTexture HeadshotRemote;

	public GameObject HeadshotDefault;

	public UIEffectSprite HeadshotLocal;

	public UILabel PlayerNickname;

	public UILabel PlayerID;

	public UIButton ShareBtn;

	public Animator ShareIconAnimator;

	public UIButton leaveBtn;

	public UISprite iconBg;

	public UISprite ItemIcon;

	public UIWidget PreViewCommonContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
