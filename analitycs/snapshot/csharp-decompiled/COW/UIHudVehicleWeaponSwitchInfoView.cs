using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleWeaponSwitchInfoView : UIBaseView
{
	public UIButton WeaponSwitchButton;

	public TweenAlpha EquipHint;

	public UISprite PrimaryIcon;

	public GameObject AmmoInfoGO;

	public UILabel MaxAmmoCount;

	public UISprite InfiniteSprite;

	public UIProgressBar AmmoStatusBar;

	public GameObject AutoShooting;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
