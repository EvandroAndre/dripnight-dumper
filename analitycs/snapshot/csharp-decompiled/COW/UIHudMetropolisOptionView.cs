using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisOptionView : UIBaseView
{
	public UIGrid BtnGrid;

	public UIButton CallVehicleBtn;

	public UIWidget CallVehicleWidget;

	public UIButton CallWeaponBtn;

	public UIWidget CallWeaponWidget;

	public Animation CallVehicleUnLockEffect;

	public Animation CallWeaponUnLockEffect;

	public UIButton LeaderboardBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
