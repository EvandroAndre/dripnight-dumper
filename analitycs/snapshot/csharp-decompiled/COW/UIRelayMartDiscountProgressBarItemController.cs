using GCommon;

namespace COW;

public class UIRelayMartDiscountProgressBarItemController : UIBaseController
{
	private UIRelayMartDiscountProgressBarItemView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private uint m_Level;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(uint level)
	{
	}

	public void RefreshItemState()
	{
	}

	public void RefreshItemStateInternal(ERelayMartDiscountProgressBarItemState state)
	{
	}

	private void RefreshItemView()
	{
	}

	private ERelayMartDiscountProgressBarItemState GetItemState(uint level)
	{
		return ERelayMartDiscountProgressBarItemState.NotReached;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
