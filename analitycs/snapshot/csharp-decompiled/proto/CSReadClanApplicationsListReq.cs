using System.Collections.Generic;

namespace proto;

public class CSReadClanApplicationsListReq
{
	public ulong clan_id;

	public List<ClanApplicationReadInfo> application_read_list;
}
