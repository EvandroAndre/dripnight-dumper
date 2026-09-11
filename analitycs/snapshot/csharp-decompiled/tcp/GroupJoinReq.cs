using System.Collections.Generic;

namespace tcp;

public class GroupJoinReq
{
	public ulong participant_id;

	public string self_region;

	public EGroup.JoinFromType from_type;

	public EGroup.InviteeType target_type;

	public uint[] available_maps;

	public string nickname;

	public uint rank;

	public uint ranking_points;

	public uint emulator_score;

	public string country_code;

	public string signature_md5;

	public uint using_version;

	public ulong partic_group_id;

	public uint system_platform;

	public MatchClientInfo client_info;

	public uint cs_rank;

	public uint cs_ranking_points;

	public List<AccountIDCPingInfo> ping_list;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public ExternalIconInfo external_icon_info;

	public uint head_pic;

	public ulong original_group_id;

	public AccountMatchVeteranData veteran_data;

	public List<SocialHighLight> social_high_lights;

	public LeaderboardTitleInfo leaderboard_titles;

	public ulong original_room_id;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public BadgeInfo badge_info;

	public uint role;

	public bool membership_privilege;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint avatar_frame;

	public EMatch.GameMode social_mode;

	public ulong social_match_id;
}
