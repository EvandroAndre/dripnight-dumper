using GCommon;
using UnityEngine;

namespace COW;

public class UILuckWheelRewardPoolItemView : UIBaseView
{
	public Animation Animation;

	public Transform RewardItem;

	public UIButton BuyBtn;

	public UISprite BuyBntSprite;

	public GameObject Discount;

	public UILabel DiscountPrice;

	public UISprite DiscountCoinIcon;

	public UILabel OriginPrice;

	public GameObject Normal;

	public UILabel NormalPrice;

	public UISprite NormalCoinIcon;

	public UILabel BuyLabel;

	public GameObject VFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
