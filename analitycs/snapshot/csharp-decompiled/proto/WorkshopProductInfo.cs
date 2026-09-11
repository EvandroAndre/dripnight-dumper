namespace proto;

public class WorkshopProductInfo
{
	public string product_id;

	public string workshop_code;

	public string item_code;

	public EWorkshop.LimitedPurchaseType limited_purchase_type;

	public uint limited_purchase_times;

	public uint account_purchase_times;

	public EWorkshop.ProductStatus product_status;

	public string name;

	public string description;

	public string icon;

	public uint price;

	public long shelf_time;

	public long under_time;

	public long updated_at;

	public WorkshopProductLocalization localization;
}
