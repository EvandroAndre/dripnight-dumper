using GCommon;

namespace COW;

public class UIDrawShopUnlimitedTokenWheelPreviewPopWndController : UIPopupWindowController
{
	private UIDrawShopUnlimitedTokenWheelPreviewPopWndView m_View;

	private uint m_ChestId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(uint chestId)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
