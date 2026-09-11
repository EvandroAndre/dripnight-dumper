using GCommon;

namespace COW;

public class WorkshopDownloadData : CSVBaseData
{
	public string Region;

	public uint Switch;

	public uint Time;

	public uint ScreenTime;

	public uint Scale;

	public uint AutoDownload;

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
