using GCommon;

namespace COW;

public class DeviceWhiteListSpecialData : CSVBaseData
{
	public enum InfoType
	{
		ApplySkin,
		EnableReduceRateSp,
		EnableMinResolutionHeightSp,
		EnableMinHeightSp,
		EnableUnmapWebViewVMSp
	}

	public uint id;

	public string strDeviceName;

	public uint applySkin;

	public bool enableReduceRateSp;

	public bool enableMinResolutionHeightSp;

	public bool enableMinHeightSp;

	public bool enableUnmapWebViewVMSp;

	public int iSortPriority;

	public DeviceWhiteListSpecialData()
	{
	}

	public DeviceWhiteListSpecialData(int mask, string[] infos)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private int GetStringCompDistance(string InBase, string InTarget)
	{
		return 0;
	}

	public bool SetupSortPriority(string InCurDeviceName)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
