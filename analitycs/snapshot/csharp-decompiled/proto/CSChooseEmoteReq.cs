using System.Collections.Generic;

namespace proto;

public class CSChooseEmoteReq
{
	public ulong group_id;

	public ulong room_id;

	public List<ChoosedEmote> choosed_emotes;

	public ulong shard_key;

	public uint game_mode;
}
