using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPDMTimeScoreInfoView : UIBaseView
{
	public UIButton BtnLeaderboard;

	public UILabel leftScore;

	public UILabel time;

	public UILabel rightScore;

	public UILabel leftRank;

	public UIWidget GuideLeftScore;

	public UIWidget GuideRightScore;

	public UIWidget GuideScoreInfo;

	public UILabel TargetScore;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
