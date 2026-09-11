using System.Collections.Generic;

namespace tcp;

public class GroupRecruitQuickJoinReq
{
	public ulong group_id;

	public string language;

	public bool map_pool_bonus;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatch.GroupMode group_mode;

	public uint br_rank;

	public uint cs_rank;

	public uint[] tags;

	public uint[] available_maps;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<AccountIDCPingInfo> ping_list;

	public uint special_mode_event_id;

	public uint min_rank;

	public bool is_all_mode;

	public uint[] limit_occupations_br;

	public uint[] limit_occupations_cs;

	public uint hippo_rank;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<MapVersionInfo> map_versions;

	public List<AccountIDCPingInfo> voice_ping_list;

	public TransformEmoteInfo transform_emote_info;

	public string gp_player_id;

	public uint cs_peak_points;

	public string ugc_social_url;

	public uint max_rank;

	public RecruitPlayerBasicInfo recruit_player_basic_info;

	public EGroup.InviteChannelType channel;
}
