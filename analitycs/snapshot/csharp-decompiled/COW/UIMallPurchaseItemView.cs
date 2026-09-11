using GCommon;
using UnityEngine;

namespace COW;

public class UIMallPurchaseItemView : UIBaseView
{
	public UIButton ItemBtn;

	public UIWidget ItemWidget;

	public Animation Animation;

	public GameObject HighLightBG;

	public UILabel Time;

	public UITable CostTable;

	public UILabel DiscountLabel;

	public GameObject GoldContainer;

	public GameObject DiamondContainer;

	public UILabel DiamondPriceLabel;

	public UILabel DiamondOriginalPriceLabel;

	public UILabel GoldPriceLabel;

	public UILabel GoldOriginalPriceLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
