using GCommon;

namespace COW;

internal class UIHudCabinWaitingWishItemController : UIBaseController
{
	private UIHudCabinWaitingWishItemView m_View;

	private uint m_ItemId;

	private ItemStateInWishList m_WishState;

	private string m_CurrentItemName;

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

	public void SetState(EventTypeModifyWishListSourceInGame state)
	{
	}

	public void SetViewData(int index, uint itemID)
	{
	}

	private void HideAll()
	{
	}

	private void RefreshView()
	{
	}

	private void OnBtnWishButtonClick()
	{
	}

	public void ResetAnimation()
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
}
