namespace COW;

public class AutoTaskNetworkSettingAdvice : AutoPopupTask
{
	private UISecondConfirmSmallContoller m_SecondConfirmPopup;

	private UISettingController m_SettingPopup;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	private void OnSecondConfirmConfirmClick()
	{
	}

	private void OnSecondConfirmCloseClick()
	{
	}

	private void OnSecondConfirmCancelClick()
	{
	}

	private bool ClearDataAndReturnState(bool state)
	{
		return false;
	}
}
