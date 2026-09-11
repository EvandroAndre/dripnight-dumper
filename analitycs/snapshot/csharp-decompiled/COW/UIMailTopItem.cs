using GCommon;

namespace COW;

internal class UIMailTopItem : UIBaseController
{
	private UIMailTopItemView m_View;

	private UIMailTabChangeDelegate m_TabChangeDelegate;

	private UIModelMail m_ModelMail;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetTabChangeDelegate(UIMailTabChangeDelegate func)
	{
	}

	private void ChangeTab(MailTab mailTab)
	{
	}

	public void RefreshDot()
	{
	}

	public void OnClickNoticeTabBtn()
	{
	}

	public void OnClickSystemTabBtn()
	{
	}

	public void OnClickReportTabBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
