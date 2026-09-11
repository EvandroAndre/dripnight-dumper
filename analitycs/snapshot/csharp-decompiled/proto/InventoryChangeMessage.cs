using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class InventoryChangeMessage : IMessage
{
	public List<Item> items;

	public List<InventoryItemExceedMaxNum> exceed_max_items;

	public List<ItemTagInfo> item_tag_infos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
