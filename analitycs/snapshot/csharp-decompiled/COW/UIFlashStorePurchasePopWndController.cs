using GCommon;
using proto;

namespace COW;

public class UIFlashStorePurchasePopWndController : UIPopupWindowController
{
	protected UIFlashStorePurchasePopWndView m_View;

	protected FlashStoreGoodsDesc m_SelectItem;

	protected CSSharedItemData m_SelectItemData;

	protected uint m_AcitivityID;

	protected UIModelFlashStore.EFlashStoreItemPriceState m_GemsPriceState;

	protected UIModelFlashStore.ECurrentSelectItemAvailableState m_GemsAvailableState;

	protected bool m_InputExceedNotify;

	protected const string FLASH_GEMS_ICON = "FF_UI_FlashStore_PurpleDiamond";

	protected const string GEMS_ICON = "FF_UI_FlashStore_Diamond";

	protected bool m_IsShowCountModifier;

	protected int m_MaxCount;

	protected int m_Count;

	protected int ItemCount
	{
		get
		{
			return 0;
		}
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

	protected override void OnUIClose()
	{
	}

	protected void OnPurchaseBtnClick()
	{
	}

	protected bool IsShowCountModifier(FlashStoreGoodsDesc exchangeStoreItem, CSSharedItemData m_SelectItemData)
	{
		return false;
	}

	protected void SetMaxCount(int maxCount)
	{
	}

	protected void RefreshPurchaseLabel(uint originalFlashGemsPrice, uint originalGemsPrice, uint flashGemsActualCost, uint gemsActualCost, uint gemsReplenishNeedCnt, UIModelFlashStore.EFlashStoreItemPriceState gemsPriceState, UIModelFlashStore.ECurrentSelectItemAvailableState gemsAvailableState)
	{
	}

	protected void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	private void InitCountModifierView(FlashStoreGoodsDesc exchangeStoreItem, UIModelFlashStore model)
	{
	}

	private void InitViewData()
	{
	}

	public void RefreshViewData(uint acitivityID, FlashStoreGoodsDesc exchangeStoreItem, UIModelFlashStore.EFlashStoreItemPriceState gemsPriceState, UIModelFlashStore.ECurrentSelectItemAvailableState gemsAvailableState)
	{
	}

	protected void OnSelectCntChanged(uint purchaseCnt)
	{
	}

	protected void OnPlusBtnClick()
	{
	}

	protected void OnMinsBtnClick()
	{
	}

	protected void OnMaxBtnClick()
	{
	}

	protected void OnAddTenBtnClick()
	{
	}

	protected void OnCountInputSubmit()
	{
	}

	protected void RefreshCountInput()
	{
	}

	protected void OnCountInputChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
