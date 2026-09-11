using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentTaskRewardView : UIBaseView
{
	public UIButton GotoRankSystemBtn;

	public GameObject WinRewardContainer;

	public UIGrid RewardProcessGrid;

	public Transform Left;

	public GameObject GotoRankSystemContainer;

	public UIButton DisplayBtn;

	public UIButton GoMatchBtn;

	public GameObject CanGoMatchContainer;

	public GameObject GoMatchTimeContainer;

	public GameObject CannotGoMatchContainer;

	public GameObject CannotGoMatchNotInSeasonContainer;

	public UICountDownLabel CannotGoMatchCountDownLabel;

	public UICountDownLabel GoMatchCountDownLabel;

	public UILabel CannotGoMatchNoticeLabel;

	public GameObject EquipPeak;

	public GameObject NoEquipPeak;

	public GameObject SelectWndOpen;

	public UILabel CannotGoMatchLabel;

	public Transform AvatarFrameSelectWndPos;

	public UITable ReachToUnlockTransform;

	public Transform StarIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
