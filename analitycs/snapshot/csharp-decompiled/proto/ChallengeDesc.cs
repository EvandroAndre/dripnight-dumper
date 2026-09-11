using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ChallengeDesc : IMessage
{
	public uint ep_event_id;

	public uint challenge_id;

	public uint challenge_type;

	public string challenge_desc;

	public uint if_reset;

	public EInventory.AwardType award_type;

	public uint award_id;

	public uint award_num;

	public uint count_type;

	public uint[] role_condition;

	public uint player_count;

	public List<ChallengeCondition> conditions;

	public uint date;

	public uint special_challenge;

	public string start_time;

	public EInventory.AwardType award_type2;

	public uint award_id2;

	public uint award_num2;

	public EInventory.AwardType award_type3;

	public uint award_id3;

	public uint award_num3;

	public uint award_time;

	public uint award_time2;

	public uint award_time3;

	public bool is_ep_only;

	public bool is_team_share;

	public uint challenge_group;

	public uint[] game_modes;

	public string go_pos;

	public uint condition_type;

	public string challenge_name;

	public uint is_rank_task;

	public bool support_ugc_match;

	public uint clan_activeness;

	public uint[] match_modes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
