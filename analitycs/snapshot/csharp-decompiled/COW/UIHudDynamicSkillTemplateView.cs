using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDynamicSkillTemplateView : UIBaseView
{
	public UISprite UIHudDynamicSkillTemplate;

	public UISprite Cooldown;

	public TweenAlpha SkillFlashAnim;

	public UIEventListener SkillBtn;

	public UISprite SkillBG;

	public UILabel SkillLabel;

	public TweenAlpha SkillBrightAnim;

	public GameObject BannedIcon;

	public GameObject SkillEffectShoot;

	public GameObject SkillEffectMove;

	public GameObject VFXSkillUpgrade;

	public GameObject SkillEnhanced;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
