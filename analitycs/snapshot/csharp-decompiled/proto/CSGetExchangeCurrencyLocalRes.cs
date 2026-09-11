using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetExchangeCurrencyLocalRes : IMessage
{
	public List<ExchangeCurrencyLocalDesc> exchange_currency_local_desc;

	public List<ExchangeCurrencyLocalUseDesc> exchange_currency_local_use_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
