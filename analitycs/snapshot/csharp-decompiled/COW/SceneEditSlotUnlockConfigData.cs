using GCommon;
using proto;

namespace COW;

public class SceneEditSlotUnlockConfigData : CSVBaseData
{
	public uint SlotID;

	public uint CostItem;

	public EWorkshop.UnlockSlotCostType CostType;

	public uint CostCnt;

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
