using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDArmsRaceTeamMatchInfoView : UIBaseView
{
	public UIGrid MaxLevelGrid;

	public UISprite MaxTenSprite;

	public UISprite MaxUnitSprite;

	public UILabel BattleTimeLabel;

	public UISprite SelfWeaponIcon;

	public UIGrid SelfLevelGrid;

	public UISprite SelfTenSprite;

	public UISprite SelfUnitSprite;

	public UISprite OpponenWeaponIcon;

	public UILabel OpponenArmLevel;

	public UIGrid OpponenLevelGrid;

	public UISprite OpponenTenSprite;

	public UISprite OpponenUintSprite;

	public UIButton OpenScoreBoardBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
