using GCommon;

namespace COW;

internal class UIHudMetropolisShopItemController : UIHudCSEquipItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool OnCheckItemCanShow(CSShopItemData data)
	{
		return false;
	}

	protected override void OnAfterSetShopItemData(CSShopItemData data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheckItemCanShow(CSShopItemData P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAfterSetShopItemData(CSShopItemData P0)
	{
	}
}
