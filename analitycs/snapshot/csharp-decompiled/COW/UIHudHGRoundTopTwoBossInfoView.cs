using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHGRoundTopTwoBossInfoView : UIBaseView
{
	public UILabel MissionTargetCount;

	public UILabel TimeLabel;

	public GameObject ShowRoot;

	public UITable MainInfoRepositionTable;

	public UIProgressBar FightPhaseProgress;

	public UISprite BGSprite;

	public UISprite FGSprite;

	public GameObject RoundStartFinalCountDownRoot;

	public UITable RoundTargetTable;

	public UIProgressBar BossAnimHPProgress;

	public UILabel NotFightPhaseBossNameLabel;

	public UIButton OpenScoreBoardBtn;

	public GameObject NormalRoundRoot;

	public GameObject BossHPRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
