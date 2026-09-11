using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinPokedexItemView : UIBaseView
{
	public UIWidget ItemWidget;

	public Animation OnStartAnim;

	public UISprite Quality;

	public UISprite QualityBG;

	public AnimatedAlpha QualityBGAlpha;

	public UISprite WeaponSprite;

	public GameObject OutExpireStateGO;

	public GameObject ValidTimerGO;

	public UILabel ValidTimerLabel;

	public GameObject LevelGO;

	public UILabel LevelLabel;

	public UISprite LevelIcon;

	public Transform LevelCommonTr;

	public Transform LevelLeftTr;

	public UISprite GrenadeSprite;

	public UISprite SpriteQualityPlus;

	public AnimatedAlpha SpriteQualityPlusAlpha;

	public UISprite SpriteOrangeQualityPlus;

	public AnimatedAlpha SpriteOrangeQualityPlusAlpha;

	public UILabel PercentLbl;

	public UIProgressBar ProgressBar;

	public UIButton ItemButton;

	public AnimatedAlpha ColorAlpha;

	public UISprite IceWallSprite;

	public GameObject WeaponSkinSwitchIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
