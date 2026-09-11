using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBanknotePointPosMarkView : UIBaseView
{
	public UISprite NormalState;

	public UISprite ScrambleState;

	public UILabel ControlPointName;

	public UILabel RestAmount;

	public GameObject ArrowLeft;

	public GameObject ArrowUp;

	public GameObject ArrowDown;

	public GameObject ArrowRight;

	public UILabel DistanceLabel;

	public UIWidget Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
