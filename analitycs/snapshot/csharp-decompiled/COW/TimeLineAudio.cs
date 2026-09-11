using GCommon;

namespace COW;

public class TimeLineAudio : CSVBaseData
{
	public string TimeLinePrefabName;

	public string AudioID;

	public uint InBure;

	public uint AudioBus;

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
