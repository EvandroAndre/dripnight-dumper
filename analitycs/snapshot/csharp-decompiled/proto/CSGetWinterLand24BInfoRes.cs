using System.Collections.Generic;

namespace proto;

public class CSGetWinterLand24BInfoRes
{
	public uint cur_progress;

	public uint[] claimed_progress;

	public bool is_free;

	public List<WinterLand24BFriendInfo> friends;

	public uint cur_friend_token_num;
}
