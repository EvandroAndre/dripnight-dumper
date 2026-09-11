using System.Collections.Generic;

namespace proto;

public class CSChangeWishListItemReq
{
	public uint[] add_item_ids;

	public uint[] del_item_ids;

	public List<string> add_source;

	public List<string> del_source;
}
