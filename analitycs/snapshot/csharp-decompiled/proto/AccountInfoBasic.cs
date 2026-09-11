using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AccountInfoBasic : IMessage
{
	public ulong account_id;

	public uint account_type;

	public string nickname;

	public string external_id;

	public string region;

	public uint level;

	public uint exp;

	public uint external_type;

	public string external_name;

	public string external_icon;

	public uint banner_id;

	public uint head_pic;

	public string clan_name;

	public uint rank;

	public uint ranking_points;

	public uint role;

	public bool has_elite_pass;

	public uint badge_cnt;

	public uint badge_id;

	public uint season_id;

	public uint liked;

	public bool is_deleted;

	public bool show_rank;

	public long last_login_at;

	public ulong external_uid;

	public long return_at;

	public string championship_team_name;

	public uint championship_team_member_num;

	public ulong championship_team_id;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint[] weapon_skin_shows;

	public uint pin_id;

	public bool is_cs_ranking_ban;

	public uint max_rank;

	public uint cs_max_rank;

	public uint max_ranking_points;

	public uint game_bag_show;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public AccountPrefers account_prefers;

	public uint periodic_ranking_points;

	public uint periodic_rank;

	public long create_at;

	public EAttendance.VeteranLeaveDays veteran_leave_days_tag;

	public uint[] selected_item_slots;

	public EAttendance.PreVeteranActionType pre_veteran_type;

	public uint title;

	public ExternalIconInfo external_icon_info;

	public string release_version;

	public ulong veteran_expire_time;

	public bool show_br_rank;

	public bool show_cs_rank;

	public ulong clan_id;

	public uint clan_badge_id;

	public string custom_clan_badge;

	public bool use_custom_clan_badge;

	public uint clan_frame_id;

	public bool membership_state;

	public List<OccupationSeasonInfo> select_occupations;

	public SocialHighLightsWithSocialBasicInfo social_high_lights_with_basic_info;

	public List<AbTestChoice> ab_test_choices;

	public List<ItemTagInfo> item_tag_info;

	public uint rank_sort;

	public uint cs_rank_sort;

	public uint hippo_rank;

	public uint hippo_ranking_points;

	public uint hippo_max_rank;

	public bool show_hippo_rank;

	public uint hippo_total_profit;

	public uint hippo_total_worth;

	public List<ModeStatsInfo> mode_stats_infos;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint cs_peak_tournament_rank_pos;

	public uint avatar_frame;

	public BlacklistRes blacklist;

	public WorkshopAccountSummaryInfo workshop_summary_info;

	public AccountBasicSparkInfo spark_info;

	public SocialBasicInfo social_basic_info;

	public uint photo_wall_ban_end_time;

	public bool show_emulator_flag;

	public bool is_homepage_punished;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
