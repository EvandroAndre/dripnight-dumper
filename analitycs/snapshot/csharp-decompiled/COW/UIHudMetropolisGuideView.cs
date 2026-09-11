using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisGuideView : UIBaseView
{
	public UILabel MissionDescTxt;

	public GameObject ProgressContainer;

	public UISlider ProgressSlider;

	public UILabel ProgressValue;

	public UIButton MissionBtn;

	public GameObject BonusContent;

	public UILabel BonusTxt;

	public Transform BonusTokenFly;

	public Animation BgAnim;

	public UIButton GuideBtn;

	public UILabel MissionTitleTxt;

	public ParticleSystem UIFX_Markingloop;

	public GameObject UIFX_Remind;

	public GameObject Content;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
