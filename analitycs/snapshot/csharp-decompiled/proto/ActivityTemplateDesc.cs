using ProtoBuf;

namespace proto;

public class ActivityTemplateDesc : IMessage
{
	public uint group_id;

	public string config_key;

	public string language;

	public string param1;

	public string param2;

	public string param3;

	public string param4;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
