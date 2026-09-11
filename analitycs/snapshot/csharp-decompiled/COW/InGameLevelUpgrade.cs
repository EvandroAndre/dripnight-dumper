namespace COW;

public class InGameLevelUpgrade
{
	public uint ID;

	public string HeadIcon;

	public string TailIcon;

	public byte Level;

	public byte EXP;

	public string DescKey;

	public string ShortDescKey;

	public uint ShowHudTips;

	public string TailColorStr;

	public static implicit operator InGameLevelUpgrade(BRIngameLevel data)
	{
		return null;
	}
}
