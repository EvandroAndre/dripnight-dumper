using System.Collections.Generic;
using GCommon;

namespace COW;

public class CureGearSettingData : CSVBaseData
{
	public uint EnumID;

	public uint ItemID;

	public uint ShowInWheel;

	public uint WheelPriority;

	public EGameModeCategory GameModeCategory;

	public uint[] GameMode;

	public uint[] GameModeExclude;

	public string WheelIcon;

	public uint MoveStatus;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static int CureGearComparison(CureGearSettingData t1, CureGearSettingData t2)
	{
		return 0;
	}

	public static List<CureGearSettingData> GetDefaultCureGearList(EGameModeCategory modeCategory, uint gameMode)
	{
		return null;
	}

	public static List<CureGearSettingData> GetEnumSortList(uint gameMode)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
