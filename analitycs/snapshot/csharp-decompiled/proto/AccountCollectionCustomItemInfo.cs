using ProtoBuf;

namespace proto;

public class AccountCollectionCustomItemInfo : IMessage
{
	public uint item_id;

	public string custom_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
