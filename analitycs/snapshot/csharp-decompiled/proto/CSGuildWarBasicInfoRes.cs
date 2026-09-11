using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGuildWarBasicInfoRes : IMessage
{
	public List<GuildWarOpenInfoDesc> guild_war_open_info;

	public List<GuildWarConditionConfigDesc> guild_war_cdt_config;

	public List<GuildWarTournamentDesc> guild_war_tournament;

	public AllGuildWarPointParamDesc all_guild_war_point_param;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
