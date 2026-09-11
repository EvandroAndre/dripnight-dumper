using ProtoBuf;

namespace proto;

public class Item : IMessage
{
	public uint id;

	public uint cnt;

	public uint expire_time;

	public int left_use_times;

	public uint history_owned_cnt;

	public uint left_expire_time;

	public EInventory.ItemStatus item_status;

	public EInventory.ItemType item_type;

	public EInventory.ItemSubType item_sub_type;

	public uint permanent_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
