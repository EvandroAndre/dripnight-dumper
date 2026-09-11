using GCommon;

namespace COW;

public class LoadingConfigData : CSVBaseData
{
	public enum LodingType
	{
		FromLobbyToMatch = 1,
		ToLobby,
		FromWattingRoomToMatch
	}

	public int Id;

	public uint LoadingType;

	public int GameModeId;

	public int[] MapId;

	public int[] MatchMode;

	public int MinLevel;

	public int MaxLevel;

	public string[] CDNArray;

	public string[] TipsArray;

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
