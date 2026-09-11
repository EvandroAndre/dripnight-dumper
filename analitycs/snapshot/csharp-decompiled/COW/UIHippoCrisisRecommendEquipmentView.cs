using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisRecommendEquipmentView : UIBaseView
{
	public UILabel TitleLabel;

	public Transform HelmetContainer;

	public Transform BodyArmorContainer;

	public Transform BackpackContainer;

	public Transform SkillChipContainer;

	public GameObject Consumable_Container;

	public UIGrid ConsumableGrid;

	public UIButton MoneyUpgradeBtn;

	public UIWidget MoneyUpgradeBtnWidget;

	public UILabel PriceLabel;

	public Transform MainWeapon;

	public UILabel WithDiscountOriginalPriceLabel;

	public GameObject CannotEquipBtn;

	public UISprite Titlebg;

	public UIButton EquipBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
