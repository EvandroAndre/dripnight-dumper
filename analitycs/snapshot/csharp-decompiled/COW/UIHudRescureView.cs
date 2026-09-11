using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRescureView : UIBaseView
{
	public UIButton RescureBtn;

	public Transform RescureBtnTrans;

	public UISprite BGHelping;

	public GameObject RescureProcess;

	public Transform RescureProcessTrans;

	public GameObject Alien_Skill;

	public UILabel TimeLabel;

	public GameObject RescuredAnim;

	public UIButton BtnAbandomLife;

	public UIEventTrigger BtnAbandomLifeEventTrigger;

	public GameObject BtnSkillEffect_Thiva;

	public GameObject ProcessSkillEffect_Thiva;

	public Transform FrozenEffect;

	public UISprite BGHelpround;

	public UIButton BtnAssist;

	public VFXCreateHelper AssistEffect;

	public VFXCreateHelper AssistLoopEffect;

	public GameObject AssistBtnSkillEffect_Thiva;

	public UISprite BGAbandomLife;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
