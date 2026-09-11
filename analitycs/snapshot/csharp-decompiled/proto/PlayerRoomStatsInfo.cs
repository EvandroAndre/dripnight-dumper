using System.Collections.Generic;

namespace proto;

public class PlayerRoomStatsInfo
{
	public ulong account_id;

	public List<RoomWinStats> win_stats;

	public List<RoomFriendWinStats> friend_stats;
}
