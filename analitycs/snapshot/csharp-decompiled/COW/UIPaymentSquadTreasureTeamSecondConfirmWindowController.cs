using System;
using GCommon;

namespace COW;

public class UIPaymentSquadTreasureTeamSecondConfirmWindowController : UIPopupWindowController
{
	private UIPaymentSquadTreasureTeamSecondConfirmWindowView m_View;

	private Action m_ConfirmCallback;

	private Action m_CancelCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string title, string content, Action confirmCallback, Action cancelCallback)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
