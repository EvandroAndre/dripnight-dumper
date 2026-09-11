using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AccountInfoWithPresence : IMessage
{
	public ulong account_id;

	public uint account_type;

	public string nickname;

	public string external_id;

	public string external_name;

	public string region;

	public string portrait;

	public uint level;

	public uint exp;

	public long update_time;

	public AccountInfoWithStats solo_stats;

	public AccountInfoWithStats duo_stats;

	public AccountInfoWithStats quad_stats;

	public uint external_type;

	public AccountInfoWithStats solo_ranking_stats;

	public AccountInfoWithStats duo_ranking_stats;

	public AccountInfoWithStats quad_ranking_stats;

	public uint rank;

	public uint ranking_points;

	public AccountInfoWithStats solo_casual_stats;

	public AccountInfoWithStats duo_casual_stats;

	public AccountInfoWithStats quad_casual_stats;

	public uint banner_id;

	public uint head_pic;

	public string clan_name;

	public bool has_elite_pass;

	public uint badge_cnt;

	public uint badge_id;

	public bool is_deleted;

	public bool show_rank;

	public long last_login_at;

	public ulong external_uid;

	public uint role;

	public string championship_team_name;

	public uint championship_team_member_num;

	public uint friend_intimacy;

	public ulong championship_team_id;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint pin_id;

	public AccountInfoWithStats cs_ranking_stats;

	public bool is_cs_ranking_ban;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public uint periodic_ranking_points;

	public uint periodic_rank;

	public long create_at;

	public EAttendance.VeteranLeaveDays veteran_leave_days_tag;

	public List<HuntingGroundRecords> hunting_ground_records;

	public EAttendance.PreVeteranActionType pre_veteran_type;

	public ExternalIconInfo external_icon_info;

	public string release_version;

	public ulong veteran_expire_time;

	public uint friend_intimacy_value;

	public List<HuntingGroundLikePVEInfo> hgl_pve_info;

	public bool show_br_rank;

	public bool show_cs_rank;

	public ulong clan_id;

	public bool disable_friend_spectate;

	public bool membership_state;

	public SocialHighLightsWithSocialBasicInfo social_high_lights_with_basic_info;

	public uint hippo_rank;

	public uint hippo_ranking_points;

	public bool show_hippo_rank;

	public uint hippo_total_profit;

	public uint hippo_total_worth;

	public AccountInfoWithStats hippo_ranking_stats;

	public List<ModeStatsInfo> mode_stats_infos;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint cs_peak_tournament_rank_pos;

	public uint avatar_frame;

	public WorkshopAccountSummaryInfo workshop_summary_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
