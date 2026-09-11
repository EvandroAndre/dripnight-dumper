using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_MatchInfoTitleView : UIBaseView
{
	public GameObject PhaseCountDown;

	public UILabel PhaseCountDownLabel;

	public GameObject RoundNum;

	public UILabel RoundNumLabel;

	public GameObject Bg_Left;

	public UITable Left;

	public UIGrid LeftTeammates;

	public UILabel LeftTeamScore;

	public GameObject Bg_Right;

	public UITable Right;

	public UILabel RightTeamScore;

	public UIGrid RightTeammates;

	public GameObject AliveNum;

	public UILabel AliveNumLabel;

	public UIButton LeaderboardButton;

	public UIGrid MoreTeamContainer;

	public GameObject TargetScore;

	public UILabel TargetScoreLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
