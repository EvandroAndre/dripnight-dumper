using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AvatarProfile : IMessage
{
	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public List<AvatarSkillSlot> equiped_skills;

	public bool is_selected;

	public uint pve_primary_weapon;

	public bool is_selected_awaken;

	public uint end_time;

	public EProfile.UnlockType unlock_type;

	public uint unlock_time;

	public bool is_marked_star;

	public uint[] clothes_tailor_effects;

	public List<ItemTagInfo> item_tag_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
