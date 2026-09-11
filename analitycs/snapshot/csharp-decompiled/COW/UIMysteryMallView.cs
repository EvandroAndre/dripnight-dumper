using GCommon;
using UnityEngine;

namespace COW;

public class UIMysteryMallView : UIBaseView
{
	public UILabel Title;

	public UIButton LeaveBtn;

	public UILabel GemLabel;

	public UIButton BtnGem;

	public GameObject Container;

	public UIScrollView ItemScrollView;

	public UITable ItemTable;

	public UIButton BtnRule;

	public Transform CountDownContainer;

	public UILabel LabelCostNum;

	public UILabel LabelSuperOriginalPrice;

	public UILabel LabelSuperDiscountPrice;

	public UIButton BtnPurchaseSuper;

	public GameObject Locked;

	public GameObject Purchasable;

	public GameObject Shareable;

	public GameObject TipsIcon;

	public UILabel LabelPriceTip;

	public Transform ItemSuperContainer;

	public Transform ItemSecondContainer;

	public UINetworkTextureExt CdnSuperBg;

	public UIGrid ItemNormalGrid;

	public UIGrid BtnGrid;

	public UIButton BtnGoWeb;

	public UINetworkTextureExt CdnGoWeb;

	public UIButton BtnSwitchPool;

	public UINetworkTextureExt CdnSwitchPool;

	public UILabel LabelPoolPrice;

	public UILabel LabelProgress;

	public UIProgressBar BarSwitchProgress;

	public Transform TabContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
