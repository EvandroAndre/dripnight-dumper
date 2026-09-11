using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaLengendaryExtraListItemView : UIBaseView
{
	public UISprite TokenIcon;

	public UILabel TokenNumChangedlLabel;

	public UIButton ClickButon;

	public GameObject ItemUnLock;

	public GameObject ItemGained;

	public GameObject Item;

	public BaseItemView RewardItem;

	public UISprite QualityBG;

	public UISprite SpritePurplePlus;

	public UISprite QualityNameBG01;

	public GameObject IconGroup;

	public UISprite Sprite_Debris;

	public UISprite VoucherIcon;

	public UILabel QuantityLabel;

	public Transform VfxRareReward;

	public UISprite PrizeBg;

	public UISprite NodeSprite;

	public UISprite SpriteOrangePlus;

	public GameObject ItemOwned;

	public AnimatedAlpha TokenAlpha;

	public UINetworkTexture CDNItem;

	public UINetworkTexture CDNNode;

	public GameObject Node;

	public Transform VFXContainer;

	public UILabel TokenNumOrignalLabel;

	public Animation PrizeAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
