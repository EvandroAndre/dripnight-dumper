using GCommon;

namespace COW;

public class TaskData : CSVBaseData, IGetId
{
	public uint Id;

	public string IconName;

	public string Name;

	public string Desc;

	public ResourceID Prefab;

	public bool CanDoForbid;

	public string CivilAlert;

	public string WolfAlert;

	public int TaskGroup;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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
