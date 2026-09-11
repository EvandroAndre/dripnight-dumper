using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponProficiencyProgressBarItemView : UIBaseView
{
	public UILabel LabelProgress;

	public UIProgressBar ProgressBar;

	public UISprite SpriteProgressBar;

	public Transform TrBarItemRoot;

	public UISprite SpriteLevelIcon;

	public GameObject GoMaxLevel;

	public UISprite SpriteLevelMaxIcon;

	public GameObject UIFX_Prize;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
