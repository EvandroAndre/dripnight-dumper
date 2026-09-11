using ProtoBuf;

namespace proto;

public class AntiHackCenterDesc : IMessage
{
	public uint id;

	public string region;

	public string link;

	public string ban_list_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
