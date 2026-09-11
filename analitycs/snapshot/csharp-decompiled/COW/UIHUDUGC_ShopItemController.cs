using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHUDUGC_ShopItemController : UIBaseController
{
	private UIHUDUGC_ShopItemView m_View;

	private OCCPFLJFOHI m_ShopRunner;

	private UGCShopItemRepItem m_BindUGCShopItemRepItem;

	private bool m_Selected;

	private BitArrayBoolean m_ShowGrayMask;

	private const uint MASK_LIMIT_INDEX = 1u;

	private const uint MASK_COIN_INDEX = 2u;

	private Dictionary<int, string> m_Wallet;

	private UGCMoneyRepItem m_BindMoneyComponent;

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

	public void DestroyEntity()
	{
	}

	public void BindItemEntity(string entity)
	{
	}

	private void RefreshUI(string entityID)
	{
	}

	private void RefreshContent(List<object> list)
	{
	}

	private void OnCanPurchasChanged(bool data)
	{
	}

	private void OnCurPriceChanged(int data)
	{
	}

	public void SetWallet(Dictionary<int, string> wallet)
	{
	}

	private void OnMoneyTypeChanged(int data)
	{
	}

	private void BindMoneyEntity()
	{
	}

	private void OnCountChangeEvent(float cur)
	{
	}

	private void OnMoneyIconChangeEvent(string cur)
	{
	}

	public void RefreshMoney()
	{
	}

	private void OnCurTotalPurchaseLimitChangeEvent(int cur)
	{
	}

	private void OnItemBtnClick()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void SetSelected(bool v)
	{
	}

	private void _003CRefreshUI_003Eb__14_0(string icon)
	{
	}

	private void _003CRefreshUI_003Eb__14_1(string name)
	{
	}

	private void _003CRefreshUI_003Eb__14_2(string desc)
	{
	}

	private void _003CRefreshContent_003Eb__15_1(UIAtlas atlasData, string spriteData)
	{
	}

	private void _003CRefreshContent_003Eb__15_0(UIAtlas atlasData, string spriteData)
	{
	}

	private void _003COnMoneyIconChangeEvent_003Eb__22_0(UIAtlas atlas, string spriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
