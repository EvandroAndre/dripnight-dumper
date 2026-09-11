using System.Text;
using GCommon;

namespace COW;

public class UIHudBanknoteHintController : UIBaseController
{
	private UIHudBanknoteHintView m_View;

	private float m_ControlTargetTime;

	private int m_LastSecond;

	private StringBuilder m_HintText;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void LocalBeginTryControl(object[] data)
	{
	}

	private void StopTryingControlCountDown()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
