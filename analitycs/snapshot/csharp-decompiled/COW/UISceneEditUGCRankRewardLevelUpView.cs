using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditUGCRankRewardLevelUpView : UIBaseView
{
	public UIButton ContinueBtn;

	public UISprite Before;

	public UISprite After;

	public Animation RewardAni;

	public GameObject RewardResult;

	public GameObject LevelUpResult;

	public Transform LeftAwardGrid;

	public Transform MidAwardGrid;

	public Transform RightAwardGrid;

	public Transform FirstAwardGrid;

	public Transform SecondAwardGrid;

	public GameObject RewardTitle;

	public UILabel RankNameBefore;

	public UILabel RankNameAfter;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
