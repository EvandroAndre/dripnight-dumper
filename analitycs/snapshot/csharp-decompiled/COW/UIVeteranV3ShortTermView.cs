using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranV3ShortTermView : UIBaseView
{
	public GameObject CountDown;

	public UILabel LabelDate;

	public GameObject PreviligeCon;

	public UIButton PrivilegeBtn;

	public GameObject PrivilegeBubbleLabel;

	public UIGrid RewardCon;

	public GameObject RewardDay1;

	public GameObject RewardDay2;

	public GameObject RewardDay3;

	public GameObject RewardDay4;

	public UILabel ProgressTips;

	public GameObject UnfinishedState;

	public UILabel MissionDesc;

	public UIButton CloseBtn;

	public GameObject MissionUnDoneCon;

	public GameObject MissionDoneCon;

	public UILabel TodayTaskDoneLabel;

	public UIButton GotoBtn;

	public Animation Main;

	public GameObject MissionCon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
