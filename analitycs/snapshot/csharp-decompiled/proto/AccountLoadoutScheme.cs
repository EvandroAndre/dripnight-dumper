using System.Collections.Generic;

namespace proto;

public class AccountLoadoutScheme
{
	public ulong account_id;

	public string nickname;

	public string region;

	public uint scheme_id;

	public string name;

	public string description;

	public List<AvatarSkillSlot> equiped_skills;

	public uint pet_skill;

	public uint loadout_id;

	public uint[] tags;

	public uint role;

	public uint game_mode;

	public uint like_count;

	public long update_time;

	public bool is_published;

	public LoadoutScheme.RecommendTag recommend_tag;
}
