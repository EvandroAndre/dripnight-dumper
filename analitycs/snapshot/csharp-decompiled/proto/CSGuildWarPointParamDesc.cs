using ProtoBuf;

namespace proto;

public class CSGuildWarPointParamDesc : IMessage
{
	public uint id;

	public uint participation_limit;

	public uint win_param;

	public uint win_round_param;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
