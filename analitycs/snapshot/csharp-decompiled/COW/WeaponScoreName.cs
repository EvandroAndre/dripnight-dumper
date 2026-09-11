using System;
using GCommon;

namespace COW;

public class WeaponScoreName : CSVBaseData, IComparable<WeaponScoreName>
{
	public string scoreName;

	public string scoreName2;

	public uint sort;

	public uint scoreId;

	public string description;

	public int CompareTo(WeaponScoreName other)
	{
		return 0;
	}

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
