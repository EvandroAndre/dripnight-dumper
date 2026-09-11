using GCommon;

namespace COW;

public class AgeVerifiedData : CsvDataIndexedReading
{
	public string Country;

	public uint Platform;

	public uint Age;

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
