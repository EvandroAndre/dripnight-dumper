using GCommon;
using UnityEngine;

namespace COW;

public class LadderMatchReviewRewardItemView : UIBaseView
{
	public UILabel NextRankName;

	public UIGrid RewardGrid;

	public Transform RewardGridTransform;

	public GameObject ArrowDark;

	public GameObject Arrow;

	public Transform RewardGridPosWithFirstRankReward;

	public GameObject FirstRankRewardContainer;

	public Transform EmptyReward;

	public Transform FirstRankRewardItem;

	public GameObject SelectedBG;

	public Transform CSRankIconTransform;

	public Transform BRRankIconTransform;

	public GameObject KickOffNotClaimContainer;

	public GameObject Main;

	public UISprite FirstRankRewardBG;

	public UITable Table;

	public UISprite KickOffNotClaimBG;

	public Transform HCRankIconTransform;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
