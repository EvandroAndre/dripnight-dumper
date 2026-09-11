using COW;
using GCommon;

public class CollectionTabData : CSVBaseData
{
	public CSSharedItemDataManager.CollectionSubType TabID;

	public string TabName;

	public int Priority;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
