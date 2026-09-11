using GCommon;

namespace COW;

public class UIMatchNpc_AnimPopWndController : UIPopupWindowController
{
	private const uint ANIM_PLAYTIME = 4u;

	protected uint m_DelayCallId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnAnimClose()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
