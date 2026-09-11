using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSSORoundResultView : UIBaseView
{
	public UILabel Coins;

	public GameObject WinSprite;

	public GameObject LoseSprite;

	public UIGrid BonusGrid;

	public GameObject BonusItem;

	public UILabel MvpPlayer;

	public GameObject MVPIcon;

	public GameObject HoldBG;

	public UIHudCSSOTeamInfoView OppoFaction;

	public GameObject OppoFactionHP;

	public GameObject NoEnemy;

	public GameObject OppoFactionEliminate;

	public GameObject OppoTeam;

	public UILabel OppoTeamLabel;

	public GameObject OppoWin;

	public UIHudCSSOTeamInfoView MyFaction;

	public GameObject MyFactionEliminate;

	public UILabel MyTeamLabel;

	public GameObject MyWin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
