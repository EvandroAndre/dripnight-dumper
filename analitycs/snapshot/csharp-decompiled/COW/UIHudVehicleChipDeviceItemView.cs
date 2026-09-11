using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleChipDeviceItemView : UIBaseView
{
	public GameObject NonDrag;

	public UILabel Name;

	public UIToggle UIHudVehicleChipDeviceItem;

	public GameObject HighLight;

	public UISprite GenerateIcon;

	public UIButton UseBtn;

	public UIButton CloseBtn;

	public GameObject ActiveIcon;

	public GameObject DeActiveIcon;

	public UIColor UseColor;

	public UIColor CloseColor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
