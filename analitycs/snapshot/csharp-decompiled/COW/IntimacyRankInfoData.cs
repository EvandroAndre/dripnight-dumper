using GCommon;

namespace COW;

public class IntimacyRankInfoData : CSVBaseData
{
	public uint RelationType;

	public uint IntimacyRank;

	public uint LowerBound;

	public uint UpperBound;

	public ResourceID RelationBadgeIcon;

	public ResourceID ProfileIcon;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static string GeneratePrimaryKey(uint relationType, uint IntimacyRank)
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
