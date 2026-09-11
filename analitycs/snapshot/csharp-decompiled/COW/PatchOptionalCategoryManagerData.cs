using GCommon;

namespace COW;

public class PatchOptionalCategoryManagerData : CSVBaseData
{
	public uint OptionalReDefId;

	public uint Type;

	public uint SortId;

	public OptionalDownloadClientType ClientType;

	public uint ModelType;

	public string OptionalResTitle;

	public string OptionalResTips;

	public string OptionalResCDN;

	public string OptionalResIcon;

	public RecommendLevel Tag;

	public string HotOptionalResCDN;

	public string OptionalResTipsDetail;

	public string[] OptionalResTipsContent;

	public bool HaveDetailsShow;

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
