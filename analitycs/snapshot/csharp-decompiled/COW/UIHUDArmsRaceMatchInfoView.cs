using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDArmsRaceMatchInfoView : UIBaseView
{
	public UIGrid MaxLevelGrid;

	public UISprite MaxTenSprite;

	public UISprite MaxUnitSprite;

	public UILabel BattleTimeLabel;

	public UISprite SelfWeaponIcon;

	public UIGrid SelfLevelGrid;

	public UISprite SelfTenSprite;

	public UISprite SelfUnitSprite;

	public UILabel SelfRank;

	public GameObject RankOneVFX;

	public UISprite TopWeaponIcon;

	public UILabel TopArmLevel;

	public UIGrid TopLevelGrid;

	public UISprite TopTenSprite;

	public UISprite TopUintSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
