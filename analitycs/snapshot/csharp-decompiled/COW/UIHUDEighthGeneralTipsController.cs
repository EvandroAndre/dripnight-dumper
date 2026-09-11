using GCommon;

namespace COW;

internal class UIHUDEighthGeneralTipsController : UIBaseController
{
	public const uint VISIBILITY_STATE_KillCam_Hide = 1073741824u;

	public const uint VISIBILITY_STATE_Hide_All = 536870912u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 268435456u;

	private UIHUDEighthGeneralTipsView m_View;

	private uint m_DelayHideTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowTips(HUDTipsParams tipsParam)
	{
	}

	private void DelayHide(float delayTime)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void _003CDelayHide_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
