using GCommon;
using UnityEngine;

namespace COW;

public class UINewPlayerV3MissionItemView : UIBaseView
{
	public GameObject ClaimedState;

	public GameObject UnfinishedState;

	public GameObject FinishedState;

	public UIGrid RewardGrid;

	public UILabel ProgressTips;

	public GameObject LockState;

	public UILabel NormalMissionDesc;

	public UILabel BigMissionDesc;

	public GameObject BigMission;

	public GameObject NormalMisson;

	public UIButton Operation;

	public UIButton BigOperation;

	public GameObject ClaimedStateBigReward;

	public GameObject UnfinishedStateBigReward;

	public GameObject FinishedStateBigReward;

	public GameObject LockStateBigReward;

	public GameObject BARtwo;

	public GameObject BARthree;

	public GameObject BarThree01;

	public GameObject BarThree02;

	public GameObject BarThree03;

	public GameObject BarTwo01;

	public GameObject BarTwo02;

	public GameObject BigLimitLogo;

	public UILabel BigLimitLogoLabel;

	public VFXCreateHelper BigLimitLogoVFX;

	public VFXCreateHelper LimitAwardVFX;

	public Transform LimitAwardVFXTrans;

	public GameObject NormalLimitLogo;

	public UILabel NormalLimitLogoLabel;

	public VFXCreateHelper NormalLimitLogoVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
