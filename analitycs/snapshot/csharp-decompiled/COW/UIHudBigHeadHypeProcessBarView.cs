using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBigHeadHypeProcessBarView : UIBaseView
{
	public UILabel HypeValueTxt;

	public GameObject SliderContainer;

	public GameObject ArrowUp;

	public GameObject ArrowDown;

	public Transform ProcessSliderBg0;

	public Transform ProcessSliderBg1;

	public Transform ProcessSliderBg2;

	public Transform ProcessSliderBg3;

	public Transform ProcessSliderBg4;

	public UISprite ProcessSlider;

	public Transform movingFrame;

	public ParticleSystem HypeIncreasingEffect;

	public Transform lv1pos;

	public Transform lv2pos;

	public Transform lv3pos;

	public Transform lv4pos;

	public Transform lv5pos;

	public ParticleSystem LevelUpEffect;

	public UIWidget TutorialWidget;

	public GameObject SnowManCloth;

	public GameObject LevelUp;

	public GameObject LevelDown;

	public UILabel BuffDescLabel;

	public UISprite BuffSprite;

	public UIEventListener BuffEventListener;

	public UISprite BuffIcon;

	public UILabel BuffDesc;

	public UIWidget BuffDescContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
