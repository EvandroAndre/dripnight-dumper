using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEscortVehicleProgressView : UIBaseView
{
	public Transform PlayerStatus;

	public UILabel DefenderLabel;

	public UILabel AttackerLabel;

	public UISprite ProgBar1;

	public UISprite Flag1;

	public UISprite ProgBar2;

	public UISprite Flag2;

	public UISprite ProgBar3;

	public UISprite Flag3;

	public UISprite ProgBar4;

	public UISprite Flag4;

	public Transform VehicleIcon;

	public GameObject Hint;

	public UILabel HintText;

	public UISprite DescriptionBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
