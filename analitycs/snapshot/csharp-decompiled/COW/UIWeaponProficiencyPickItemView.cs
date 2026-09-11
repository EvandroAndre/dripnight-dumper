using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponProficiencyPickItemView : UIBaseView
{
	public UISprite SpriteWeapon;

	public UILabel LabelName;

	public UIButton BtnPick;

	public UISprite SpriteLevel;

	public UISprite SpritePinned;

	public UISprite SpriteNotPinned;

	public UISprite SpriteHighlight;

	public UISprite SpriteRedDot;

	public UISprite SpriteLight;

	public GameObject WeaponLevelV1;

	public GameObject WeaponLevelV2;

	public UISprite LevelV2Sprite;

	public UILabel LevelV2Label;

	public GameObject LevelUpUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
