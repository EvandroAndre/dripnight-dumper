using ProtoBuf;

namespace proto;

public class UniversalLinkSettingDesc : IMessage
{
	public string universal_link;

	public string deep_link;

	public uint start_time;

	public uint end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
