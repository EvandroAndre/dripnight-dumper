using System.Collections.Generic;

namespace proto;

public class CSDrawShopGetLimitedPoolProbabilityRes
{
	public ProbabilityType probability_type;

	public List<DrawShopLimitedPoolGoodsProbability> probabilities;
}
