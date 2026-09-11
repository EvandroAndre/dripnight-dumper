using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCubicMapView : UIBaseView
{
	public UIButton CancelBtn;

	public UIInput InputOffsetX;

	public UIInput InputOffsetY;

	public UIInput InputOffsetZ;

	public UIInput InputEulerAnglesX;

	public UIInput InputMoveFact;

	public UIButton ZoomInBtn;

	public UIButton ZoomOutBtn;

	public UISlider SliderNode;

	public UIInput InputLimitHeight;

	public UIInput InputLimitAniTime;

	public UIInput InputMin;

	public UIInput InputMax;

	public UIInput InputLimitRotateAnglesY;

	public Transform MapContainer;

	public UIPanel MapContent;

	public UIButton BtnFindSelf;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
