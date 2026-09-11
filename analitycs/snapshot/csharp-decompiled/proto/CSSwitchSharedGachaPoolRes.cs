using System.Collections.Generic;

namespace proto;

public class CSSwitchSharedGachaPoolRes
{
	public SharedGachaAccountInfo account_info;

	public SharedGachaPoolInfo pool_info;

	public List<SharedGachaHistoryInfo> new_historys;

	public ulong[] account_ids;
}
