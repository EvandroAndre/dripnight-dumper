using GCommon;
using proto;

namespace COW;

public class UIDrawShopLimitedBuyBtnController : UIDrawShopBuyBtnBaseController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIDrawShopLimitedBuyBtnController _003C_003E4__this;

		public bool isRepurchase;

		internal void _003COnMultiBuy_003Eb__0()
		{
		}
	}

	private DrawShopLimitedPoolSettingDesc m_SettingDesc;

	private int m_NextTurn;

	private const int MAX_TURN_COUNT = 8;

	private DrawShopPoolItemData m_SelectedItemData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitViewSetting()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void UpdateMultiBuyLabel()
	{
	}

	protected override UIModelDrawShop.EDrawShopBuyBtnState CalcBuyBtnState(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return UIModelDrawShop.EDrawShopBuyBtnState.Normal;
	}

	private bool CheckDiscountAvailable()
	{
		return false;
	}

	public void RefreshBtnStateWithTurn(uint chestId, DrawShopLimitedPoolSettingDesc settingDesc, int nextTurn)
	{
	}

	protected override void ApplyMultiBtnSkin()
	{
	}

	public void SetSelectedItemData(DrawShopPoolItemData selectedItemData)
	{
	}

	public void SetBuyButtonEnabled(bool enabled)
	{
	}

	public override void OnMultiBuy(bool isRepurchase)
	{
	}

	private void ExecutePurchase(bool isRepurchase)
	{
	}

	protected void PurchaseLimitedPoolItem()
	{
	}

	protected override void ShowMultiNormalBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	protected override void ShowMultiDiscountBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	private void _003CApplyMultiBtnSkin_003Eb__11_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateMultiBuyLabel()
	{
	}

	public UIModelDrawShop.EDrawShopBuyBtnState _003C_003EiFixBaseProxy_CalcBuyBtnState(UIModelDrawShop.EDrawShopDrawType P0)
	{
		return UIModelDrawShop.EDrawShopBuyBtnState.Normal;
	}

	public void _003C_003EiFixBaseProxy_ApplyMultiBtnSkin()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMultiBuy(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowMultiNormalBuyUI(UIModelDrawShop.DrawShopUniversalData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowMultiDiscountBuyUI(UIModelDrawShop.DrawShopUniversalData P0)
	{
	}
}
