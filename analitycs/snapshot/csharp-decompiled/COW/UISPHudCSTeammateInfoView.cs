using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudCSTeammateInfoView : UIBaseView
{
	public UISPHudCSTeammateInfoDetailView DetailView;

	public UILabel CurKillCnt;

	public UISprite GrenadeIcon;

	public UISprite BrickBlockIcon;

	public UISprite GlooShieldIcon;

	public UISprite FirstAidkitIcon;

	public GameObject DeadInfo;

	public GameObject DeadBg;

	public UILabel DeadNickNameLabel;

	public UILabel DeadKDALabel;

	public UILabel DeadDamageLabel;

	public TweenPosition TWExtraInfoPosition;

	public TweenAlpha TWExtraInfoAlpha;

	public GameObject ExtraInfoBgCS;

	public GameObject ExtraInfoBgBomb;

	public UILabel KillCnt;

	public UILabel DeadCnt;

	public UILabel AssistCnt;

	public UILabel CostMoneyTxt;

	public GameObject Grade1;

	public GameObject Grade2;

	public GameObject Grade3;

	public GameObject QualityMark1;

	public GameObject QualityMark2;

	public GameObject QualityMark3;

	public UISprite SecondWeapon;

	public GameObject SecondGrade1;

	public GameObject SecondGrade2;

	public GameObject SecondGrade3;

	public GameObject Secondx;

	public GameObject Secondy;

	public GameObject Secondz;

	public UILabel GrenadeNum;

	public UILabel IcewallNum;

	public UILabel MedkitNum;

	public UILabel BrickBlockNum;

	public GameObject GrenadeEmpty;

	public GameObject IceWallEmpty;

	public GameObject MedkitEmpty;

	public GameObject BrickBlockEmpty;

	public UISprite CharacterIcon;

	public UISprite DeadIcon;

	public UISprite UseGrenadeIcon;

	public UISprite CharacterSkillIcon;

	public UILabel Available_Label;

	public UISprite SkillIcon;

	public GameObject CDMask;

	public UISprite TakeEffectProgress;

	public UISprite DisableProgress;

	public UISprite highLightSprite;

	public UISprite InUse;

	public GameObject Unusable;

	public UISprite CDProgress;

	public GameObject SkillState;

	public GameObject ActiveSkill;

	public GameObject UIFX;

	public UISprite UseSkillhighLightSprite;

	public GameObject AwakenIcon;

	public GameObject SecondAwakenIcon;

	public GameObject SamoAI;

	public UISprite SamoAIFlag;

	public UISprite SamoAIOffline;

	public GameObject Fall;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
