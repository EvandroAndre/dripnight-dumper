using System.Collections.Generic;

namespace tcp;

public class RematchTeamInfo
{
	public ulong team_id;

	public List<RematchPlayer> players;

	public long end_timestamp;

	public uint text_type;

	public ulong mvp_user_id;

	public uint total_kills;

	public uint total_revives;

	public float avg_rating;
}
