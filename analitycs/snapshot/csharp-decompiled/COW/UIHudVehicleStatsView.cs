using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleStatsView : UIBaseView
{
	public Transform SpeedPointer;

	public UILabel LabelSpeed;

	public GameObject HPNode;

	public UISprite HPIcon;

	public TweenAlpha HPLowTween;

	public GameObject Effect_VFX;

	public GameObject Effect_upVFX;

	public GameObject Effect_downVFX;

	public GameObject ChipDesc;

	public UIWidget ChipDescWidget;

	public UILabel ChipDescLabel;

	public UIButton StatsBtn;

	public UIWidget StatsBtnWidget;

	public UILabel ChipName;

	public GameObject Helicopter;

	public UISprite HelicopterFG;

	public GameObject LOCK;

	public GameObject HelicopterVFX;

	public GameObject VFXPlayerSkill;

	public GameObject LimitTimeNode;

	public UILabel LimitTimeLabel;

	public UIButton LimitTimeBtn;

	public GameObject HorseNode;

	public UISprite HorseStateIcon;

	public GameObject HorseVFXPlayerSkill;

	public GameObject HorseHealVfx;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
