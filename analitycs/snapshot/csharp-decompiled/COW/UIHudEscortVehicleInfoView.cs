using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEscortVehicleInfoView : UIBaseView
{
	public UISprite BodyHPBar;

	public UIButton BodyTipBtn;

	public UISprite WheelHPBar;

	public UIButton WheelTipBtn;

	public UISprite OKStatus;

	public UIButton StatusTipBtn;

	public UISprite NotOKStatus;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
