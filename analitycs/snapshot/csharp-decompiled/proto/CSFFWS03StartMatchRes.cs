using System.Collections.Generic;

namespace proto;

public class CSFFWS03StartMatchRes
{
	public uint match_id;

	public uint rank;

	public uint score;

	public uint kills;

	public uint match_score;

	public uint team_kills_count;

	public uint booyah_count;

	public uint match_count_per_day;

	public List<FFWS03TeamCardsInfo> team_cards_info;

	public ExchangeChangeData rewards;

	public uint curr_match_count;
}
