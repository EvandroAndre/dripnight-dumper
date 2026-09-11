using System.Collections.Generic;

namespace proto;

public class SpecificIntimacyRankAwardInfo
{
	public ulong related_friend_id;

	public EFriend.RelationType relation_type;

	public List<IntimacyRankAwardInfo> award_infos;
}
