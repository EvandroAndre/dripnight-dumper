using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class GroupJoinRequestNtf : IMessage
{
	public ulong joiner_id;

	public uint[] available_maps;

	public string nickname;

	public uint rank;

	public uint ranking_points;

	public uint emulator_score;

	public string country_code;

	public string signature_md5;

	public uint using_version;

	public EGroup.InviteeType target_type;

	public uint system_platform;

	public MatchClientInfo client_info;

	public uint cs_rank;

	public uint cs_ranking_points;

	public List<AccountIDCPingInfo> ping_list;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public ExternalIconInfo external_icon_info;

	public uint head_pic;

	public AccountMatchVeteranData veteran_data;

	public List<SocialHighLight> social_high_lights;

	public LeaderboardTitleInfo leaderboard_titles;

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

	public string region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
