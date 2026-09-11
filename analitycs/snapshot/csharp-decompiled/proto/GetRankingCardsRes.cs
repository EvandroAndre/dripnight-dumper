using System.Collections.Generic;

namespace proto;

public class GetRankingCardsRes
{
	public List<Item> owned_rank_cards;

	public List<RankingCardDesc> ranking_card_desc;
}
