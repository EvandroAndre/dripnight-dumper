using GCommon;

namespace COW;

public class PresetPickData : CSVBaseData
{
	public uint MatchMode;

	public uint RankPoint;

	public uint GameMode;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
