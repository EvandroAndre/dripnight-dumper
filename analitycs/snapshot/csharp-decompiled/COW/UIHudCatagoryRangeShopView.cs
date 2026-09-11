using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCatagoryRangeShopView : UIBaseView
{
	public UIButton BtnQuit;

	public UIButton BtnClose;

	public UILabel TitleLabel;

	public GameObject TopCatagory;

	public UIEasyList TopCatagoryEasyList;

	public UITable2 NormalShopTable;

	public UITable2 MaxShopTable;

	public UIButton purchaseBtn;

	public GameObject TokenInfo;

	public UISprite Icon;

	public UILabel TokenCnt;

	public UIButton HelpBtn;

	public TrainingWeaponTip TrainingInfoTip;

	public GameObject TabContainer;

	public UIEasyList TabEasyList;

	public GameObject NormalContainer;

	public GameObject NormalShop;

	public GameObject MaxShop;

	public GameObject TriIcon;

	public Transform DescContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
