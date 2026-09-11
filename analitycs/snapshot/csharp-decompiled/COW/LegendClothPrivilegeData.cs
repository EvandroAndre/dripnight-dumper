using GCommon;

namespace COW;

public class LegendClothPrivilegeData : CSVBaseData, IGetId
{
	public uint Id;

	public uint SortId;

	public ResourceID Icon;

	public string PrivilegeName;

	public string PrivilegeDesc;

	public uint Gopos;

	public string SubGopos;

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
