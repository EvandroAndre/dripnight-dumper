using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GuildWarTournamentDesc : IMessage
{
	public uint season_id;

	public uint season_type;

	public uint round_type;

	public uint round_id;

	public uint season_round_id;

	public uint point_param_id;

	public long season_start_time;

	public long season_end_time;

	public long pre_heat_start_time;

	public long match_start_time;

	public long match_end_time;

	public long settlement_end_time;

	public uint point_advance;

	public uint rank_advance;

	public uint award_limit;

	public List<AwardDesc> awards;

	public bool slap_is_open;

	public string slap_cdn;

	public uint rank_qualification;

	public uint point_qualification;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
