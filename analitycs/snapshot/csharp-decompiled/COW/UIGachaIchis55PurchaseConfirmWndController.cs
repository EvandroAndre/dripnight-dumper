using GCommon;
using proto;

namespace COW;

public class UIGachaIchis55PurchaseConfirmWndController : UIPopupWindowController
{
	private UIGachaIchis55PurchaseConfirmWndView m_View;

	private UIModelGacha m_ModelGacha;

	private UIModelIchis m_ModelIchis;

	private UIModelGacha.GachaDrawType m_DrawType;

	private bool m_IsRepurchase;

	private uint m_GachaID;

	private UIGachaBuyBtnController.BuyBtnState m_BuyBtnState;

	private bool m_IsCloseByPurchase;

	private uint m_IchisChestId;

	private uint m_IchisChestSubId;

	private int m_IchisMultiLevel;

	public UIModelGacha.GachaDrawType DrawType
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshIchisData(bool isRepurchase, uint chestId, uint chestSubId, int multiLevel, UIGachaBuyBtnController.BuyBtnState buyBtnState)
	{
	}

	private void RefreshUIData(bool isRepurchase, uint chestID, UIGachaBuyBtnController.BuyBtnState buyBtnState)
	{
	}

	private void RefreshIchis55CDNBGTexture()
	{
	}

	private EInventory.CurrencyType GetCurrencyType(uint chestID)
	{
		return EInventory.CurrencyType.CurrencyType_NONE;
	}

	private uint GetCurrentPrice(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
		return 0u;
	}

	private void RefreshMixedPayment(uint chestID, EInventory.CurrencyType currencyType)
	{
	}

	private void ShowDrawInfo()
	{
	}

	private void RefreshIcon()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void DoPurchase()
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
