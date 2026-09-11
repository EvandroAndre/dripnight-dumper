using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentGrowthFundItemView : UIBaseView
{
	public UIDragScrollView DragScrollView;

	public UILabel LevelHint;

	public UISprite DiamondIcon;

	public UILabel RewardLabel;

	public UINetworkTextureExt Icon;

	public UIButton Purchase;

	public GameObject WaitClaim;

	public UILabel PurchaseLabel;

	public GameObject WaitClaimBG;

	public GameObject Lock;

	public GameObject Claimed;

	public GameObject LowLevel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
