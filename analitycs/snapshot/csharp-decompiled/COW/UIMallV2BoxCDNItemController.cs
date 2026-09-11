using GCommon;
using proto;

namespace COW;

public class UIMallV2BoxCDNItemController : UIMallV2CDNItemController
{
	private UIMallV2BoxCDNItemView m_View;

	private StoreDesc m_Info;

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

	protected override void OnStartToggleMove()
	{
	}

	protected override void OnFinishToggleMove()
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

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
