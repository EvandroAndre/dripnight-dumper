using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDWereWolvesCampInfoView : UIBaseView
{
	public UIProgressBar LeftTimeProgress;

	public UISprite barFore;

	public GameObject WolfRoot;

	public UISprite SkillIconSprite;

	public UIGrid IconGrid;

	public UIHUDWereWolvesCampWolfItem WolfIconTemplate;

	public GameObject HumanRoot;

	public UILabel HumanTitleLabel;

	public GameObject PredictToolRoot;

	public UILabel LeftTimeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
