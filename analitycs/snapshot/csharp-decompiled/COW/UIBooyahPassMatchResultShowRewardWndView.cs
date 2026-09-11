using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassMatchResultShowRewardWndView : UIBaseView
{
	public UIEasyList RewardEasyList;

	public UIEasyList FutureRewardEasyList;

	public UIButton CancelBtn;

	public UIButton PurchaseBtn;

	public UILabel IntroduceLabel;

	public GameObject UnlcokNode;

	public GameObject CurGradeShowNode;

	public GameObject UpgradeNode;

	public GameObject CancelNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
