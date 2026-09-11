using System.Collections.Generic;

namespace proto;

public class MatchReplayOffender
{
	public ulong account_id;

	public string nickname;

	public List<MatchReplayReporter> reporters;

	public MatchReplayStats match_stats;

	public uint[] behavior_rule_ids;
}
