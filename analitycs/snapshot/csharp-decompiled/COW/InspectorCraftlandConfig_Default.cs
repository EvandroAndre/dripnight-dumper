using GCommon;

namespace COW;

public class InspectorCraftlandConfig_Default : CSVBaseData
{
	public string Name;

	public string NameKey;

	public string InGroup;

	public string[] AddableComponents;

	public string PropName;

	public string Comment;

	public string Tip;

	public string TipsKey;

	public string Content;

	public string PropConfigID;

	public int GroupOrder;

	public int OptionID;

	public ResourceID DefaultValue;

	public int PageID;

	public int PropertyID;

	public int EntryOrder;

	public int CanBeRecorded;

	public int State;

	public bool CanConfigureCustomProperty;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
