using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentTaskRewardItemView : UIBaseView
{
	public UILabel ThumbPointsLabel;

	public GameObject Thumb;

	public UIButton ItemButton;

	public GameObject SelectedContainer;

	public UIProgressBar ProgressBar;

	public Transform RewardItemTransform;

	public Transform CurLevelPointsContainer;

	public UISprite BarBG;

	public UIColor Fore;

	public UISprite Back;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
