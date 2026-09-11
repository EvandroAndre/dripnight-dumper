using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCannonInfoView : UIBaseView
{
	public GameObject GoldEffect;

	public UISprite WeaponIcon;

	public UISprite HeatWeaponIcon;

	public GameObject AmmoInfoGO;

	public UILabel CurrentAmmoCount;

	public UILabel MaxAmmoCount;

	public GameObject VFX_CombineSprite;

	public UISprite InfiniteSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
