using GCommon;
using UnityEngine;

namespace COW;

public class UIHudActiveSkillView : UIBaseView
{
	public UIButton BtnActiveSkill;

	public UIWidget TouchWidget;

	public UISprite BtnSprite;

	public UILabel CancelLabel;

	public GameObject CDMask;

	public UISprite CDProgress;

	public UISprite TakeEffectProgress;

	public GameObject PhaseObj;

	public UISprite PhaseFillProgress;

	public UILabel PhaseValue;

	public Transform SkillTakeEffectGo;

	public ParticleSystem SkillReadyAgainEffect;

	public UISprite DisableProgress;

	public UISprite highLightSprite;

	public GameObject petSkill;

	public GameObject petLv1;

	public GameObject petLv2;

	public GameObject petLv3;

	public GameObject Enhanced;

	public GameObject RaccoonSkill;

	public GameObject ActiveDirCon;

	public UISprite ArrowIcon;

	public VFXCreateHelper RetriggerEffect;

	public GameObject RetriggerTimes;

	public UILabel CanRetriggerCnt;

	public GameObject SkillCancelBtnSprite;

	public UIButton SkillCancelBtn;

	public UISprite BGSkill;

	public GameObject BuildGuideClickHint;

	public UISprite GlobalCDProgress;

	public UILabel TutorialLabel;

	public GameObject ActiveDirExtraBG;

	public GameObject ExtraBg;

	public GameObject CDTime;

	public UILabel CdTimeTxt;

	public UIButton SkillPerksBtn;

	public GameObject AutoStartCd;

	public UISprite AutoStartCdProgressSprite;

	public Transform EffectingPaused;

	public Transform EffectingPausedSprite;

	public UISprite EffectingPausedSpriteFill;

	public GameObject SkillPerksNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
