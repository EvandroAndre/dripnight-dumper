using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponProficiencyProgressBarV2View : UIBaseView
{
	public UIProgressBar ProgressBar;

	public UISprite LeftSpriteLevelIcon;

	public UILabel LeftLabel;

	public UISprite RightSpriteLevelIcon;

	public UILabel RightLabel;

	public UILabel LabelProgress;

	public GameObject LabelProgressGameObject;

	public UISprite SpriteTip2;

	public Transform SpriteNodeLeft;

	public Transform SpriteNodeRight;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
