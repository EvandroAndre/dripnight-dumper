using GCommon;

namespace COW;

internal class UIHudPVEBossInfoController : UIBaseController
{
	private const byte MAX_TURN_COUNT = 4;

	private UIHudPVEBossInfoView m_View;

	private uint m_delcayCall;

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

	private void OnInWarningRegion(object[] data)
	{
	}

	private void ShowWarningText(float delayTime, string text_content)
	{
	}

	private void _003CShowWarningText_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
