using GCommon;

namespace COW;

public class OptionalDownloadDefaultIconShow : CSVBaseData
{
	public uint Type;

	public uint SubType;

	public uint CollectionType;

	public uint OtherType;

	public ResourceID Icon;

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
