using GCommon;
using UnityEngine;

namespace COW;

public class UIHudControlMatchTimeScoreView : UIBaseView
{
	public UIButton BtnLeaderboard;

	public UILabel ActivatingPoint;

	public GameObject NoActivatingPoint;

	public UILabel time;

	public UILabel targetScore;

	public UISprite NormalState;

	public UISprite NormalStateLight;

	public UISprite ScrambleState;

	public GameObject PingJuEffect;

	public GameObject GetScoreVFX_Local;

	public GameObject GetScoreVFX_Opp;

	public GameObject OccupyVFX_Local;

	public GameObject OccupyVFX_Opp;

	public UILabel LocalTeamScore;

	public UIProgressBar LocalTeamScoreBar;

	public UILabel OppTeamScore;

	public UIProgressBar OppTeamScoreBar;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
