using GCommon;
using UnityEngine;

namespace COW;

public class UIGrowthFundAnnounceView : UIBaseView
{
	public GameObject UIGrowthFundAnnounce;

	public GameObject UIGrowthFund;

	public GameObject GrowthFund_Container;

	public GameObject GrowthFund_Kelly_Container;

	public UINetworkTexture KellyImg;

	public GameObject DiscountContainer;

	public UINetworkTexture DiscountSprite;

	public UILabel DiscountLabel;

	public GameObject GrowthFund_RewardResult_Container;

	public UILabel RewardLabel;

	public UILabel RewardNum;

	public GameObject RewardGrid;

	public UIScrollView BundleContentScrollView;

	public UIEasyList EasyList;

	public UIButton CloseBtn;

	public UIButton GoBtn;

	public UIButton PurchaseBtn;

	public GameObject GrowthFund_Button_Container;

	public GameObject UILevelUp;

	public GameObject LevelUp;

	public UILabel LevelUpNumber;

	public GameObject Levelup_Title_Container;

	public GameObject LevelupNumber_Container;

	public UILabel LevelNum;

	public UILabel LevelNum_Shadow;

	public UILabel GrowthFundLevelLabel;

	public Animation Main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
