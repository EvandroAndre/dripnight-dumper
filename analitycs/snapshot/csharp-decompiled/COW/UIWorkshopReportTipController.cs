using System;
using GCommon;

namespace COW;

public class UIWorkshopReportTipController : UIBaseController
{
	private UIWorkshopReportTipView m_View;

	private Action m_OnFeedbackClick;

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

	public void SetViewData(Action onFeedbackClick = null)
	{
	}

	private void OnFeedbackBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
