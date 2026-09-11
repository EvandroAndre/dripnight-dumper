using System.Collections.Generic;

namespace proto;

public class CSGetTrea25BFriendMapInfoRes
{
	public Trea25BErrorCode code;

	public ulong target_account_id;

	public uint map_id;

	public List<Trea25BGridInfo> grids;
}
