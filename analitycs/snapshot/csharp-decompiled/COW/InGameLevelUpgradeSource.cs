namespace COW;

public class InGameLevelUpgradeSource
{
	public uint ID;

	public string Icon;

	public string Desc;

	public string DetailTitle;

	public string DetailDesc;

	public uint[] RewardNum;

	public static implicit operator InGameLevelUpgradeSource(BRIngameLevelSource data)
	{
		return null;
	}
}
