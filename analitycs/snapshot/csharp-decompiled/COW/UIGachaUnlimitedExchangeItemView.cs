using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaUnlimitedExchangeItemView : UIBaseView
{
	public TweenScale ItemTween;

	public UIButton ItemBtn;

	public UIDragScrollView ItemDragView;

	public GameObject LimitedTitle;

	public GameObject ClaimedTitle;

	public GameObject LadderGotTitle;

	public GameObject OwnedTitle;

	public GameObject Descargar;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UILabel ExchangePriceLabel;

	public UISprite ExchangeIcon;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public UISprite Quality;

	public BaseItemView2 RewardItem;

	public UITable ExchangeContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
