using GCommon;

namespace COW;

public class LanguageNumberData : CSVBaseData
{
	public string Language;

	public string Thousand;

	public string TenThousand;

	public string Million;

	public string TenMillion;

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
