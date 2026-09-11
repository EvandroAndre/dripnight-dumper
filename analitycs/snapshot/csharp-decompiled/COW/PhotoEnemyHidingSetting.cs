using GCommon;

namespace COW;

public class PhotoEnemyHidingSetting : CSVBaseData
{
	public uint GameMode;

	public uint MatchMode;

	public uint RoomType;

	public bool IsOpen;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
