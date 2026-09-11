using System.Collections.Generic;

namespace proto;

public class CSGetFollowsRes
{
	public List<AccountInfoBasic> follows;

	public ulong[] pinned_creators;
}
