using System.Collections.Generic;

namespace proto;

public class CSCustomCardDrawRes
{
	public List<AwardDesc> award;

	public uint free_num;

	public List<CustomCardInfo> cards;

	public ExchangeChangeData exchange_awards;
}
