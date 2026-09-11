using GCommon;
using UnityEngine;

namespace COW;

public class UIMemberShipTabItemView : UIBaseView
{
	public UIButton Button;

	public UISprite Selected;

	public Transform RedDot;

	public UISprite CardIcon;

	public UILabel CardName;

	public GameObject UnSubscription;

	public UILabel RewardPriceLabel;

	public GameObject RewardRateDiamond;

	public GameObject RewardRate;

	public GameObject Title;

	public GameObject DiamondBG;

	public UISprite DiamondIcon;

	public UILabel DiamondNum;

	public GameObject Subscription;

	public GameObject ActivedContainer;

	public UILabel ActivedLabel;

	public GameObject RemainIcon;

	public UILabel RemainDays;

	public GameObject RemainingDaysCountDown;

	public GameObject UIFX_M;

	public GameObject UIFX_W;

	public GameObject UIFX_Mini;

	public GameObject TitleUnactived;

	public UISprite CardIconUnactived;

	public GameObject UIFX_M_Unactived;

	public GameObject UIFX_W_Unactived;

	public GameObject UIFX_Mini_Unactived;

	public UILabel CardNameUnactived;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
