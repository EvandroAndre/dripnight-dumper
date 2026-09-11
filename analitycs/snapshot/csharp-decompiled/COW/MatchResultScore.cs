using System;

namespace COW;

[Serializable]
internal class MatchResultScore
{
	public uint groupMode;

	public uint scorePerKill;

	public RankScore[] scoreByRank;
}
