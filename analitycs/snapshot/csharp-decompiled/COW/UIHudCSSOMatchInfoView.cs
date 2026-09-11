using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSSOMatchInfoView : UIBaseView
{
	public GameObject BattleContainer;

	public Transform myTeam;

	public Transform oppoTeam;

	public UILabel curRound;

	public UILabel remainTime;

	public Transform MyTeamHP;

	public Transform OppoTeamHP;

	public GameObject WaitingContainer;

	public UILabel waiting;

	public UILabel tips;

	public UIButton BtnLeaderboard;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
