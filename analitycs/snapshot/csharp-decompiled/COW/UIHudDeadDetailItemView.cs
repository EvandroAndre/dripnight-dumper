using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDeadDetailItemView : UIBaseView
{
	public UITable InfoContainer;

	public UILabel LeftNameLabel;

	public UISprite WeaponSprite;

	public UISprite DeadSprite;

	public UILabel RightNameLabel;

	public UITable DamageContainer;

	public UIButton ExpandBtn;

	public GameObject ExpandIcon;

	public UILabel DamageLabel;

	public GameObject HitDamageSprite;

	public UIWidget Main;

	public GameObject DeadReasonContainer;

	public UILabel SpecialDamage;

	public GameObject SelfDamageSprite;

	public GameObject KnockDownSprite;

	public GameObject DeadStatusContainer;

	public UISprite DamageLineLeft;

	public GameObject SplitLine;

	public GameObject BG;

	public UISprite DamageBg;

	public UISprite NormalBg;

	public UIWidget LeftNameLabelContainer;

	public UIWidget RightNameLabelContainer;

	public UILabel RightNameLabelTemplate;

	public UILabel LeftNameLabelTemplate;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
