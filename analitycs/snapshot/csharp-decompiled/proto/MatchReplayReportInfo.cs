using System.Collections.Generic;

namespace proto;

public class MatchReplayReportInfo
{
	public uint create_time;

	public uint end_time;

	public uint game_mode;

	public uint group_mode;

	public List<MatchReplayOffender> offenders;

	public bool is_in_special_pool;
}
