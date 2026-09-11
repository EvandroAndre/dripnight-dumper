using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDRushingPetsLevelEndShowView : UIBaseView
{
	public GameObject RankRoot;

	public UIEasyList PlayerList;

	public UILabel NextRoundTimeLabel;

	public Transform LocalPlayerInfo;

	public GameObject RoundEndTipRoot;

	public UILabel CurRoundRankLabel;

	public UILabel CurRoundScoreLabel;

	public GameObject VictoryRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
