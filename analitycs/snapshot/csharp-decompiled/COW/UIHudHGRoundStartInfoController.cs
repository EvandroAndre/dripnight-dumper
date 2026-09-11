using System.Text;
using GCommon;

namespace COW;

public class UIHudHGRoundStartInfoController : UIBaseController
{
	private UIHudHGRoundStartInfoView m_View;

	private uint m_DelayShowID;

	private StringBuilder m_Timer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CancelDelayCall()
	{
	}

	public void ShowData(HuntingGroundRoundInfoData roundInfoData)
	{
	}

	private void _003CShowData_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
