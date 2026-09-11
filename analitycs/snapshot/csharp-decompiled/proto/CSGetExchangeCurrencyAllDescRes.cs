using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetExchangeCurrencyAllDescRes : IMessage
{
	public List<ExchangeCurrencyDesc> exchange_currency_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
