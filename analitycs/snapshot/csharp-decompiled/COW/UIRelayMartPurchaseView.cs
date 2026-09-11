using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartPurchaseView : UIBaseView
{
	public UIButton BtnDiamondPurchase;

	public GameObject WithDiscountContainer;

	public GameObject NoDiscountContainer;

	public UILabel NoDiscountLabel;

	public GameObject ItemContainer;

	public UITable ItemTable;

	public UIButton SendFrinedInviteCheckBox;

	public GameObject SpriteSelect;

	public UIPanel UIRelayMartPurchase;

	public GameObject DiamondPurchaseActiveView;

	public GameObject ActualDiamond;

	public GameObject DiamondIcon;

	public UILabel ActualDiamondPriceLabel;

	public GameObject OriginalDiamond;

	public UILabel OriginalDiamondPriceLabel;

	public UILabel DiamondPurchaseDiscountLabel;

	public UINetworkTexture BgCDN;

	public UINetworkTexture TitleLabelCDN;

	public UIButton Close;

	public UITable BtnGroupTable;

	public UIButton BtnGetMoreCoupons;

	public GameObject WithCouponBG;

	public GameObject NoCouponBG;

	public UILabel CompletedOnlyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
