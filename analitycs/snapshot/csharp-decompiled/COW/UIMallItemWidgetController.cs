using GCommon;

namespace COW;

public class UIMallItemWidgetController : UIMallItemBaseController
{
	public UIMallItemAdaptorView m_View;

	protected UIStandardItemMAXBController m_ItemController;

	protected UIStandardItemMAXBPriceController m_ItemPriceController;

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
