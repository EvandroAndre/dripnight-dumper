using GCommon;

namespace COW;

public class WorkshopClothesData : CSVBaseData
{
	public uint ItemID;

	public string NameKey;

	public int Sort;

	public int Type;

	public string TypeNameKey;

	public int SubType;

	public bool IsObsolote;

	public string ResourceLevel;

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
