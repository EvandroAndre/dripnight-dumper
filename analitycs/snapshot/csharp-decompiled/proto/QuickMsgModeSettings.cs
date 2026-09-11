using ProtoBuf;

namespace proto;

public class QuickMsgModeSettings : IMessage
{
	public uint mode;

	public uint[] list;

	public uint[] roulette;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
