using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDArmsRaceKillPointsView : UIBaseView
{
	public UIGrid PointsGrid;

	public UIHUDArmsRacePointItem PointItem;

	public Animator KillLeaderEffect;

	public UISprite UpgradedWeaponIcon;

	public Animation ContainerAnim;

	public GameObject VFX_LevelUpTransition;

	public UISprite UpgradedWeaponIconShadow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
