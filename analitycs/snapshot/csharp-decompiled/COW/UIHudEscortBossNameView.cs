using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEscortBossNameView : UIBaseView
{
	public GameObject Container;

	public UILabel Name;

	public GameObject GoName;

	public GameObject ArrowUp;

	public GameObject ArrowUpLight;

	public GameObject ArrowLeft;

	public GameObject ArrowLeftLight;

	public GameObject ArrowRight;

	public GameObject ArrowRightLight;

	public GameObject ArrowDown;

	public GameObject ArrowDownLight;

	public UILabel TeammateDistance;

	public GameObject RepairIcon;

	public UISprite DistanceBG;

	public Transform EventTriggerMarkPos;

	public UILabel AdditiveLabel;

	public GameObject HPNode;

	public UISprite BodyHPBar;

	public UILabel BodyLabel;

	public UISprite WheelHPBar;

	public UILabel WheelLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
