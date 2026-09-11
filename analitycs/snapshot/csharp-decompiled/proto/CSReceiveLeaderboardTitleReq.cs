using System.Collections.Generic;

namespace proto;

public class CSReceiveLeaderboardTitleReq
{
	public class ReceiveLeaderboardTypeTitle
	{
		public uint[] title_id;

		public ELeaderboard.LeaderboardMainType main_type;
	}

	public List<ReceiveLeaderboardTypeTitle> receive_title;
}
