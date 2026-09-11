namespace COW;

public class AutoTaskPreVeteran : AutoPopupTask
{
	private UIPreVeteranController m_PreVeteranCtrl;

	private UILuckyBuffBattleController m_LuckyBuffBattleCtrl;

	private UIModelPreVeteran m_Model;

	private string IS_ACTIVITY_FIRST_POP_UP_DONE_KEY;

	private string AUTO_TASK_BUFF_POP_UP_CD;

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
