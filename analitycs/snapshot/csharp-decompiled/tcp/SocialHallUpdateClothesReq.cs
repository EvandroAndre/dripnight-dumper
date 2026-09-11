using System.Collections.Generic;

namespace tcp;

public class SocialHallUpdateClothesReq
{
	public uint[] clothes;

	public uint[] clothes_tailor_effects;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;
}
