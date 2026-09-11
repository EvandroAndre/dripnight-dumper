using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedCardPoolItemView : UIBaseView
{
	public UIButton ItemBtn;

	public BaseItemView2 RewardItem;

	public UISprite Sprite;

	public GameObject MaxState;

	public GameObject OwnState;

	public UILabel MaxNumberLabel;

	public UILabel OwnLabel;

	public Transform BigPrizeVFX;

	public VFXCreateHelper BigPrizeVFXHelper;

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

	public UILabel VoucherCntLabel;

	public TweenAlpha VoucherTweenAlpha;

	public TweenAlphaWatcher VoucherTweenWatcher;

	public UISprite ExchangeItemTopLeftIcon;

	public GameObject ClaimableState;

	public GameObject UIFX_Saoguang;

	public VFXCreateHelper UIFX_SaoguangVFXHelper;

	public VFXCreateHelper UIFX_BoomVFXHelper;

	public VFXCreateHelper UIFX_GlowVFXHelper;

	public VFXCreateHelper UIFX_SelectVFXHelper;

	public VFXCreateHelper UIFX_DownVFXHelper;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
