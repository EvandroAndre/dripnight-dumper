using GCommon;

namespace COW;

public class CollectionPrivilegeTagData : CSVBaseData
{
	public uint ID;

	public uint Sort;

	public ResourceID PrivilegeIcon;

	public string PrivilegeDesc;

	public string PrivilegeTitle;

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
