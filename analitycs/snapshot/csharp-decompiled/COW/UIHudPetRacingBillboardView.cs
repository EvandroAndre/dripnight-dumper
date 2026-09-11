using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPetRacingBillboardView : UIBaseView
{
	public GameObject BeforeRacing;

	public UILabel CountdownLabel;

	public UIHudPetRacerView Pet1;

	public UIHudPetRacerView Pet2;

	public UIHudPetRacerView Pet3;

	public GameObject HighlightEffect;

	public GameObject AfterRacing;

	public UISprite Winner;

	public UILabel NextCountDownLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
