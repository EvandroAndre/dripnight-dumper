using System.Collections.Generic;

namespace proto;

public class MultiIntimacyRankAwardDesc
{
	public EChummy.MultiRelationType multi_relation_type;

	public EChummy.Role relation_role;

	public uint intimacy_rank;

	public uint intimacy_point;

	public List<AwardDesc> awards;
}
