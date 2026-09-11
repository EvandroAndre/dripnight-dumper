using GCommon;

namespace COW;

public class UIMatchNpc_LoadingMaskPopupWndController : UIBigEvent_Template_LoadingMaskPopupWndBaseController
{
	private uint m_DelayCallId;

	private static uint TIME_OFFSET;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowWeakNetTips()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
