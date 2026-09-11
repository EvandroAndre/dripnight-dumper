using System.Collections.Generic;

namespace proto;

public class CSBatchEquipSkillReq
{
	public uint avatar_id;

	public uint[] slot_ids;

	public uint[] skill_ids;

	public List<EProfile.EquipSource> equip_sources;

	public ulong group_id;

	public ulong room_id;
}
