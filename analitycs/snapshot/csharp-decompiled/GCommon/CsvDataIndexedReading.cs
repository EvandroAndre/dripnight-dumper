namespace GCommon;

public abstract class CsvDataIndexedReading : CSVBaseData
{
	public override bool UsingIndexedParseData => false;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string[] GetHeadColNames()
	{
		return null;
	}

	public override void ParseData(IIndexString ss, int[] index)
	{
	}
}
