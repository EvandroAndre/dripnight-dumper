using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDRushingPetsMatchInfoView : UIBaseView
{
	public GameObject GameTimeRoot;

	public UILabel GemeTimeLabel;

	public GameObject RoundCountRoot;

	public UILabel RoundLabel;

	public GameObject LevelPlayerCountInfoRoot;

	public GameObject LevelFlowTargetFinishSprite;

	public GameObject LevelFlowEliminationSprite;

	public UILabel PlayerCountLabel;

	public GameObject PlayerScoreRoot;

	public UILabel PlayerScoreLabel;

	public GameObject RoundBeginRoot;

	public UITexture LevelTexture;

	public UILabel RoundBeginTitleLabel;

	public UILabel LevelPlayRuleLabel;

	public UILabel LevelNameLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
