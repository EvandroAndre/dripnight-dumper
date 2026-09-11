using GCommon;

namespace COW;

internal class UIHudTDMLikeEquipItemController : UIBaseController
{
	private UIHudInGameShopItemViewExt m_View;

	private TDMLikeShopConfigData m_Data;

	private bool m_Selected;

	private uint m_Price;

	private uint m_LimitCnt;

	private uint m_PurchaseCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void OnItemBtnClick()
	{
	}

	public void SetUIData(TDMLikeShopConfigData data)
	{
	}

	private void RefreshPrice(object[] data)
	{
	}

	private void CheckLimitation()
	{
	}

	private uint GetLimitCount()
	{
		return 0u;
	}

	private void OnItemPurchased(object[] data)
	{
	}

	private void CheckPriceValid()
	{
	}

	private void CheckItemsValid()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void SetSelected(bool v)
	{
	}

	private void OnCoinChanged(int data)
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
