using GCommon;

namespace COW;

public class WeaponHistoryData : CSVBaseData
{
	public uint ID;

	public uint WeaponID;

	public string OB;

	public string Content;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
