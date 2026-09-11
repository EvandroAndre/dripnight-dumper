using System.Collections.Generic;

namespace proto;

public class CSGetCustomCardFloorRewardRes
{
	public uint floor;

	public List<CustomCardInfo> cards;

	public ExchangeChangeData exchange_awards;
}
