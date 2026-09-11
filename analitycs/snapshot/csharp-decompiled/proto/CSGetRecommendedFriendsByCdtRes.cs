using System.Collections.Generic;

namespace proto;

public class CSGetRecommendedFriendsByCdtRes
{
	public List<AccountInfoWithPresenceAndSocialInfo> recommend_player_list;

	public bool is_search_result;
}
