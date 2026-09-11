using ProtoBuf;

namespace proto;

public class GuildWarPointParamDesc : IMessage
{
	public uint rank;

	public uint rank_param;

	public uint kill_param;

	public uint id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
