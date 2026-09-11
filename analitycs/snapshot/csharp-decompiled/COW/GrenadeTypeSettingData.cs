using GCommon;

namespace COW;

public class GrenadeTypeSettingData : CSVBaseData
{
	public uint ID;

	public uint ItemID;

	public int ItemIDIndex;

	public uint[] ItemIDs;

	public int Type;

	public string WheelIcon;

	public string[] WheelIcons;

	public uint Priority;

	public uint[] Prioritys;

	public int SingleSlotPosBR;

	public int DoubleSlotPosBR;

	public int SingleSlotPosCS;

	public int DoubleSlotPosCS;

	public int[] SingleSlotPosBRs;

	public int[] DoubleSlotPosBRs;

	public int[] SingleSlotPosCSs;

	public int[] DoubleSlotPosCSs;

	public uint ShowInWheel1;

	public uint ShowInWheel2;

	public EGameModeCategory GameModeCategory;

	public uint GameMode;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public GrenadeTypeSettingData CloneData(int index)
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
