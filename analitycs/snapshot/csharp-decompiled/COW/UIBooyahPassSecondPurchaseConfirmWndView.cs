using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassSecondPurchaseConfirmWndView : UIBaseView
{
	public UILabel IntroduceLabel;

	public UITable2 RewardEasyList;

	public UIButton PurchaseBtn;

	public GameObject PurchaseRewardFutureGetNode;

	public UIPanel RewardListScrollView;

	public UIWidget DragScrollView;

	public UITable2Item NowNode;

	public UITable2Item FutureNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
