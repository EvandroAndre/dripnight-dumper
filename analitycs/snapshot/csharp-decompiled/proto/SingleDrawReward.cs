using System.Collections.Generic;

namespace proto;

public class SingleDrawReward
{
	public uint draw_counter;

	public List<ExchangedAward> lottery_goods;

	public List<ExchangedAward> reward_goods;

	public string err_msg;
}
