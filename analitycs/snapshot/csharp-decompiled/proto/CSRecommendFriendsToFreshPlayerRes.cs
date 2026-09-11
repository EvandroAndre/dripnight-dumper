using System.Collections.Generic;

namespace proto;

public class CSRecommendFriendsToFreshPlayerRes
{
	public class Player
	{
		public AccountInfoBasic account_info;

		public EFriend.FreshPlayerRecommendSource source;

		public string social_willingness;

		public uint booyah_times;

		public uint saving_times;

		public uint match_times;
	}

	public List<Player> players;

	public uint page_show_count;
}
