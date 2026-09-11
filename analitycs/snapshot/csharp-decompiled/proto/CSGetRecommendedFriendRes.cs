using System.Collections.Generic;

namespace proto;

public class CSGetRecommendedFriendRes
{
	public List<AccountInfoWithPresence> rand_friend_list;

	public List<AccountInfoWithPresence> common_friend_list;

	public uint[] common_friend_nums;

	public uint recommend_source;

	public List<CommonFriendIdList> common_friend_id_lists;
}
