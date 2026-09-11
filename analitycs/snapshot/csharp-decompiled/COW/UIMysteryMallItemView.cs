using GCommon;
using UnityEngine;

namespace COW;

public class UIMysteryMallItemView : UIBaseView
{
	public GameObject PriceContainer;

	public UILabel LabelOriginPrice;

	public UILabel LabelDiscountPrice;

	public UILabel LabelLimit;

	public UIButton ItemBtn;

	public UIWidget ItemWidget;

	public GameObject NewLabel;

	public GameObject LimitedLabel;

	public GameObject LimitedPurchaseLabel;

	public GameObject HotLabel;

	public GameObject EarlyBirdLabel;

	public GameObject BaseItemView;

	public BaseItemView BaseInfoView;

	public UISprite VoucherIcon;

	public GameObject LockedTitle;

	public GameObject Owned;

	public GameObject ClaimedTitle;

	public GameObject LimitedTitle;

	public UISprite IPTag;

	public UILabel LabelItemName;

	public UIButton BtnPurchase;

	public UISprite Purchased;

	public GameObject Purchasable;

	public UINetworkTextureExt CdnItem;

	public UISprite ItemNameQualityBg;

	public GameObject LabelOwned;

	public VFXCreateHelper VFXDiscount;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
