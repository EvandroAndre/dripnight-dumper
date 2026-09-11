using GCommon;
using proto;

namespace COW;

public class UIMallV2ExchangeCDNItemController : UIMallV2CDNItemController
{
	private UIMallV2ExchangeCDNItemView m_View;

	private ExchangeStoreItemDesc m_Info;

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

	private void InitCommonWidget()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void RefreshItemView()
	{
	}

	private void SetExchangeInfo()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
