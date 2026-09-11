using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaELS_TT53PurchaseConfirmWndController : UIPopupWindowController
{
	private UIGachaELS_TT53PurchaseConfirmWndView m_View;

	private UIModelGacha.GachaDrawType m_DrawType;

	private UIModelGacha m_ModelGacha;

	private bool m_IsRepurchase;

	private uint m_GachaID;

	private UIGachaBuyBtnController.BuyBtnState m_BuyBtnState;

	private bool m_IsCloseByPurchase;

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

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void RefreshUIData(bool isRepurchase, uint chestID, UIGachaBuyBtnController.BuyBtnState buyBtnState = UIGachaBuyBtnController.BuyBtnState.STATE_NONE)
	{
	}

	private void SetCDNBG()
	{
	}

	private void ShowDrawInfo()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private bool OnPurchaseBtnClickByEnter()
	{
		return false;
	}

	private void OnNoShowBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
