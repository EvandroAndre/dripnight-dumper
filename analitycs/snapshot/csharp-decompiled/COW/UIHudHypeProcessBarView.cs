using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHypeProcessBarView : UIBaseView
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

	public GameObject DevideLine;

	public GameObject SnowManCloth;

	public Transform Down;

	public Transform Up;

	public Transform All;

	public Transform MaxHypeLevelEffect;

	public GameObject BallRadiusBarContainer;

	public UISprite BallRadiusBar;

	public UISprite Ball;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
