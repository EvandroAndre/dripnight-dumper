using GCommon;
using proto;

namespace COW;

public class UIGachaIchisPurchaseConfirmWndController : UIGachaPurchaseConfirmWndController
{
	private UIModelIchis m_ModelIchis;

	private uint m_IchisChestId;

	private uint m_IchisChestSubId;

	private int m_IchisMultiLevel;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshIchisData(bool isRepurchase, uint chestId, uint chestSubId, int multiLevel, UIGachaBuyBtnController.BuyBtnState buyBtnState)
	{
	}

	protected override EInventory.CurrencyType GetCurrencyType(uint chestID)
	{
		return EInventory.CurrencyType.CurrencyType_NONE;
	}

	protected override uint GetCurrentPrice(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
		return 0u;
	}

	protected override bool IsForceGemDisplay(uint chestID)
	{
		return false;
	}

	protected override void RefreshMixedPayment(uint chestID, EInventory.CurrencyType currencyType)
	{
	}

	protected override void ShowDrawInfo()
	{
	}

	protected override void RefreshIcon()
	{
	}

	protected override void DoPurchase()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EInventory.CurrencyType _003C_003EiFixBaseProxy_GetCurrencyType(uint P0)
	{
		return EInventory.CurrencyType.CurrencyType_NONE;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentPrice(uint P0, UIModelGacha.GachaDrawType P1)
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_IsForceGemDisplay(uint P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshMixedPayment(uint P0, EInventory.CurrencyType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowDrawInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshIcon()
	{
	}

	public void _003C_003EiFixBaseProxy_DoPurchase()
	{
	}
}
