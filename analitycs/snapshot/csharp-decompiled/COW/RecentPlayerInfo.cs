using System;
using proto;

namespace COW;

public class RecentPlayerInfo : IComparable<RecentPlayerInfo>
{
	public ulong m_Time;

	public ERecentPlayerType m_Type;

	public FriendAccountInfo m_Info;

	public int CompareTo(RecentPlayerInfo other)
	{
		return 0;
	}

	public int ComparePresence(EPresence.AccountPresence presence)
	{
		return 0;
	}
}
