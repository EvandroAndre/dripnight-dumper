namespace COW;

public class NearbyFriendAddLog
{
	private int m_TotalNearbyPlayersSeen;

	private int m_FriendRequestsSent;

	private int m_FriendRequestsSuccess;

	private int m_GroupInviteOrJoinSent;

	private int m_GroupTeamUpSuccess;

	private int m_GroupMatchStarted;

	public int TotalNearbyPlayersSeen => 0;

	public int FriendRequestsSent => 0;

	public int FriendRequestsSuccess => 0;

	public int GroupInviteOrJoinSent => 0;

	public int GroupTeamUpSuccess => 0;

	public int GroupMatchStarted => 0;

	public void AddNearbyPlayersCount(int count)
	{
	}

	public void IncrementRequestSent()
	{
	}

	public void IncrementRequestSuccess()
	{
	}

	public void IncrementGroupInviteOrJoinSent()
	{
	}

	public void IncrementGroupTeamUpSuccess()
	{
	}

	public void IncrementMatchStarted()
	{
	}

	private void LogCurrentStats(string action)
	{
	}

	public void Reset()
	{
	}
}
