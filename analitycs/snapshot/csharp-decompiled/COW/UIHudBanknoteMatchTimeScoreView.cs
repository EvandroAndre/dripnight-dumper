using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBanknoteMatchTimeScoreView : UIBaseView
{
	public GameObject NoActivatingPoint;

	public UIButton BtnLeaderboard;

	public UILabel ActivatingPoint;

	public UILabel time;

	public UILabel targetScore;

	public GameObject PingJuEffect;

	public GameObject ScambleState;

	public GameObject LocalOccupyState;

	public GameObject OppOccupyState;

	public UILabel LocalTeamScore;

	public UIProgressBar LocalTeamScoreBar;

	public UILabel LocalMinusScore;

	public UILabel OppTeamScore;

	public UIProgressBar OppTeamScoreBar;

	public UILabel OppMinusScore;

	public UILabel CaptureInfoLabel;

	public TweenAlpha CaptureInfoTween;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
