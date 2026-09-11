using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_ExchangeStoreItemView : UIBaseView
{
	public GameObject Unlock;

	public UIButton PurchaseBtn;

	public UISprite BtnBG;

	public UILabel CostNum;

	public UISprite CurrencyIcon;

	public UILabel LimitedNum;

	public GameObject SellOut;

	public GameObject Owned;

	public UIButton BtnLock;

	public Transform ItemContainer;

	public UINetworkTexture StoreItemBGCDN;

	public GameObject PurchaseBtnLimitPos;

	public GameObject PurchaseBtnNoLimitPos;

	public GameObject RedTips;

	public UINetworkTexture BtnBGCdn;

	public UILabel OwnedLabel;

	public UINetworkTexture OwnedIcon;

	public UINetworkTexture SellOutBG;

	public UINetworkTexture LockedBG;

	public UILabel LockedLabel;

	public UILabel SelloutLabel;

	public UINetworkTexture NoToken;

	public GameObject goBtnBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
