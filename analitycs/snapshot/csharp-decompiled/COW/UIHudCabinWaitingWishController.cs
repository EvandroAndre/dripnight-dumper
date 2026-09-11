using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudCabinWaitingWishController : UIBaseController
{
	private UIHudCabinWaitingWishView m_View;

	private readonly List<UIHudCabinWaitingWishItemController> m_HudCabinWaitingWishItemController;

	private uint m_PlayerID;

	private EventTypeModifyWishListSourceInGame m_State;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(uint playerID, EventTypeModifyWishListSourceInGame state)
	{
	}

	public void OnWishListGet(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
