using ProtoBuf;

namespace proto;

public class MailSenderInfo : IMessage
{
	public ulong sender_id;

	public string sender_nick;

	public ulong clan_id;

	public string clan_name;

	public ulong clan_captain_id;

	public string clan_captain_nick;

	public uint season_id;

	public uint season_rank;

	public uint ep_unlock_id;

	public uint ep_challenge_id;

	public string gift_message;

	public MailGlobalDropInfo global_drop;

	public uint honor_delta;

	public uint subscription_ep_id;

	public ulong championship_team_id;

	public string championship_team_name;

	public uint championship_type;

	public uint championship_id;

	public uint championship_trial_pos;

	public string region;

	public string championship_name;

	public uint limitedevent_leaderboard_type;

	public uint limitedevent_rank;

	public uint rank_master_level;

	public uint recharge_time;

	public int recharge_points;

	public uint periodic_ranking_game_mode;

	public uint match_ban_expire_time;

	public DeliverRebateCardInfo deliver_info;

	public PVELeaderboardMailInfo pve_info;

	public uint creditscore_well_behavior_days;

	public string workshop_name;

	public string workshop_leaderboard_name;

	public uint workshop_leaderboard_rank;

	public ulong workshop_map_reward_id;

	public uint friend_intimacy_add;

	public string workshop_code;

	public ulong account_id;

	public string nick_name;

	public long credit_punish_duration;

	public uint credit_punish_type;

	public ulong credit_punish_sub_type;

	public long effective_start_time;

	public long effective_end_time;

	public uint summary_lv_before;

	public uint summary_lv_after;

	public GuildWarHackerPunishmentInfo guild_war_hacker_punishment;

	public EsportsMailInfo esports_mail_info;

	public string workshop_short_code;

	public uint ugc_token_amount;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
