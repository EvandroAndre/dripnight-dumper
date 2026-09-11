using GCommon;

namespace COW;

public class MapPatchDefData : CSVBaseData
{
	public StreamPrefabSource MapPatchType;

	public int MapPatchIndex;

	public string MapPatchAbName;

	public bool IsEnabled;

	public bool CanUsePVS;

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
