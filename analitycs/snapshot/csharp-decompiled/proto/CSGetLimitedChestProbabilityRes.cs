using System.Collections.Generic;

namespace proto;

public class CSGetLimitedChestProbabilityRes
{
	public List<RareProbability> rare_pr;

	public List<LevelProbability> level_pr;

	public ProbabilityType probability_type;

	public List<AwardTypeProbability> award_type_pr;
}
