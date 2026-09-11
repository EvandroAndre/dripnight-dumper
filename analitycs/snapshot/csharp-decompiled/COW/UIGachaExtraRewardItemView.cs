using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaExtraRewardItemView : UIBaseView
{
	public TweenScale ItemTween;

	public UIButton ItemBtn;

	public UIDragScrollView ItemDragView;

	public BaseItemView RewardItem;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite QualityNameBG01;

	public GameObject IconGroup;

	public UISprite Sprite_Debris;

	public UISprite VoucherIcon;

	public UILabel LimitLabel;

	public UILabel QuantityLabel;

	public GameObject LimitedTitle;

	public GameObject ClaimedTitle;

	public GameObject LadderGotTitle;

	public GameObject OwnedTitle;

	public GameObject Descargar;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UISprite SpriteOrangeQualityPlus;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
