using System.Collections.Generic;

namespace proto;

public class CSChooseCollectionSkillSkinsReq
{
	public ulong group_id;

	public ulong room_id;

	public uint[] collection_skill_skins;

	public List<RandomSkinInfo> random_skill_skins;

	public ulong shard_key;

	public uint game_mode;
}
