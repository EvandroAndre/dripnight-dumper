using ProtoBuf;

namespace proto;

public class AccountNewsContent : IMessage
{
	public uint[] item_ids;

	public uint rank;

	public uint match_mode;

	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public uint treasurebox_id;

	public uint commodity_id;

	public uint store_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
