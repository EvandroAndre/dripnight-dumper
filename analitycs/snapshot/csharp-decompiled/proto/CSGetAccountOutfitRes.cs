using System.Collections.Generic;

namespace proto;

public class CSGetAccountOutfitRes
{
	public uint[] show_selected_items;

	public AvatarProfile profile;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;
}
