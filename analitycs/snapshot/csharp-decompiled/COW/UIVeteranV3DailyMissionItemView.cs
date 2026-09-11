using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranV3DailyMissionItemView : UIBaseView
{
	public UIGrid Grid;

	public UIButton Operation;

	public GameObject ClaimedState;

	public GameObject UnfinishedState;

	public GameObject FinishedState;

	public UILabel ProgressTips;

	public UILabel Desc;

	public UIButton GotoBtn;

	public UIButton ClaimBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
