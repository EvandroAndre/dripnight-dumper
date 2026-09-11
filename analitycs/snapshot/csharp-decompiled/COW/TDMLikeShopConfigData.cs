using System.Collections.Generic;
using GCommon;

namespace COW;

internal class TDMLikeShopConfigData : CSVBaseData
{
	public uint indexID;

	public List<TDMLikeShopItem> items;

	public uint mainItemId;

	public uint price;

	public uint filter;

	public bool displayFirstOne;

	public uint limitation;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
