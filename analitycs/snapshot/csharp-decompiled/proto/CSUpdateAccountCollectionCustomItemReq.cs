using System.Collections.Generic;

namespace proto;

public class CSUpdateAccountCollectionCustomItemReq
{
	public uint item_id;

	public string custom_info;

	public ulong group_id;

	public ulong room_id;

	public int source;

	public List<ItemCollectionCustomLog> custom_contents;

	public ulong shard_key;

	public uint game_mode;
}
