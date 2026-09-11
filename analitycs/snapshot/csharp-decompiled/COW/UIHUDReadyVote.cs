using GCommon;

namespace COW;

public class UIHUDReadyVote : UIBaseController
{
	private UIHUDReadyVoteView m_View;

	private bool m_IsCurValid;

	private bool m_IsBodyVote;

	private int m_VoteBodyID;

	public int VoteBodyID => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetVoteInfo(bool isBodyVote, int bodyID = -1)
	{
	}

	public void ClearVoteInfo()
	{
	}

	private void ToVote()
	{
	}

	public void SetEnable(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
