using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class FriendSettingDesc : IMessage
{
	public uint friend_limited;

	public List<string> open_recommend_list_filter_regions;

	public uint membership_friend_limited;

	public uint un_active_friend_threshold;

	public uint intimacy_remind_limit;

	public uint prime_friend_limited_add;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
