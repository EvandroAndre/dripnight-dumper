using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentView : UIBaseView
{
	public Transform MainWeapon1;

	public Transform MainWeapon2;

	public Transform BackpackContainer;

	public Transform SkillChipContainer;

	public Transform BodyArmorContainer;

	public Transform HelmetContainer;

	public GameObject SecondaryWeaponContainer;

	public GameObject MeleeContainer;

	public GameObject Title;

	public UILabel ValueNum;

	public UIButton RepairBtn;

	public UIButton Consumables_Container_HasFix;

	public UIButton Consumables_Container_NoFix;

	public GameObject Fix_Container;

	public UISprite NoCostItemTips;

	public GameObject TotalValueLimitContainer;

	public UILabel LimitTitle;

	public UILabel ValueLimit;

	public GameObject TotalValueWarning;

	public UIButton ValueTipsBtn;

	public GameObject GuideMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
