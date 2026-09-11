using GCommon;
using UnityEngine;

namespace COW;

public class UILadderMatchSeasonInfoMissionItemView : UIBaseView
{
	public UILabel MissionDescription;

	public GameObject SpecialMissionContainer;

	public Transform LimitedTimeCount;

	public UICountDownLabel LimitedTimeCountDownLabel;

	public UIGrid RewardGrid;

	public Transform RewardGridTransform;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
