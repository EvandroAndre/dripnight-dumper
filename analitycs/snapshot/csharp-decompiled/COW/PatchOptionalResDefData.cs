using GCommon;

namespace COW;

public class PatchOptionalResDefData : CSVBaseData
{
	public uint OptionalReDefId;

	public uint SortId;

	public ResDownloadType DownloadOptionalType;

	public string[] ab_PathList;

	public EDownloadFileType fileType;

	public ResourceID[] resIdList;

	public uint[] itemIdList;

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
