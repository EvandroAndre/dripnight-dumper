using System;
using GCommon;

namespace COW;

public class LinkEquipSetTimeData : CSVBaseData
{
	public uint[] Builds;

	public uint Id;

	public string StringStartTime;

	public string StringEndTime;

	public uint Build1;

	public uint Build2;

	public uint Build3;

	public uint Build4;

	public DateTime StartTime => default(DateTime);

	public DateTime EndTime => default(DateTime);

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void PostDeserializeData()
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
