using GCommon;

namespace COW;

public class UILimitedTimeRankNewSeasonPopController : UIPopupWindowController
{
	private UILimitedTimeRankNewSeasonPopView m_View;

	private float m_AutoCloseTime;

	private uint m_AutoCloseDelayCall;

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

	public void SetViewData(uint lastSeasonPoint)
	{
	}

	private void CancelAutoCloseDelayCall()
	{
	}

	private void _003CSetViewData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
