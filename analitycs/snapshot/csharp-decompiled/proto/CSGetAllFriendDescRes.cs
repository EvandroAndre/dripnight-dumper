using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAllFriendDescRes : IMessage
{
	public List<RelationTypeInfoDesc> relation_type_info_desc;

	public FriendSettingDesc friend_setting_desc;

	public InviteAbtestDesc invite_abtest_desc;

	public List<ItemIntimacyOverrideDesc> item_intimacy_override_desc;

	public MatchmakingBlacklistParamDesc matchmaking_blacklist_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
