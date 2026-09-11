namespace proto;

public class CSPurchaseReq
{
	public uint store_item_id;

	public ulong trans_id;

	public uint cnt;

	public uint currency_type;

	public uint price;

	public uint voucher_id;

	public EInventory.StorePromotionType promotion_type;

	public bool is_offer;

	public ulong room_id;

	public bool is_quick_purchase;

	public ulong group_id;

	public bool by_system;

	public bool workshop_vip_subs_enable;

	public EWorkshop.VIPType subscribe_vip_type;

	public ulong match_id;

	public string workshop_code;
}
