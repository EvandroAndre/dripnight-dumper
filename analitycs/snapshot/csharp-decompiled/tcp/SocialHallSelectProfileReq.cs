using System.Collections.Generic;

namespace tcp;

public class SocialHallSelectProfileReq
{
	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public uint[] skills;

	public bool is_trial_avatar;

	public uint[] clothes_tailor_effects;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;
}
