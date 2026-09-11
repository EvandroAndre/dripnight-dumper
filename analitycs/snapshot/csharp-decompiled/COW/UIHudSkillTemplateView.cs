using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSkillTemplateView : UIBaseView
{
	public UISprite UIHudSkillTemplate;

	public UISprite Cooldown;

	public TweenAlpha SkillFlashAnim;

	public UIButton SkillBtn;

	public UISprite SkillBG;

	public TweenAlpha SkillBrightAnim;

	public GameObject BannedIcon;

	public GameObject SkillEffectShoot;

	public GameObject SkillEffectMove;

	public GameObject VFXSkillUpgrade;

	public GameObject SkillEnhanced;

	public Animation SpecialCountDown;

	public UISprite LevelUpSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
