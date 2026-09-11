using ProtoBuf;

namespace proto;

public class GuildWarConditionConfigDesc : IMessage
{
	public uint guild_scale;

	public uint personal_condition;

	public uint guild_condition;

	public uint season_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
