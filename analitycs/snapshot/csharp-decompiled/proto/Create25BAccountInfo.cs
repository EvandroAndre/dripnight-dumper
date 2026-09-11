using System.Collections.Generic;

namespace proto;

public class Create25BAccountInfo
{
	public uint total_build_count;

	public List<Create25BVoteInfo> vote_infos;

	public List<Create25BBuildInfo> build_infos;

	public bool is_claimed;
}
