using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentGrowthFundV2View : UIBaseView
{
	public UIScrollView BundlesScrollView;

	public UIEasyList BundlesScrollViewGrid;

	public UISprite ArrowRight;

	public UISprite ArrowLeft;

	public GameObject VFX_UI_Fund_01;

	public UIButton Hint;

	public UILabel RebateLabel;

	public UINetworkTexture Cdn_RebateLabel;

	public UINetworkTexture Cdn_Kelly;

	public Animation main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
