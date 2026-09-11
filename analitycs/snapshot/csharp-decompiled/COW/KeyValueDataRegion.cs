namespace COW;

public class KeyValueDataRegion : KeyValueData
{
	public string[] Region;

	public string Platform;

	public string UnityVersion;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public new void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
