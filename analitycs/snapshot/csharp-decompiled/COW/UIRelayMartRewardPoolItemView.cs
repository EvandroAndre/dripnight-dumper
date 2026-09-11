using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartRewardPoolItemView : UIBaseView
{
	public GameObject UIRelayMartRewardPoolItem;

	public Transform RewardItemContainer;

	public UIButton BtnCartAction;

	public GameObject NormalState;

	public GameObject AddedState;

	public UILabel DiscountLabel;

	public GameObject CoreItemVFX;

	public GameObject OwnedState;

	public GameObject PreviewFemale;

	public GameObject PreviewMale;

	public GameObject PreviewCommon;

	public GameObject LimitedTitle;

	public GameObject OwnedTitle;

	public GameObject DiamondPriceContainer;

	public UILabel ActualPrice;

	public UILabel OriginalPrice;

	public GameObject Sel;

	public GameObject GrayState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
