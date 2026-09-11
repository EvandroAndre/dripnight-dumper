using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_ShopShelfController : UIBaseController
{
	private UIHUDUGC_ShopShelfView m_View;

	private UGCShopShelfRepItem m_BindShopShelfComponent;

	private UGCEntityRepItem m_BindShopItemComponent;

	private List<UIHUDUGC_ShopItemController> m_CachedShopItemCtrls;

	private Dictionary<int, string> m_Wallet;

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

	public void BindShelfEntity(string entityID)
	{
	}

	private void RefreshUI(string entityID)
	{
	}

	public void SetWallet(Dictionary<int, string> wallet)
	{
	}

	private void RefreshName(string name)
	{
	}

	private void RefreshEntityName(string name)
	{
	}

	private void RefreshShopItems(List<object> shopItems)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
