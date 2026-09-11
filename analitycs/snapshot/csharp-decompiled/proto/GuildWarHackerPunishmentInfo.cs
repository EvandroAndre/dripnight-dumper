using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GuildWarHackerPunishmentInfo : IMessage
{
	public ulong[] hacker_account_ids;

	public List<string> hacker_nicknames;

	public uint rule_hacker_cnt;

	public uint guild_war_score_reduce_rate;

	public bool guild_war_banned;

	public long punish_until;

	public bool tournament_banned;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
