using ProtoBuf;

namespace proto;

public class NewbieBundleDesc : IMessage
{
	public string region;

	public uint store_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
