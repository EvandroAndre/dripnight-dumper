using GCommon;

namespace COW;

internal class AutoTaskBigEventWarmUp : AutoPopupTask
{
	private UIBaseController m_WarmUpWnd;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	private bool CheckFirstEnter(int eventId)
	{
		return false;
	}

	public static void MarkFirstEnter(int eventId)
	{
	}

	public override bool IsDone()
	{
		return false;
	}
}
