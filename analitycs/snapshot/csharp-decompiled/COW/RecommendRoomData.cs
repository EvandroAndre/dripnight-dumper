using GCommon;

namespace COW;

public class RecommendRoomData : CSVBaseData
{
	public uint ID;

	public uint[] NewRoomType;

	public uint[] HotRoomType;

	public uint[] NewGameMode;

	public uint[] HotGameMode;

	public uint[] NewPreset;

	public uint[] HotPreset;

	public uint[] NewSettingID;

	public uint[] HotSettingID;

	public uint[] PrivilegeSettingID;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
