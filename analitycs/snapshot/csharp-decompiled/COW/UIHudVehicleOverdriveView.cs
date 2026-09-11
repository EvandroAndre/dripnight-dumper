using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleOverdriveView : UIBaseView
{
	public UIButton btnBoost;

	public UISprite icon;

	public GameObject CDMask;

	public UISprite CDProgress;

	public UISprite DisableProgress;

	public GameObject CDTime;

	public UILabel CdTimeTxt;

	public UISprite BtnBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
