using GCommon;

namespace COW;

public class LinkEquipSetData : CSVBaseData
{
	public uint Id;

	public EquipIdCountDataList EquipSet1;

	public EquipIdCountDataList EquipSet2;

	public EquipIdCountDataList EquipSet3;

	public EquipIdCountDataList EquipSet4;

	public EquipIdCountDataList EquipSet5;

	public EquipIdCountDataList EquipSet6;

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
