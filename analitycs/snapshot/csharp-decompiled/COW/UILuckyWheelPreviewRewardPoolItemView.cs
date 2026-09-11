using GCommon;
using UnityEngine;

namespace COW;

public class UILuckyWheelPreviewRewardPoolItemView : UIBaseView
{
	public TweenScale ItemTween;

	public Animation Animation;

	public UISprite IPTag;

	public UIButton ItemBtn;

	public UIDragScrollView ItemDragView;

	public GameObject HotFlag;

	public BaseItemView RewardItem;

	public UISprite QualityBG;

	public UISprite QualityNameBG01;

	public GameObject IconGroup;

	public UISprite Sprite_Debris;

	public UISprite VoucherIcon;

	public UILabel LimitLabel;

	public UILabel QuantityLabel;

	public GameObject OwnedTitle;

	public GameObject BuyedFlag;

	public GameObject Descargar;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UILabel DiscountLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
