using GCommon;
using message;

namespace COW;

public class UIHUDIIV1v1TipController : UIBaseController
{
	public const uint VISIBILITY_STATE_Hide_All = 1073741824u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 536870912u;

	private UIHUDIIV1v1TipView m_View;

	private NMIFFOCJOKC m_CurPhase;

	private UITimeLabelHelper m_PhaseTimeLabelHelper;

	private uint m_DelayCallTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnEnter1v1()
	{
	}

	public void OnExit1v1()
	{
	}

	public void PlayExitTip()
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	private void Update()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void _003CPlayExitTip_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
