namespace COW;

public class FastGroupInvite : FastMessage
{
	public enum EGameBuffIconType
	{
		None,
		SocialBuff,
		CallBackBuff
	}

	public ulong GroupID;

	public uint Group;

	public uint[] Map;

	public uint Game;

	public uint Match;

	public uint MemberNum;

	public uint RequireRankMin;

	public uint RequireRankMax;

	public uint CSSpecialModeEventId;

	public string GroupTag;

	public string SecretCode;

	public string RecruitCode;

	public EGameBuffIconType showGameBuf;

	public bool hasLuckyBuf;

	public bool hasMapBonus;
}
