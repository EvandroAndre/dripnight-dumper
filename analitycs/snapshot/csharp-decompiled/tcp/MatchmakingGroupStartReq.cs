using System.Collections.Generic;

namespace tcp;

public class MatchmakingGroupStartReq
{
	public uint[] map_ids;

	public ulong group_id;

	public EMatch.GroupMode group_mode;

	public List<MatchmakingPlayer> players;

	public EMatch.GameMode game_mode;

	public uint difficulty;

	public bool auto_group;

	public List<GroupMemberAccounts> group_members;

	public string group_idc;

	public EMatch.MatchMode match_mode;

	public uint random_map_id;

	public ulong voice_id;

	public List<string> workshop_codes;

	public bool is_workshop_team_contest;

	public uint[] workshop_team_counts;

	public uint[] valid_map_ids;

	public uint map_priority;

	public uint special_mode_event_id;

	public List<AccountIDCPingInfo> ping_list;

	public ulong[] in_social_friends;

	public bool is_intra_team_battle;
}
