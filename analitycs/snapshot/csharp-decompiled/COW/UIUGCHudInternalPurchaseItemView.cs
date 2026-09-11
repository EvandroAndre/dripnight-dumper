using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudInternalPurchaseItemView : UIBaseView
{
	public UISprite itemSprite;

	public UILabel ItemName;

	public UILabel Price;

	public GameObject TimeLimitRoot;

	public UILabel TimeLimit;

	public UIButton ItemBtn;

	public GameObject GrayMask;

	public GameObject LimitedGroup;

	public UILabel ListLimitedText;

	public UILabel PersonalPurchasedCount;

	public GameObject defaultTitleBg;

	public GameObject defaultBackBg;

	public GameObject HighlightTitleBg;

	public GameObject HighlightBackBg;

	public UIWidget UnderMaskGroupWidget;

	public UISprite TokenIcon;

	public UINetworkTexture ItemTexture;

	public GameObject Banner;

	public UILabel BannerLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
