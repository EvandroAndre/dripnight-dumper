using System.Collections.Generic;

namespace proto;

public class CSGetTrendAgentBInfoRes
{
	public List<TrendAgentBInfo> account_infos;

	public uint left_vote_num;

	public long current_server_time;

	public uint current_theme_id;
}
