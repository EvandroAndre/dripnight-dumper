using GCommon;

namespace COW;

public class UICraftlandSubscribePopupController : UIPopupWindowController
{
	private const string PIC_URL = "https://dl.dir.freefiremobile.com/common/OB43/CSH/UGC/cdn.png";

	private UICraftlandSubscribePopupView m_View;

	private EventLogger.EventTypeUGCSubscribeToCraftlandUpdate m_SubscribeCraftlandLogger;

	private bool m_NeedSendReq;

	private bool m_Inited;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(bool sendReq)
	{
	}

	public void SetEventLogger(EventLogger.EventTypeUGCSubscribeToCraftlandUpdate eventlogger)
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void OnClickCancelBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void ActiveGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
