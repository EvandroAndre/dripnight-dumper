using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWSOMatchInfoView : UIBaseView
{
	public GameObject BattleContainer;

	public Transform myTeam;

	public Transform oppoTeam;

	public UISprite HpKnife;

	public UILabel remainTime;

	public UISprite OppoTeamHpBG;

	public UISprite MyTeamHPBG;

	public UIGrid MyTeamHPGrid;

	public UIGrid OppoTeamHPGrid;

	public GameObject WaitingContainer;

	public UILabel waitingTips;

	public UILabel curRound;

	public UIButton BtnLeaderboard;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
