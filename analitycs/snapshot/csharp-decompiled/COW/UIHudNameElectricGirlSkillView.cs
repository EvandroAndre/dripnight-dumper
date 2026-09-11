using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNameElectricGirlSkillView : UIBaseView
{
	public UISprite HpCircle;

	public UILabel PlayerIndex;

	public UISprite arrowLeft;

	public UISprite arrowUp;

	public UISprite arrowRight;

	public UISprite arrowDown;

	public UISprite HpLowestIcon;

	public UILabel Distance;

	public UITable Table;

	public UILabel DistanceMeter;

	public UISprite DistanceBG;

	public UISprite HpCircleHealTarget;

	public UISprite HpCircleLowHp;

	public UISprite CircleLeft;

	public UISprite CircleUp;

	public UISprite CircleRight;

	public UISprite CircleDown;

	public ParticleSystemRenderer Glow;

	public GameObject UIFX_Electric_Glow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
