using System.Collections.Generic;

namespace proto;

public class CSBatchDrawClanLuckyBagReq
{
	public ulong clan_id;

	public List<ClanLuckyBagInfo> bag_infos;
}
