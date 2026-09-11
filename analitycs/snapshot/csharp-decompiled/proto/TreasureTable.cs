using GCommon;
using ProtoBuf;

namespace proto;

public class TreasureTable : IMessage
{
	public ResourceID Icon;

	public string region;

	public uint id;

	public uint item_id;

	public string name;

	public uint start_time;

	public uint end_time;

	public uint quantity;

	public uint daily_quantity;

	public bool is_festival_item;

	public EInventory.ItemSubType item_sub_type;

	public bool is_big_event_token;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
