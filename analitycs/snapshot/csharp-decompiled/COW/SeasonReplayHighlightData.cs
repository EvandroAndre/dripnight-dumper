using GCommon;
using proto;

namespace COW;

public class SeasonReplayHighlightData : CSVBaseData
{
	public ERanking.SeasonReplayEventType Type;

	public ResourceID CompleteIcon;

	public string Key;

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
