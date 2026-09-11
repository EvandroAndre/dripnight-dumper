using GCommon;

namespace COW;

public class WorkshopReportConfig : CSVBaseData, IGetId
{
	public uint ID;

	public uint Rank;

	public uint ReportCategory;

	public string ReportTransifyKey;

	public uint ReportLogParameter;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
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
