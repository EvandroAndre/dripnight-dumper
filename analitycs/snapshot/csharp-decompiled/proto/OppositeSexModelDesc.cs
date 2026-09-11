using ProtoBuf;

namespace proto;

public class OppositeSexModelDesc : IMessage
{
	public uint male_model_id;

	public uint female_model_id;

	public uint start_timestamp;

	public uint end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
