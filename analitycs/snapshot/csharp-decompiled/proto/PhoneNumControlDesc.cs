using ProtoBuf;

namespace proto;

public class PhoneNumControlDesc : IMessage
{
	public uint id;

	public string area_code;

	public uint num_down;

	public uint num_up;

	public string country_code;

	public uint daily_limit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
