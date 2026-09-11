using System.Collections.Generic;

namespace proto;

public class CSGetLotteryProbabilityRes
{
	public List<RareProbability> rare_pr;

	public List<LevelProbability> level_pr;

	public ProbabilityType probability_type;
}
