using System.Collections.Generic;

namespace proto;

public class LevelProbability
{
	public ELottery.WeightType level;

	public List<RareProbability> rare_prs;

	public List<ItemProbability> item_prs;

	public List<AwardTypeProbability> award_type_pr;

	public uint round;
}
