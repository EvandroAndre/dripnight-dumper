using System;
using GCommon;

namespace COW;

public class PetOpenTimeData : CSVBaseData
{
	public uint PetID;

	public string Region;

	public string StringOpenTime;

	public DateTime OpenTime => default(DateTime);

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static string GenerateKey(uint petID, string region)
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
