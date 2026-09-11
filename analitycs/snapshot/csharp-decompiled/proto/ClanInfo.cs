using System.Collections.Generic;

namespace proto;

public class ClanInfo
{
	public ulong clan_id;

	public string clan_name;

	public ulong create_at;

	public ulong captain_id;

	public uint clan_level;

	public uint capacity;

	public uint member_num;

	public uint entry_level;

	public uint entry_type;

	public string clan_logo;

	public string announcement;

	public string slogan;

	public string region;

	public string misc;

	public string vice_captains;

	public uint honor_point;

	public uint race_point;

	public ulong last_gain_rp_at;

	public ulong claim_rp_award_at;

	public uint area_id;

	public uint play_style;

	public uint entry_rank;

	public ulong deputy_captain;

	public uint clan_arms;

	public uint clan_badge_id;

	public List<UnlockedClanBadgeInfo> unlocked_clan_badge_infos;

	public uint entry_cs_rank;

	public uint total_activeness;

	public uint weekly_activeness;

	public uint pre_clan_level;

	public uint week_id;

	public long last_buy_promo_time;

	public uint frame_id;

	public string custom_badge;

	public bool use_custom_badge;

	public long last_modify_announce_at;

	public uint serial_inactive_num;

	public bool is_certification;

	public GuildWarTitleInfo best_title;

	public uint history_badge_id;

	public GuildWeeklyInfo guild_weekly_info;

	public long privilege_expire_at;

	public bool privilege_claimed;

	public GuildWarTitleInfo equipped_title;

	public bool guild_war_banned;

	public bool guild_tournament_banned;

	public GuildWarHackerPunishmentInfo guild_war_hacker_punishment;
}
