using System;
using GCommon;

namespace COW;

public class UIRoomReopenPopController : UIPopupWindowController
{
	private UIRoomReopenPopView m_View;

	private Action m_OnOK;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(Action onOk)
	{
	}

	private void OnBtnConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
