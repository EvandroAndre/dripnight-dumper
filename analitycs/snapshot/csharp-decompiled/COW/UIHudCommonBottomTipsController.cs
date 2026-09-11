using GCommon;

namespace COW;

public class UIHudCommonBottomTipsController : UIBaseController
{
	public class HudCommonBottomTipsParams : GEvent
	{
		public string TipsLabel;

		public ResourceID IconResID;

		public float ShowDuration;
	}

	private UIHudCommonBottomTipsView m_View;

	private uint m_DelayHideTicket;

	public const uint VISIBILITY_STATE_KillCam_Hide = 1073741824u;

	public const uint VISIBILITY_STATE_Hide_All = 536870912u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 268435456u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void ShowTips(HudCommonBottomTipsParams tipsParam)
	{
	}

	private void DelayHide(float delayTime)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void _003CDelayHide_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
