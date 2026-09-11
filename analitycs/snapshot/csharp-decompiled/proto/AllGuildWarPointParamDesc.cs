using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AllGuildWarPointParamDesc : IMessage
{
	public List<GuildWarPointParamDesc> guild_war_point_param;

	public CSGuildWarPointParamDesc cs_guild_war_point_param;

	public List<GuildWarPointParamDesc> guild_war_tournament_point_param;

	public CSGuildWarPointParamDesc cs_guild_war_tournament_point_param;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
