using GCommon;

namespace COW;

public class WebTutorialData : CsvDataIndexedReading
{
	public string Region;

	public string WebLink;

	public int Type;

	public int SubType;

	public int MatchType;

	public int ShowInNewVersion;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override string[] GetHeadColNames()
	{
		return null;
	}

	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
