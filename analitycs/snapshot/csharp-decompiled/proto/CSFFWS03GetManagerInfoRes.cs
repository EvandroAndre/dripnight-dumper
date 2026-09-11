using System.Collections.Generic;

namespace proto;

public class CSFFWS03GetManagerInfoRes
{
	public List<FFWS03TeamCardsInfo> team_cards_info;

	public bool check_in_today;

	public string name;

	public uint match_score;

	public uint team_kills_count;

	public uint booyah_count;

	public uint trained_count_per_day;

	public uint match_count_per_day;

	public List<FFWS03ClaimedMilestoneInfo> claimed_milestone_info;

	public uint curr_match_count;
}
