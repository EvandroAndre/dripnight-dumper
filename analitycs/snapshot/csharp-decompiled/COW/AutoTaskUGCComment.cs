namespace COW;

public class AutoTaskUGCComment : AutoPopupTask
{
	private UIUGCMatchResultCommentController m_Ctrl;

	private UICraftlandSubscribePopupController m_SubscribePopupCtrl;

	public bool InLobby;

	private bool m_request;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	private void AfterRequestGameMapSlotInfo()
	{
	}

	public override bool IsDone()
	{
		return false;
	}

	private void _003CAfterRequestGameMapSlotInfo_003Eb__6_0()
	{
	}
}
