namespace COW;

public class LeaderBoardIDV2
{
	public enum EBoardType
	{
		None,
		GuildWarIndividual,
		GuildWarGuild,
		GuildActive,
		GuildWarChampionship,
		HCRank,
		HCWorth,
		HCProfit,
		LimitedTimeRank,
		PrimeMonthly,
		PrimeYearly,
		PrimeTotally
	}

	public enum EParam1Type
	{
		None,
		Friend,
		Region
	}

	public enum EParam2Type
	{
		None,
		Ladder
	}

	public uint ID;

	public EBoardType BoardType => EBoardType.None;

	public uint Param1 => 0u;

	public uint Param2 => 0u;

	public uint Param3 => 0u;

	public LeaderBoardIDV2(uint id)
	{
	}

	public LeaderBoardIDV2(EBoardType type, uint param1 = 0u, uint param2 = 0u, uint param3 = 0u)
	{
	}

	public static EBoardType GetBoardTypeFromID(uint id)
	{
		return EBoardType.None;
	}

	public static uint GetParam1FromID(uint id)
	{
		return 0u;
	}

	public static uint GetParam2FromID(uint id)
	{
		return 0u;
	}

	public static uint GetParam3FromID(uint id)
	{
		return 0u;
	}
}
