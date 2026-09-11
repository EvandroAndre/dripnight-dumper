using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudQuickReportFeedbackController : UIPopupWindowController
{
	private UIHudQuickReportFeedbackView m_View;

	private ReportFeedbackData m_Data;

	private UIBaseProfileInfoController m_Profile;

	private List<UIHudQuickReportFeedbackTagController> m_TagControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ReportFeedbackData data)
	{
	}

	private void SetSuccessView()
	{
	}

	private void SetFailedView()
	{
	}

	private void DisplayBehaviorTag(UITable table)
	{
	}

	private void ShowProfile()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnMoreClick()
	{
	}

	private void SendEventLogReport()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
