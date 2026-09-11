using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudInGameAirDropShopController : UIHudInGameShopBaseController
{
	private bool m_ShopItemInited;

	private BGMFPPDLCBB m_ChoosedItemInfo;

	private int m_CurBagCapacity;

	private int m_MaxBagCapacity;

	private Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

	private uint m_TipDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnTokenChanged(int data)
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void OnShowHud(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitShopItems()
	{
	}

	private void RefreshShopItems(bool isAddItem)
	{
	}

	private void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	private void OnCoinBtnClick()
	{
	}

	private void OnCapacityBtnClick()
	{
	}

	private void ClearSelected()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnBuyResultSync(int ret)
	{
	}

	private void OnBagCapacityChanged(bool data)
	{
	}

	private void UpdateBagCapacityText()
	{
	}

	private void OnShopDiscount()
	{
	}

	private void _003COnCoinBtnClick_003Eb__18_0()
	{
	}

	private void _003COnCapacityBtnClick_003Eb__19_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTokenChanged(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
