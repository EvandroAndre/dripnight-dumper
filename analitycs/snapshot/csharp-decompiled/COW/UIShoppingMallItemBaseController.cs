using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIShoppingMallItemBaseController : UIBaseController, UITable2.IUITable2Item
{
	protected CSSharedItemData m_ItemData;

	protected UIModelShoppingMall m_ModelShoppingMall;

	private UIModelVeteran m_ModelVeteran;

	private int m_Index;

	private ShoppingMallScreenDesc m_ShoppingMallItemData;

	protected GameObject Loading;

	protected GameObject CDNBGGameObject;

	protected UINetworkTexture CDNBG;

	protected GameObject Tag;

	protected GameObject WellSell;

	protected UISprite WellSellSprite;

	protected GameObject Limited;

	protected UISprite LimitedSprite;

	protected GameObject Discount;

	protected UISprite DiscountSprite;

	protected UILabel DiscountLabel;

	protected GameObject Channel;

	protected UISprite ChannelIcon;

	protected GameObject RareDegree;

	protected UISprite RareIcon;

	protected GameObject OpenTime;

	protected UILabel OpenTimeLabel;

	protected UIButton ClickBtn;

	protected GameObject New;

	protected Animation ShoppingMallItemAnimator;

	protected GameObject Remind;

	protected GameObject VeteranDiscountGameObject;

	protected UILabel VeteranDiscountLabel;

	protected override void OnUIInit()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetViewData(object data)
	{
	}

	private void ShowCDNBG(string URL)
	{
	}

	private void ShowTag(uint TagType, uint DiscountNumber)
	{
	}

	private void ShowChannelIcon(uint ChannelType)
	{
	}

	private void ShowCDNTime(string beginTime, string endTime, bool IsShow)
	{
	}

	private void ShowRareIcon(uint id, bool isShow = true)
	{
	}

	private void ShowVeteranDiscount(uint sortid)
	{
	}

	private void PlayAnimation(object[] param)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
