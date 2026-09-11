using System.Collections.Generic;

namespace proto;

public class CSGetSharedCachaHistoryReq
{
	public ulong shared_gacha_id;

	public uint chest_id;

	public uint chest_sub_id;

	public bool only_owner;

	public List<ESharedGacha.RareType> rare_list;
}
