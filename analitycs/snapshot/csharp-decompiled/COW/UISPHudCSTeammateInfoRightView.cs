using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudCSTeammateInfoRightView : UIBaseView
{
	public UISPHudCSTeammateInfoDetailView BaseInfo;

	public UILabel UILabelCurKillCnt;

	public TweenAlpha TweenAlphaCurKillCnt;

	public UISprite GrenadeIcon;

	public UISprite BrickBlockIcon;

	public UISprite GlooShieldIcon;

	public UISprite FirstAidkitIcon;

	public TweenPosition TweenPositionDeadInfo;

	public TweenAlpha TweenAlphaDeadInfo;

	public GameObject DeadBg;

	public GameObject DeadNickNameLabel;

	public UILabel DeadKDALabel;

	public UILabel DeadDamageLabel;

	public UILabel ExtraInfo;

	public UILabel ExtraInfoBgCS;

	public GameObject ExtraInfoBgBomb;

	public GameObject KillCnt;

	public UILabel DeadCnt;

	public UILabel AssistCnt;

	public UILabel CostMoneyTxt;

	public UILabel Grade1;

	public UILabel Grade2;

	public UILabel Grade3;

	public UILabel x;

	public UILabel y;

	public UILabel z;

	public UISprite SecondWeapon;

	public GameObject SecondGrade1;

	public GameObject SecondGrade2;

	public GameObject SecondGrade3;

	public GameObject Secondx;

	public GameObject Secondy;

	public GameObject Secondz;

	public UILabel GrenadeNum;

	public UILabel IceWallNum;

	public UILabel MedkitNumNum;

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

	public GameObject DisableProgress;

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
