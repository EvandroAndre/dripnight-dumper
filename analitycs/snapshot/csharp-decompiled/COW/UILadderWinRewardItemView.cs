using GCommon;
using UnityEngine;

namespace COW;

public class UILadderWinRewardItemView : UIBaseView
{
	public Transform RewardItemTransform;

	public GameObject Claimed;

	public GameObject WaitForClaim;

	public GameObject NotClaim;

	public UIProgressBar ProgressBar;

	public GameObject ReachedContainer;

	public GameObject NotReachedContainer;

	public UILabel ReachedLevelLabel;

	public UILabel NotReachedLevelLabel;

	public UIButton ItemButton;

	public UISprite BarBG;

	public GameObject FinalRewardUIFXContainer;

	public GameObject SelectedContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
