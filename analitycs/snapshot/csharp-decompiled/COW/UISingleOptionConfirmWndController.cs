using GCommon;

namespace COW;

public class UISingleOptionConfirmWndController : UIPopupWindowController
{
	private UISingleOptionConfirmWndView m_View;

	private SingleOptionConfirmPopWndData m_Data;

	private int OptionCount;

	private int MaxOptionCount;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(SingleOptionConfirmPopWndData data)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
