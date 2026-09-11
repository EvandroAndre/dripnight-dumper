using ProtoBuf;

namespace proto;

public class LoadoutModePresetCorrelationDesc : IMessage
{
	public uint mode_id;

	public uint correlation_mode_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
