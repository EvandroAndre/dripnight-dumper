using ProtoBuf;

namespace proto;

public class CustomEventTemplateDesc : IMessage
{
	public uint custom_event_id;

	public string config_key;

	public string param1;

	public string param2;

	public string param3;

	public string param4;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
