using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHGRoundTopInfoView : UIBaseView
{
	public UILabel RoundName;

	public UILabel MissionTargetCount;

	public UILabel TimeLabel;

	public GameObject ShowRoot;

	public UITable MainInfoRepositionTable;

	public UIProgressBar FightPhaseProgress;

	public UISprite BGSprite;

	public UISprite FGSprite;

	public GameObject ProgressIcon;

	public GameObject TargetIcon;

	public GameObject RoundStartFinalCountDownRoot;

	public UITable RoundTargetTable;

	public GameObject UIFX;

	public UIProgressBar BossAnimHPProgress;

	public UILabel NotFightPhaseBossNameLabel;

	public UIButton OpenScoreBoardBtn;

	public GameObject NormalRoundRoot;

	public GameObject SurviveRoundRoot;

	public UILabel SurviveRoundTitleTimeLabel;

	public UILabel WaveLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
