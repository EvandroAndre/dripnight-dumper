using GCommon;

namespace COW;

public class HudTag : CSVBaseData
{
	public string TagString;

	public string TagIcon;

	public int IsFilter;

	public uint TagId;

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
