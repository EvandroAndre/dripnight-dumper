using System.Collections.Generic;

namespace proto;

public class CSPurchaseLimitedChestRes
{
	public List<ExchangedAward> chest_goods;

	public bool has_big_reward;

	public uint prize_id;

	public bool is_lucky_spin;

	public uint drawn_cnt;
}
