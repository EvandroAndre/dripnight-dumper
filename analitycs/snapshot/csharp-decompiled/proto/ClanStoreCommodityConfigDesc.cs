using ProtoBuf;

namespace proto;

public class ClanStoreCommodityConfigDesc : IMessage
{
	public uint store_id;

	public uint commodity_id;

	public uint clan_level;

	public uint limited_purchase_times;

	public uint commodity_group;

	public uint commodity_group_sort;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
