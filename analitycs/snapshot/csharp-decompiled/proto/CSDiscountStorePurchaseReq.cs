namespace proto;

public class CSDiscountStorePurchaseReq
{
	public uint store_id;

	public uint item_id;

	public uint cnt;

	public EInventory.CurrencyType currency_type;

	public uint price;

	public uint voucher_id;
}
