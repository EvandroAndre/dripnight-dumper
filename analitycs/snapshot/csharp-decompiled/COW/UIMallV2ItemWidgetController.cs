using GCommon;

namespace COW;

public class UIMallV2ItemWidgetController : UIMallV2ItemBaseController
{
	public UIMallV2ItemAdaptorView m_View;

	protected UIStandardItemMAXCController m_ItemController;

	protected UIStandardItemMAXCPriceController m_ItemPriceController;

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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
