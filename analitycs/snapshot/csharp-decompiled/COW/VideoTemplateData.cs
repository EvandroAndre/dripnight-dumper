using GCommon;

namespace COW;

public class VideoTemplateData : CSVBaseData
{
	public string Name;

	public string CDN;

	public int SortID;

	public uint Duration;

	public ResourceID Resource;

	public uint ID;

	public bool IsVertical;

	public bool IsMultiCamera;

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
