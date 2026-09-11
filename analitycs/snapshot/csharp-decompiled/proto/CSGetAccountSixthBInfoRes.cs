using System.Collections.Generic;

namespace proto;

public class CSGetAccountSixthBInfoRes
{
	public ulong account_id;

	public bool is_distributor;

	public uint distributions;

	public List<AwardDesc> first_distribution_award;
}
