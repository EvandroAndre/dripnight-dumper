using GCommon;
using UnityEngine;

namespace COW;

public class UIHud2TeamsTimeScoreView : UIBaseView
{
	public UIButton BtnLeaderboard;

	public UILabel team1Score;

	public UILabel time;

	public UILabel team2Score;

	public UILabel targetScore;

	public GameObject Effect1;

	public GameObject Effect2;

	public GameObject VFX_Team1Win;

	public GameObject VFX_Team2Win;

	public GameObject VFX_Team1Combo;

	public GameObject VFX_Team2Combo;

	public GameObject MyTeamUp;

	public GameObject EnemyTeamUp;

	public GameObject EnemyTeamDwon;

	public GameObject MyTeamDown;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
