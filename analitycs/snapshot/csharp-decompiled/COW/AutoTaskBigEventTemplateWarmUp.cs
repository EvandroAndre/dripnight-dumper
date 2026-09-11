namespace COW;

internal class AutoTaskBigEventTemplateWarmUp : AutoPopupTask
{
	public static string PrefAutoTaskBigEventTemplateLobbyWarmUp;

	private UIBigEvent_Template_LobbyWarmUpController m_WarmUpWnd;

	public static bool NeedAutoTask()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	protected bool CheckEventUseWarmUp(EBigEventTemplateUseType useType)
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
