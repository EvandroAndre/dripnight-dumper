using System;
using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GuildWarOpenInfoDesc : IMessage, IComparable<GuildWarOpenInfoDesc>
{
	public uint season_id;

	public uint round_id;

	public long season_start_time;

	public long season_end_time;

	public long pre_heat_start_time;

	public long match_start_time;

	public long match_end_time;

	public long settlement_end_time;

	public bool slap_is_open;

	public string slap_cdn;

	public List<AwardDesc> awards;

	public uint award_limit;

	public bool is_final_round;

	public string award_cdn;

	public string guild_war_icon_cdn;

	public string which_day;

	public bool barrage_is_open;

	public List<AwardDesc> per_round_awards;

	public uint per_round_award_score_limit;

	public long part1_end_time;

	public long part2_start_time;

	public long part2_end_time;

	public long part3_start_time;

	public string part1_which_day;

	public string part2_which_day;

	public string part3_which_day;

	public long part1_settlement_end_time;

	public long part2_settlement_end_time;

	public uint season_type;

	public uint point_param_id;

	public AwardDesc top_award;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public int CompareTo(GuildWarOpenInfoDesc other)
	{
		return 0;
	}
}
