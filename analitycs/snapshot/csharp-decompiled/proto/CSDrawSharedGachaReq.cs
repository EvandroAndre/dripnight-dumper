namespace proto;

public class CSDrawSharedGachaReq
{
	public ulong shared_gacha_id;

	public uint chest_id;

	public uint chest_sub_id;

	public ELottery.ExchangeItemGroupType exchange_item_group;

	public uint money;

	public ELottery.CoinType coin_type;

	public int multi_index;

	public bool is_prime;

	public ELottery.LotteryType draw_type;

	public ESharedGacha.PurchaseType purchase_type;
}
