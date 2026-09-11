using GCommon;

namespace COW;

internal class UIHudPickupListNewItemController : UIHudPickupListItemController
{
	private IPickupListTagRepeatedSetProxy m_Proxy;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public new static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void InitActions(IPickupListTagRepeatedSetProxy proxy)
	{
	}

	public override void SetHotTag(uint itemID)
	{
	}

	public override void OnPickUpItemAction(bool isAutoPickUp, bool isToSafeBox = false, bool equipImmediately = true)
	{
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetHotTag(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPickUpItemAction(bool P0, bool P1, bool P2)
	{
	}
}
