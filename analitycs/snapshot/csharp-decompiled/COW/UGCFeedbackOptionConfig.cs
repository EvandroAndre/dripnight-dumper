using GCommon;

namespace COW;

public class UGCFeedbackOptionConfig : CSVBaseData
{
	public string OptionType;

	public string Key;

	public uint OptionID;

	public uint Rank;

	public bool ShowModule;

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
