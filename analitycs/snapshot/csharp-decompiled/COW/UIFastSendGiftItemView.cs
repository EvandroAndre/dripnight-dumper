using GCommon;
using UnityEngine;

namespace COW;

public class UIFastSendGiftItemView : UIBaseView
{
	public UIButton UIButtonUIFastSendGiftItem;

	public UIWidget UIWidgetUIFastSendGiftItem;

	public GameObject GoldContainer;

	public UILabel GoldPritceLabel;

	public GameObject DiamondContainer;

	public UILabel DiamondPriceLabel;

	public GameObject ItemContainer;

	public UISprite SpritePurplePlus;

	public GameObject SpriteOrangePlus;

	public GameObject VFX_QualityOrangePlus;

	public GameObject VFX_QualityRed;

	public GameObject XMBItemCon;

	public Transform PriceTransform;

	public GameObject PrimeContainer;

	public GameObject WishListContainer;

	public UINetworkTexture PrimeBGCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
