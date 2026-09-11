using System.Collections.Generic;

namespace proto;

public class CSGetLimitedEventEPInfoRes
{
	public bool is_purchase_ep;

	public uint progress;

	public List<RewardStatus> rewards;

	public uint exchange_progress;
}
