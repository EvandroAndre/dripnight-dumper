using GCommon;

namespace COW;

internal class UIHudFeedZoneController : UIBaseController
{
	private UIHudFeedZoneView m_View;

	private ushort m_Feedid;

	protected float m_EnableFeedTime;

	private uint m_delaycall;

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

	private void OnShowFeedZone(object[] datas)
	{
	}

	private void OnFeedClick()
	{
	}

	private void _003COnFeedClick_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
