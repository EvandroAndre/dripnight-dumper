using GCommon;

namespace COW;

public class UIMallV2WeaponWidgetItemController : UIMallV2ItemWeaponBaseController
{
	public UIMallV2WeaponItemAdaptorView m_View;

	protected UIStandardItemWeaponController m_ItemController;

	protected UIStandardItemWeaponPriceController m_ItemPriceController;

	protected bool m_CreateItemPriceCtrl;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetParentWidget()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
