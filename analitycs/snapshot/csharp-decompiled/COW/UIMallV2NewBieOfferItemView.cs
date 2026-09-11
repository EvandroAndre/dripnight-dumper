using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2NewBieOfferItemView : UIBaseView
{
	public UILabel PricingTag;

	public UILabel LimitLabel;

	public UILabel ActualPrice;

	public UILabel OriginalPrice;

	public UIButton BuyButton;

	public UILabel Label;

	public UIButton GotoBtn;

	public GameObject SoldOut;

	public GameObject Selling;

	public GameObject LeftTag;

	public GameObject PreviewImg;

	public GameObject Limit;

	public GameObject PrcieNode;

	public GameObject GoPosNode;

	public GameObject SoldOutMask;

	public UILabel CoinsPrice;

	public GameObject PreviewIcon;

	public UITable Grid;

	public UIButton PreviewButton;

	public UINetworkTexture GotoNodeCDN;

	public UINetworkTexture PreviewCDN;

	public GameObject CoinsLabel;

	public GameObject CoinsIcon;

	public UILabel time;

	public UILabel CostLabel;

	public UILabel PricingLabel;

	public GameObject DiamondIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
