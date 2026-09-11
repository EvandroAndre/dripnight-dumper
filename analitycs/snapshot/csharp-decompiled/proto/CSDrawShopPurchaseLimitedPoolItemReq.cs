namespace proto;

public class CSDrawShopPurchaseLimitedPoolItemReq
{
	public uint draw_shop_id;

	public uint selected_pool_item_id;

	public EDrawShop.LimitedPoolOperationType operation_type;

	public DrawShopLimitedPoolPrice price;
}
