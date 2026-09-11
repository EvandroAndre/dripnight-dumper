using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSShopTeammateWeaponInfoItemV2View : UIBaseView
{
	public UILabel TeamIndex;

	public UISprite IndexBG;

	public UISprite Weapon2_GoldEffect;

	public GameObject Weapon2_GoGradeLv1;

	public GameObject Weapon2_GoGradeLv2;

	public GameObject Weapon2_GoGradeLv3;

	public GameObject Weapon2_QualityMark1;

	public GameObject Weapon2_QualityMark2;

	public GameObject Weapon2_QualityMark3;

	public UISprite Weapon1_GoldEffect;

	public GameObject Weapon1_GoGradeLv1;

	public GameObject Weapon1_GoGradeLv2;

	public GameObject Weapon1_GoGradeLv3;

	public GameObject Weapon1_QualityMark1;

	public GameObject Weapon1_QualityMark2;

	public GameObject Weapon1_QualityMark3;

	public UISprite SecondWeapon2;

	public UISprite SecondWeapon1;

	public UISprite PrimaryWeapon1;

	public UISprite PrimaryWeapon2;

	public GameObject Weapon1;

	public GameObject Weapon2;

	public UILabel CoinLabel;

	public UILabel NameLabel;

	public UISprite HelmetSprite;

	public UISprite VestSprite;

	public GameObject Weapon1_ReinforceSprite;

	public GameObject Weapon2_ReinforceSprite;

	public GameObject VestEmptySprite;

	public GameObject HelmetEmptySprite;

	public GameObject CoinContainer;

	public UISprite AwakenIcon1;

	public UISprite AwakenIcon2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
