using GCommon;

namespace COW;

public class MusicTransitionRule : CSVBaseData
{
	public string SourceCategory;

	public string ExitPosition;

	public string EnterPosition;

	public string TargetCategory;

	public float FadeInTime;

	public float FadeOutTime;

	public ResourceID Segment;

	public uint ID;

	public ResourceID TargetMusicID;

	public ResourceID SourceMusicID;

	public float ExitOffset;

	public float EnterOffset;

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
