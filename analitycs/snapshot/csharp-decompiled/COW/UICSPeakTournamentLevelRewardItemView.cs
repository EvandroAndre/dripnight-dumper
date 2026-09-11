using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentLevelRewardItemView : UIBaseView
{
	public Transform RewardItemNode;

	public GameObject ProgreessBarContainer;

	public GameObject UICSPeakTournamentLevelRewardItem;

	public VFXCreateHelper Selected;

	public UIButton Button;

	public GameObject Claimed;

	public Transform RewardContainer;

	public Transform PointsContainer;

	public GameObject ItemNormalBgYellowTop;

	public GameObject ItemNormalBgBlackTop;

	public GameObject ItemNormalBgBlackDown;

	public GameObject ItemNormalBgYellowDown;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
