using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFlagBattleHypeProcessBarView : UIBaseView
{
	public UILabel HypeValueTxt;

	public GameObject SliderContainer;

	public GameObject ArrowUp;

	public GameObject ArrowDown;

	public Transform s1;

	public UISprite sliderSpr1;

	public Transform s2;

	public UISprite sliderSpr2;

	public Transform s3;

	public UISprite sliderSpr3;

	public Transform s4;

	public UISprite sliderSpr4;

	public Transform s5;

	public UISprite sliderSpr5;

	public ParticleSystem LevelUpEffect;

	public Transform ProcessSliderBg0;

	public Transform ProcessSliderBg1;

	public Transform ProcessSliderBg2;

	public Transform ProcessSliderBg3;

	public Transform ProcessSliderBg4;

	public UISprite ProcessSlider;

	public Transform movingFrame;

	public ParticleSystem HypeIncreasingEffect;

	public UICustomHoverButton CheckAllAttributeBtn;

	public UIButton LevelUpBtn;

	public GameObject AttributesSelectContainer;

	public UIGrid Grid;

	public GameObject DescInfo;

	public UISprite DescBG;

	public UITable DescTable;

	public UILabel DescTemp;

	public Transform MaxHypeLevelEffect;

	public UIFlagBattleChooseItemController AttributeItem;

	public Transform FSMode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
