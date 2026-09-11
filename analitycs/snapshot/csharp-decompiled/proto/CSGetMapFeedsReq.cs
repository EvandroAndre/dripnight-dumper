using System.Collections.Generic;

namespace proto;

public class CSGetMapFeedsReq
{
	public string language;

	public uint map_pool_id;

	public uint genre_id;

	public List<string> index;
}
