using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventoryUpgradePopView : UIBaseView
{
	public UIButton UpgradeBtn;

	public UITable MaterialTable;

	public UILabel CapacityBeforeLabel;

	public UILabel CapacityAfterLabel;

	public GameObject MoneyContainer;

	public UILabel MoneyCapacityBeforeLabel;

	public UILabel MoneyCapacityAfterLabel;

	public GameObject MaterialContainer;

	public UILabel PriceLabel;

	public UIButton MoneyUpgradeBtn;

	public GameObject SafeContainer;

	public UIButton SafeUpgradeBtn;

	public UIButton SafeCancelBtn;

	public UILabel SafeCapacityBeforeLabel;

	public UILabel SafeCapacityAfterLabel;

	public UIButton MoneyCancelBtn;

	public UIButton MaterialCancelBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
