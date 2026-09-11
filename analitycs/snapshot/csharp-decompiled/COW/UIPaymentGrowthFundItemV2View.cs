using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentGrowthFundItemV2View : UIBaseView
{
	public UIDragScrollView DragScrollView;

	public UINetworkTextureExt Icon;

	public UIButton PurchaseContainer;

	public UIButton Purchase;

	public UILabel PurchaseLabel;

	public GameObject Claimed;

	public UISprite ProcessBar;

	public UILabel LevelLabel;

	public UILabel RebateLabel;

	public UILabel DiamondNum;

	public GameObject Pending;

	public GameObject LowLevel;

	public UILabel LowLevelLabel;

	public UIButton Locked;

	public UILabel LockedLabel;

	public GameObject WaitClaimBG;

	public GameObject Lock;

	public GameObject LastProcessBarContainer;

	public GameObject ProcessBarContainer;

	public UISprite LastProcessBar;

	public GameObject BG;

	public UINetworkTexture UnlockBG;

	public GameObject EmptyDot;

	public GameObject SolidDot;

	public GameObject FirstProcessBarContainer;

	public UISprite FirstProcessBar;

	public Transform Item0;

	public Transform Item1;

	public Transform Item2;

	public UITable ItemContainer;

	public GameObject UnlockUIFX;

	public UINetworkTexture LockBG;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
