using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterLevelInfoView : UIBaseView
{
	public UISprite AuthorLevelIcon;

	public UILabel AuthorLevelName;

	public UISprite AuthorExpProgress;

	public UILabel AuthorExpLabel;

	public UIButton ViewLevelsRewardBtn;

	public UIEasyList LevelRewardShowGrid;

	public UIButton LevelRewardMaskBtn;

	public GameObject LevelRewardShowRoot;

	public UILabel PlayCountLabel;

	public UILabel PlayDurationLabel;

	public UIProgressBar ExpBar;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
