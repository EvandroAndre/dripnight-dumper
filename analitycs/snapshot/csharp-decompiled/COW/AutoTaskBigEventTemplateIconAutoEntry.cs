using proto;

namespace COW;

internal class AutoTaskBigEventTemplateIconAutoEntry : AutoPopupTask
{
	public static string PrefAutoTaskBigEventTemplateIconAutoEntry;

	private UIBigEvent_Template_LobbyIconWndController m_PopupWnd;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	protected bool CheckIconCdnNeedDownload(CustomEventLobbyIconDesc desc)
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
