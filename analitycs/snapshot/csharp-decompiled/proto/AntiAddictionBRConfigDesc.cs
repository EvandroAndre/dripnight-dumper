using ProtoBuf;

namespace proto;

public class AntiAddictionBRConfigDesc : IMessage
{
	public string age;

	public uint age_index;

	public bool parent_control;

	public string content_key;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
