using System.Collections.Generic;

namespace proto;

public class IntimacyAwardDesc
{
	public EFriend.RelationType relation_type;

	public uint rank;

	public List<AwardDesc> awards;

	public EFriend.IntimacyAwardType intimacy_award_type;
}
