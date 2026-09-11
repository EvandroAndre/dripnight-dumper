using GCommon;

namespace COW;

internal class UIHudReportMainReasonToggleController : UIBaseController
{
	private UIHudReportMainReasonToggleView m_View;

	private uint reason;

	private int m_SubReasonNum;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(string reasonLoc, uint reason, string descLoc)
	{
	}

	public uint GetSelectedReason()
	{
		return 0u;
	}

	public void MainReasonToggleOnClick()
	{
	}

	public void DisableToggle()
	{
	}

	public void InitSelectCallBack()
	{
	}

	public UIToggleButton GetToggle()
	{
		return null;
	}

	public UIGrid GetGrid()
	{
		return null;
	}

	public void SetSelectState(bool v)
	{
	}

	public void SetSubReasonNum(int num)
	{
	}

	public void SetSubReasonNumNew(int num)
	{
	}

	public void SetSubContainerWidgetIgnoreBoundsIncludeSelf(bool v = false)
	{
	}

	public void SetClanReason()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
