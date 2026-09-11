using System.Collections.Generic;

namespace tcp;

public class GuildWarHackerPunishNtf
{
	public ulong clan_id;

	public ulong[] hacker_account_ids;

	public List<string> hacker_nicknames;

	public uint rule_hacker_cnt;

	public uint guild_war_score_reduce_rate;

	public bool guild_war_banned;

	public long punish_until;

	public bool tournament_banned;
}
