using GCommon;

namespace COW;

public class UGCTimelineEditTracksConfig : CSVBaseData
{
	public string TrackName;

	public string TrackValue;

	public string[] ClipBindTypeName;

	public int[] SubTracks;

	public string ClipColor;

	public string[] BindTypeName;

	public string TrackIcon;

	public string TrackNameLocKey;

	public int KeyFrameType;

	public int TrackType;

	public int RelationType;

	public int TrackID;

	public bool IsShowInOption;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
