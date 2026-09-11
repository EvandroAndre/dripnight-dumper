using ProtoBuf;

namespace proto;

public class profileModuleSwitchDesc : IMessage
{
	public uint id;

	public bool is_display;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
