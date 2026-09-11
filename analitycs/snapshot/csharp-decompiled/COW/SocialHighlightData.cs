using GCommon;

namespace COW;

public class SocialHighlightData : CSVBaseData
{
	public uint Id;

	public string Key;

	public ResourceID IconRes;

	public uint Priority;

	public uint BRPriority;

	public uint CSPriority;

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
