using GCommon;

namespace COW;

public class ItemHideCrossRegion : CSVBaseData
{
	public string LockRegion;

	public string LockRegion_Hide;

	public uint Gamemode;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
