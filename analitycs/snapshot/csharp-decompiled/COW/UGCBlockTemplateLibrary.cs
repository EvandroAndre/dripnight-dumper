using GCommon;

namespace COW;

public class UGCBlockTemplateLibrary : CSVBaseData
{
	public int Order;

	public ResourceID ImageRes;

	public ResourceID BlockTemplateRes;

	public int ID;

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
