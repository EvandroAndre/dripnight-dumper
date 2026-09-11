using GCommon;
using message;

namespace COW;

public class PeakRankData : CSVBaseData
{
	public int MinRequestRank;

	public DLBMPCCFKKM RankType;

	public int RankMasterLevel;

	public string RankName;

	public ResourceID SmallIconRes;

	public ResourceID BigIconRes;

	public ResourceID LobbyIconRes;

	public ResourceID LadderSeasonRes;

	public ResourceID LadderIconUIFXRes;

	public ResourceID FullScreenRankUpRes;

	public string FullScreenRankUpClipName;

	public ResourceID FullScreenRankUpRes68;

	public string FullScreenRankUpClipName68;

	public ResourceID GrandMasterRankLabelBGRes;

	public float RankIconScale;

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
