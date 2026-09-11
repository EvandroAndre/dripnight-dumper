using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartShoppingCartBoxContentItemView : UIBaseView
{
	public TweenScale ItemTween;

	public UIWidget Widget;

	public UIButton ItemBtn;

	public UIDragScrollView ItemDragView;

	public BaseItemView2 RewardItem;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite QualityNameBG01;

	public UISprite Icon;

	public UILabel LimitLabel;

	public UILabel QuantityLabel;

	public GameObject LimitedTitle;

	public GameObject ClaimedTitle;

	public GameObject LadderGotTitle;

	public GameObject OwnedTitle;

	public GameObject Descargar;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UILabel CanNotEquipTitle;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject Effect_Glow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
