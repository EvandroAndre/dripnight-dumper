using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIChatReportController : UIPopupWindowController
{
	private UIChatReportView m_View;

	private uint m_SelectedReason;

	private MessageInfo m_MessageData;

	private List<MessageInfo> m_MessagesList;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetUIData(MessageInfo message, List<MessageInfo> messageInfos)
	{
	}

	private void OnReportReasonSelect(UIToggleButton button)
	{
	}

	private List<string> GetReportMessageList()
	{
		return null;
	}

	private void OnReportButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
