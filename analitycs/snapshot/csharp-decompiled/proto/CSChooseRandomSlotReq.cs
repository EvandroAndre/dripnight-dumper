using System.Collections.Generic;

namespace proto;

public class CSChooseRandomSlotReq
{
	public List<RandomSlotInfo> random_slots;

	public ulong group_id;

	public ulong room_id;

	public ulong shard_key;

	public uint game_mode;
}
