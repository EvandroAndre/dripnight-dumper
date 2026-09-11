using GCommon;
using UnityEngine;

namespace COW;

public class UIPayItemView : UIBaseView
{
	public UIButton ClickBtn;

	public UILabel BaseDiamondCount;

	public GameObject FirstTopUp;

	public UILabel FirstTopUpDiamondCount;

	public UINetworkTextureExt IOSNetworkImage;

	public UILabel CostAmountLabel;

	public GameObject BonusContainer;

	public UILabel BonusLabel;

	public GameObject BonusHorizontalBar;

	public GameObject BonusBombBar;

	public GameObject FirstChargeBonusContainer;

	public UILabel FirstChargeNum;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
