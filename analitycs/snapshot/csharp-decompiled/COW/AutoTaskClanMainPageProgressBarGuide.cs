namespace COW;

public class AutoTaskClanMainPageProgressBarGuide : AutoPopupTask
{
	private const string PROGESSBAR_GUIDE_KEY = "ShowClanMainPageProgressBarGuide{0}";

	private string key;

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
