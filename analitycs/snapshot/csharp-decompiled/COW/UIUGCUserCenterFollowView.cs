using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterFollowView : UIBaseView
{
	public UIGrid Grid;

	public UILabel FollowNumLabel;

	public UIEasyList List;

	public UIPanel OperateBtnPanel;

	public UIButton CancelFollowBtn;

	public GameObject ModeDropList;

	public UIButton CancelOperationBtn;

	public GameObject FollowListEmpty;

	public GameObject MapsEmpty;

	public UILabel mapLabelTips;

	public GameObject Container;

	public UIButton EmptyLableBtn;

	public UILabel CancelFollowBtnLabel;

	public UIButton PinFollowBtn;

	public UILabel PinFollowBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
