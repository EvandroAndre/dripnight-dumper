using System.Collections.Generic;
using proto;

namespace COW;

public class GachaSpDescData
{
	public uint ForgeTabId;

	public List<ChestSpecialExchangeDesc> GachaSpDescList;

	public List<uint> GachaExchangeList;

	public GachaSpDescData(uint gachaID)
	{
	}

	public void AddSpDesc(ChestSpecialExchangeDesc exchangeDesc)
	{
	}
}
