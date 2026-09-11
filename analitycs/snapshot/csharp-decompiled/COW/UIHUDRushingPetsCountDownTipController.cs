using GCommon;
using message;

namespace COW;

public class UIHUDRushingPetsCountDownTipController : UIBaseController
{
	private UIHUDRushingPetsCountDownTipView m_View;

	private ADJGKGIEEBL m_CurPhaseType;

	private float m_EndTime;

	private uint m_GoShowDelayID;

	private int m_LastLeftTimeCeil;

	private bool m_IsNeedUpdateOneSecond;

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

	private void OnNewPhase(object[] data)
	{
	}

	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTimeShow()
	{
	}

	private void _003COnNewPhase_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
