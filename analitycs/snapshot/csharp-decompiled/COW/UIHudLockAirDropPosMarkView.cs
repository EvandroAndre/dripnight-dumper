using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLockAirDropPosMarkView : UIBaseView
{
	public GameObject Container;

	public GameObject StateIcon;

	public UISprite StateBg;

	public UILabel DistanceLabel;

	public UISprite Progress;

	public GameObject StateIcon02;

	public GameObject StateIcon03;

	public UILabel DistanceM;

	public GameObject StateBgFight;

	public GameObject ProgressBg;

	public Transform CSTeamGoalTrans;

	public GameObject SpecialBg;

	public GameObject TechAirdropSpecialBg;

	public Transform Change_Tag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
