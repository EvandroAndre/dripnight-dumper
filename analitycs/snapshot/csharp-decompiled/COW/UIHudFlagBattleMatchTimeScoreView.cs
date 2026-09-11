using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFlagBattleMatchTimeScoreView : UIBaseView
{
	public UIButton BtnLeaderboard;

	public UILabel time;

	public UILabel targetScore;

	public UILabel LocalTeamScore;

	public UIProgressBar LocalTeamScoreBar;

	public UILabel OppTeamScore;

	public UIProgressBar OppTeamScoreBar;

	public GameObject GetScoreVFX_Local;

	public GameObject GetScoreVFX_Opp;

	public GameObject MyTeamEnergyStone1;

	public GameObject MyTeamEnergyStone2;

	public GameObject OppoTeamEnergyStone1;

	public GameObject OppoTeamEnergyStone2;

	public UIWidget TutorialWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
