using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionWeaponSkinItemView : UIBaseView
{
	public GameObject LevelGO;

	public UISprite QualityBg;

	public UISprite WeaponSprite;

	public UISprite GrenadeSprite;

	public UILabel LevelLabel;

	public UISprite LevelIcon;

	public Transform LevelCommonTr;

	public Transform LevelLeftTr;

	public GameObject ValidTimerGO;

	public UILabel ValidTimerLabel;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public UISprite IceWallSprite;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject WeaponSkinSwitchIcon;

	public UISprite Quality;

	public UIButton RemoveBtn;

	public GameObject Selected;

	public UISprite LightBG;

	public GameObject Icon;

	public UITable TableContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
