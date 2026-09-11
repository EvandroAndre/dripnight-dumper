using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaPurchaseConfirmWndController : UIPopupWindowController
{
	protected UIGachaPurchaseConfirmWndView m_View;

	protected UIModelGacha.GachaDrawType m_DrawType;

	protected UIModelGacha m_ModelGacha;

	protected bool m_IsRepurchase;

	protected uint m_GachaID;

	protected UIGachaBuyBtnController.BuyBtnState m_BuyBtnState;

	protected bool m_IsCloseByPurchase;

	private static Color GemChestNameColor;

	private static Color CoinChestNameColor;

	public UIModelGacha.GachaDrawType DrawType
	{
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	protected virtual Type GetViewType()
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void RefreshUIData(bool isRepurchase, uint chestID, UIGachaBuyBtnController.BuyBtnState buyBtnState = UIGachaBuyBtnController.BuyBtnState.STATE_NONE)
	{
	}

	protected virtual EInventory.CurrencyType GetCurrencyType(uint chestID)
	{
		return EInventory.CurrencyType.CurrencyType_NONE;
	}

	protected virtual uint GetCurrentPrice(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
		return 0u;
	}

	protected virtual bool IsForceGemDisplay(uint chestID)
	{
		return false;
	}

	protected virtual void RefreshMixedPayment(uint chestID, EInventory.CurrencyType currencyType)
	{
	}

	protected virtual void ShowDrawInfo()
	{
	}

	protected virtual void RefreshIcon()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	protected virtual void DoPurchase()
	{
	}

	private bool OnPurchaseBtnClickByEnter()
	{
		return false;
	}

	private void OnNoShowBtnClick()
	{
	}

	private void OnCloseClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CRefreshIcon_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
