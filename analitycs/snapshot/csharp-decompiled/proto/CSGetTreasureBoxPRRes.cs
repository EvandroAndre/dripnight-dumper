using System.Collections.Generic;

namespace proto;

public class CSGetTreasureBoxPRRes
{
	public List<RareProbability> rare_pr;

	public List<ItemProbability> item_pr;

	public List<AwardTypeProbability> award_type_pr;

	public ProbabilityType probability_type;
}
