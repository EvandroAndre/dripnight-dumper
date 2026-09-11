using ProtoBuf;

namespace proto;

public class MatchmakingBlacklistParamDesc : IMessage
{
	public uint duration;

	public uint max_count;

	public bool is_open;

	public uint prime_additional_count;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
