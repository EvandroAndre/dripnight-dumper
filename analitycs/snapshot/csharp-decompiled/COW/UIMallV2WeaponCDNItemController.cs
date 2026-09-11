using GCommon;
using proto;

namespace COW;

public class UIMallV2WeaponCDNItemController : UIMallV2CDNItemController
{
	private UIMallV2WeaponCDNItemView m_View;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void RefreshItemView()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void ResetState()
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

	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
