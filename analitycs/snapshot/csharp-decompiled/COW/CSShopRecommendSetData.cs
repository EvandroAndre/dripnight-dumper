using System.Collections.Generic;
using GCommon;

namespace COW;

public class CSShopRecommendSetData : CSVBaseData
{
	public class PriceRange
	{
		public int Min;

		public int Max;
	}

	public uint ItemID;

	public bool HasMainWeapon;

	public int Weight;

	public string EsScale;

	public List<PriceRange> Prices;

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
