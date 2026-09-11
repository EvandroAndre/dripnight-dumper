using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCAskPurchaseItemController : UIEasyListItemController
{
	private UIHudAskPurchaseItemView m_View;

	private UGCAskPurchaseInfo m_Info;

	private UGCShopItemRepItem m_BindShopItemRepItem;

	private UGCWalletRepItem m_BindWalletRepItem;

	private static Color ENABLE_COLOR;

	private static Color DISABLE_COLOR;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int index)
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshPayBtnStatus()
	{
	}

	private float GetBalanceOfCoinType(int coinType)
	{
		return 0f;
	}

	private void OnClickPurchaseBtn()
	{
	}

	private void OnWalletContentChang(List<object> walletContent)
	{
	}

	private void OnCanPurchaseChange(bool canBuys)
	{
	}

	private void OnCurTotalPurchaseLimitChange(int limit)
	{
	}

	private void OnIconTypeChange(string icon)
	{
	}

	private void OnMoneyTypeChange(int type)
	{
	}

	private void OnPriceChange(int price)
	{
	}

	private void _003CRefreshUI_003Eb__10_0(UIAtlas atlas, string spriteName)
	{
	}

	private void _003CRefreshUI_003Eb__10_1(UIAtlas atlasData, string spriteData)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
