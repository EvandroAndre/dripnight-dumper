using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTechDeviceBtnView : UIBaseView
{
	public Transform SkillBtnRoot;

	public UISprite Icon;

	public UISprite iconbg;

	public UIButton NormalBtn;

	public GameObject RefreshEffect;

	public GameObject IconRoot;

	public AnimatedAlpha IconRootAniAlpha;

	public UISprite CD;

	public AnimatedAlpha CDAniAlpha;

	public UILabel Count;

	public AnimatedAlpha CountAniAlpha;

	public GameObject PassiveMask;

	public AnimatedAlpha PassiveMaskAniAlpha;

	public ParticleSystem CDOverEffect;

	public GameObject MaxCount;

	public UILabel TutorialLabel;

	public Animation UIHudTechDeviceBtn;

	public GameObject NBGP2BigItemRoot;

	public GameObject HintVfx;

	public GameObject DissipateVfx;

	public UISprite TechDeviceDeco;

	public AnimatedAlpha TechDeviceDecoAlpha;

	public GameObject CDTime;

	public UILabel CdTimeTxt;

	public UIButton PinSkillBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
