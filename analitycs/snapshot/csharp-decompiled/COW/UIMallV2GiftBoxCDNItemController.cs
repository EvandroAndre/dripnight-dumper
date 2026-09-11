using GCommon;
using proto;

namespace COW;

public class UIMallV2GiftBoxCDNItemController : UIMallV2CDNItemController
{
	private UIMallV2GiftBoxCDNItemView m_View;

	private GiftItem m_Info;

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

	protected override void RefreshItemView()
	{
	}

	private void SetPriceLabel(uint gemsPrice, uint coinsPrice)
	{
	}

	protected override void ResetState()
	{
	}

	public override void SetViewData(object data, int data_index)
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

	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
