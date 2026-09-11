using System.Collections.Generic;

namespace proto;

public class CSLoginGetAccountInfoRes
{
	public bool championship_is_in_blacklist;

	public CSGetActivityDescRes activity_res;

	public CSGetAdvertRes advert_res;

	public RankingTipsABTestDesc ranking_tips_ab_test_desc;

	public List<GameplayFeedbackDesc> gameplay_feedback_descs;
}
