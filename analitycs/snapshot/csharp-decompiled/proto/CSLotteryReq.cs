namespace proto;

public class CSLotteryReq
{
	public uint chest_id;

	public uint gacha_type;

	public uint chest_sub_id;

	public ELottery.ConsumeType consume_type;

	public uint finite_jackpot;

	public uint finite_lottery_count;

	public uint show_type;

	public bool is_lucky_spin;

	public uint mixed_item;

	public ELottery.ExchangeItemGroupType exchange_item_group;

	public uint money;

	public ELottery.CoinType coin_type;

	public int multi_index;
}
