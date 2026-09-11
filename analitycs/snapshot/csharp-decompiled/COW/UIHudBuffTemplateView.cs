using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBuffTemplateView : UIBaseView
{
	public UISprite UIHudSkillTemplate;

	public UISprite Cooldown;

	public GameObject SkillFlashAnim;

	public UIEventListener SkillBtn;

	public UIWidget SkillBG;

	public UILabel SkillLabel;

	public TweenAlpha SkillBrightAnim;

	public GameObject SkillTipsEffect;

	public UILabel AfterNum;

	public GameObject BG;

	public GameObject CricleBg;

	public UISprite CooldownRect;

	public UILabel Level;

	public UILabel ChildBuffAmount;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
