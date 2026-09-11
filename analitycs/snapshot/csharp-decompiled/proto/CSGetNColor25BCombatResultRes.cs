using System.Collections.Generic;

namespace proto;

public class CSGetNColor25BCombatResultRes
{
	public enum RatingType
	{
		NONE,
		SSScore,
		SScore,
		AScore,
		BScore
	}

	public uint[] defeat_rate;

	public long[] defeat_time;

	public List<RatingType> type;

	public uint[] defeat_challenge_time;
}
