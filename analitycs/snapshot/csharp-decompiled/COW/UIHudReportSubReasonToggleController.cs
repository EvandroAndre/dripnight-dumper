using GCommon;

namespace COW;

internal class UIHudReportSubReasonToggleController : UIBaseController
{
	private UIHudReportSubReasonToggleView m_View;

	private uint m_SubReportReason;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string subReasonLoc, uint subReason)
	{
	}

	public uint GetSubReason()
	{
		return 0u;
	}

	public void SetSubReasonUnselect()
	{
	}

	public void SetSubReasonSelected()
	{
	}

	public bool IsSelected()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
