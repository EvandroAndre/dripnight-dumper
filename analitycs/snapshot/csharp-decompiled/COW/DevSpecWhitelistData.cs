using COW.GamePlay;
using GCommon;

namespace COW;

public class DevSpecWhitelistData : CSVBaseData
{
	public enum FramerateType
	{
		F_30 = 0,
		F_60 = 1,
		F_90 = 2,
		F_120 = 4,
		F_144 = 8
	}

	public enum InfoType
	{
		RAM,
		Quality,
		Graphic,
		ShowHighFramerateUI,
		EnableHighFrameDefault,
		EnableRTShadow,
		EnableHDMemory,
		OSVersion,
		UnloadTime,
		UnloadMemory,
		MapDesertQuality,
		ResolutionReduceRateBlitType,
		UnloadEmbeddedSO,
		IsBountyForceUseLowResource
	}

	private class AfterParseDataContext
	{
		public uint hdMem;
	}

	public int id;

	public string strDeviceName;

	public string strOS;

	public string strCPU;

	public string strGPU;

	public uint[] uRAMRange;

	public MNMBLBKENMK eQualityLevel;

	public ALBFCNLDNBL eGraphicLevel;

	public ALBFCNLDNBL eMapDesertGraphicLevel;

	public bool bShowHighFramerateUI;

	public int iHighFramerateDefault;

	public bool bEnableRTShadow;

	public bool bEnableHDGraphics;

	public int iUnloadTime;

	public int iUnloadMemory;

	public bool bLowMemeoryIOS;

	public int iSortPriority;

	public float resolutionReduceRate;

	public bool bIsBlitTypeAlways;

	public bool IsBountyForceUseLowResource;

	public bool bUnloadEmbeddedSceneObjects;

	private AfterParseDataContext context;

	public DevSpecWhitelistData()
	{
	}

	public DevSpecWhitelistData(int mask, string[] infos)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static void SplitResolutionReduceRateAndBlitType(string str, ref float reduceRate, ref bool isBlitTypeAlways)
	{
	}

	private int GetStringCompDistance(string InBase, string InTarget)
	{
		return 0;
	}

	public bool SetupSortPriority(string InCurDeviceName, string InCurCPU, string InCurGPU, int InCurSysMemSize)
	{
		return false;
	}

	private void SetupSortPriorityForItems(string InCurCPU, string InCurGPU, int InCurSysMemSize)
	{
	}

	private bool SpecialStringCheck(string strGPU, string InCurGPU)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
