using System.Collections.Generic;
using GCommon;
using proto;

public class ExchangeCurrencyDataManager : SingletonModule<ExchangeCurrencyDataManager>
{
	public enum EExchangeCurrencyType
	{
		NONE,
		ACTIVITYEXCHANGE,
		MALLEXCHANGE,
		WEBSITE
	}

	public enum EExchangeCurrencySubType
	{
		NONE = 0,
		Rank = 5,
		Crystal = 6,
		Clan = 16
	}

	private Dictionary<uint, uint> m_ExchangeCurrencyDict;

	protected override void OnInit()
	{
	}

	public void ProcessData(CSGetExchangeCurrencyAllDescRes res)
	{
	}

	protected override void OnCleanup()
	{
	}

	public uint GetExchangeCurrencySubType(uint id)
	{
		return 0u;
	}

	public bool HasExchangeCurrency(uint id)
	{
		return false;
	}
}
