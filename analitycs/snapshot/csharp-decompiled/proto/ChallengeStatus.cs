using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ChallengeStatus : IMessage
{
	public uint challenge_id;

	public EPTarget_Status status;

	public uint update_time;

	public uint[] role_condition;

	public uint count_type;

	public uint player_count;

	public List<ChallengeCdt> conditions;

	public uint date;

	public uint challenge_type;

	public uint special_challenge;

	public uint daily_count;

	public bool is_daily_quest;

	public bool is_unfinished_daily_quest;

	public uint max_daily_count;

	public uint week_id;

	public uint[] game_modes;

	public uint original_challenge_id;

	public bool support_ugc_match;

	public uint[] match_modes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
