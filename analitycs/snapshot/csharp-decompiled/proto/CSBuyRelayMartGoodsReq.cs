namespace proto;

public class CSBuyRelayMartGoodsReq
{
	public uint relay_mart_id;

	public uint[] goods_list;

	public string discount_code;

	public bool use_backup_code;

	public uint discount_code_from;
}
