using COW.GamePlay;
using GCommon;

namespace COW;

public class HDQualityDevSpecWhitelistData : CSVBaseData
{
	public int id;

	public string strDeviceName;

	public string strCPU;

	public string strGPU;

	public uint[] uRAMRange;

	public int processorSize;

	public bool bUseHDWeaponEffect;

	public bool bUseHDAudio;

	public bool bUseHDAnimation;

	public bool bUseHDLogin;

	public bool bUseHDLobby;

	public bool bUseHDTexture;

	public ALBFCNLDNBL graphicsQuality;

	public int[] mapNeoParadiseMaxConfig;

	public int iSortPriority;

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

	public bool SetupSortPriority(string InCurDeviceName, string InCurCPU, string InCurGPU, int InCurSysMemSize, int InCurProcessorSize)
	{
		return false;
	}

	private void SetupSortPriorityForItems(string InCurCPU, string InCurGPU, int InCurSysMemSize, int InCurProcessorSize)
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
