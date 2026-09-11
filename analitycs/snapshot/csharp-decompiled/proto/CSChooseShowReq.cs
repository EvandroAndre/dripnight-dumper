using System.Collections.Generic;

namespace proto;

public class CSChooseShowReq
{
	public uint[] shows;

	public ulong group_id;

	public ulong room_id;

	public List<RandomSkinInfo> random_shows;

	public ulong shard_key;

	public uint game_mode;
}
