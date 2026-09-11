using System.Collections.Generic;
using proto;

namespace COW;

public class IchisOverviewTierData
{
	public ESharedGacha.RareType tierType;

	public int remaining;

	public int total;

	public List<IchisOverviewAwardData> rewards;
}
