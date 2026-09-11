using GCommon;
using proto;

namespace COW;

public class RelationTypeInfoData : CSVBaseData
{
	public uint RelationType;

	public string RelationName;

	public ResourceID RelationBrokenBadgeIcon;

	public string RelationBgUrl;

	public string RelationLetterUrl;

	public uint RelationFriendMax;

	public uint RelationItem;

	public uint RejectCountDown;

	public uint RelationBreakUpCD;

	public uint RelationBreakUpCountDown;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void SetServerData(RelationTypeInfoDesc res)
	{
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
