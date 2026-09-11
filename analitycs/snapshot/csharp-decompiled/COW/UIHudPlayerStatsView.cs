using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerStatsView : UIBaseView
{
	public Transform ArmorStats;

	public UISprite Mark;

	public UITable Skills;

	public UILabel LabelHP;

	public UISprite HPBar;

	public UISprite MedKitBar;

	public Transform FSHypeNode;

	public Transform HypeNode;

	public Animator HUDEffectAnimator;

	public GameObject APNode;

	public UILabel LabelAP;

	public UISprite APBar;

	public UISprite iconAP;

	public GameObject CuringMarkedObj;

	public GameObject MarkTimeBeReduced;

	public UIWidget TutorialWidget;

	public UIWidget WidgetTutorialHudHP;

	public UIGrid Buffs;

	public GameObject DamageRateEnhanceContainer;

	public UISprite AntiCloth;

	public UILabel damageEnhanceRate;

	public VFXCreateHelper damageEnhanceVFX;

	public UICustomHoverButton DamgeRateSpriteBtn;

	public UISprite DamgeRateSprite;

	public GameObject DamageRateTips;

	public VFXCreateHelper damageMaxVFX;

	public GameObject MarkIceWallSkillBeMark;

	public UISprite MarkIceWallSkillBeMarkCDFill;

	public GameObject HPNode;

	public GameObject SlowDownMarkedObj;

	public GameObject SlowDownMarkTimeBeReduced;

	public GameObject MetropolisRoot;

	public Transform TeamSharedPetSkill;

	public GameObject NewDamageEffect;

	public GameObject NewHealthEffect;

	public Transform SkillBuffRoot;

	public Transform BattleLevelRoot;

	public UISprite HPDamage;

	public InGameHPDamageEffect HPDamageEffect;

	public UISprite DamageRateBG;

	public GameObject BooyahBountyRoot;

	public Transform SPEPType1;

	public Transform SPEPType2;

	public GameObject NewEPEffect1;

	public GameObject NewEPEffect2;

	public GameObject NewEPEffect;

	public Transform HpBarCenter;

	public Transform HpBarIconVfxPos;

	public Transform FSHypeNodeForHudFour;

	public Transform HypeNodeForHudFour;

	public UIProgressBar MaxHpChangeBar;

	public UIPanel HpBarPanel;

	public UISprite ExecuteBar;

	public GameObject ExecuteBarHeadUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
