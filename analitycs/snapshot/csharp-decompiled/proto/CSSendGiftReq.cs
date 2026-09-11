namespace proto;

public class CSSendGiftReq
{
	public ulong[] receiver_account_ids;

	public EGiftStore_BuddyType buddy_type;

	public uint commodity_id;

	public string message_content;

	public EInventory.CurrencyType currency_type;

	public ulong clan_id;

	public uint commodity_cnt;

	public uint voucher_id;

	public uint source;

	public uint friend_intimacy_add;

	public uint unit_price;

	public bool is_wishlist;

	public bool has_wishlist;

	public uint cur_intimacy;
}
