using GCommon;

namespace COW;

internal class UIHudPresetEntryController : UIBaseController
{
	private UIHudPresetEntryView m_View;

	private BitArrayBoolean m_Visible;

	private const uint ISVISIBLE_SHOWENTRY = 1u;

	private const uint ISVISIBLE_SHOWACTION = 2u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowPresetEntry(bool data)
	{
	}

	private void OnActionShow(bool data)
	{
	}

	private void OnShopBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
