using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedELS_TT53CardPoolItemView : UIBaseView
{
	public UIButton ItemBtn;

	public BaseItemView2 RewardItem;

	public UISprite Sprite;

	public GameObject MaxState;

	public GameObject OwnState;

	public UILabel MaxNumberLabel;

	public UILabel OwnLabel;

	public Transform BigPrizeVFX;

	public Transform ClickVFX;

	public UIButton FullScreenPreviewBtn;

	public GameObject SelectedContainer;

	public Animation Ani;

	public AnimEvtForwarderIncludeParam AnimEvtForwarder;

	public AnimatedAlpha AnimatedAlpha;

	public Transform Pos;

	public GameObject ClaimedState;

	public GameObject RedDot;

	public GameObject Mask;

	public GameObject ExchangeVoucher;

	public UILabel UILabelVoucherCntLabel;

	public TweenAlpha TweenAlphaVoucherCntLabel;

	public TweenAlphaWatcher TweenAlphaWatcherVoucherCntLabel;

	public UISprite ExchangeItemTopLeftIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
