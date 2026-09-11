using GCommon;
using UnityEngine;

namespace COW;

public class UIHudKilledView : UIBaseView
{
	public GameObject Simple;

	public UILabel content;

	public UISprite KillerNameBG;

	public UISprite KillTypeIcon;

	public Animation KnockDownAnimation;

	public GameObject General;

	public Animator NormalKill;

	public GameObject NormalKillGO;

	public Animator HeadShotKill;

	public GameObject HeadShotKillGO;

	public Animator Killed_AM_BlackBlood;

	public GameObject Killed_AM_BlackBloodGO;

	public Animator Killed_AM_HeadShot_BlackBlood;

	public GameObject Killed_AM_HeadShot_BlackBloodGO;

	public GameObject Killed_KnockDownGO;

	public Animator Killed_KnockDownAnimator;

	public Animator Killed_Assist_KnockDown;

	public GameObject Killed_AssistKnockDownGO;

	public UISprite KillTypeModeIcon;

	public GameObject ScannerMarkKillInfo;

	public UILabel Label;

	public Transform SpecialVFX;

	public GameObject HippoCrisisLeftReviveContainer;

	public UILabel LeftReviveLabel;

	public UISprite General_KnockDownIcon;

	public GameObject PrivilegeStyleRootGo;

	public Animator PrivilegeStyleAnimator;

	public UISprite PrivilegeIcon;

	public UISprite General_KnockDownAssistIcon;

	public GameObject LoadoutReinforceTokenContainer;

	public UILabel ReinforceTokenLabel;

	public UITable Table;

	public VFXCreateHelper BigheadRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
