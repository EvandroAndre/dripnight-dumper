using GCommon;

namespace COW;

public class AutoTaskSquadTreasureLeaderTransfer : AutoPopupTask
{
	private UIModelSquadTreasure m_Model;

	private UIPopupWindowController m_PopupWnd;

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
}
