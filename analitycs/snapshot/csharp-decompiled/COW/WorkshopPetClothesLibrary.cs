using GCommon;

namespace COW;

public class WorkshopPetClothesLibrary : CSVBaseData
{
	public string ResourceLevel;

	public uint Type;

	public uint ItemID;

	public bool IsObsolote;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
