using ProtoBuf;

namespace proto;

public class CupNameOverwriteDesc : IMessage
{
	public uint cup_type;

	public uint cup_id;

	public uint name_type;

	public string language;

	public string content;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
