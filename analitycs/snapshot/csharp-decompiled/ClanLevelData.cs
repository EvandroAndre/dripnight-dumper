using GCommon;

public class ClanLevelData : CSVBaseData
{
	public int Level;

	public int MinHonor;

	public int ExpBuffFactor;

	public int GoldBuffFactor;

	public int SizeImproved;

	public int GoldLimitImproved;

	public int AwardType1;

	public int AwardId1;

	public int AwardNum1;

	public int AwardMaxNum1;

	public int AwardType2;

	public int AwardId2;

	public int AwardNum2;

	public int AwardMaxNum2;

	public int MinClanActiveness;

	public int MaxClanActiveness;

	public int RepairClanActiveness;

	public int MaxLevelProgressShowActiveness;

	public string LevelIcon;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
