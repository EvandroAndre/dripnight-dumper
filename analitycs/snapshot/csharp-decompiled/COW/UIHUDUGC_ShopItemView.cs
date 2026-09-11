using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ShopItemView : UIBaseView
{
	public UISprite bg02;

	public GameObject OneObjectContainer;

	public UISprite itemSprite;

	public UILabel LabelItemCount;

	public UILabel ItemName;

	public GameObject Highlight;

	public UISprite CoinIcon;

	public UILabel Price;

	public GameObject GrayMask;

	public UILabel Limitation;

	public UILabel SoldOut;

	public UILabel LabelLimitNum;

	public GameObject UIHUDUGC_ShopItem;

	public UIButton ItemBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
