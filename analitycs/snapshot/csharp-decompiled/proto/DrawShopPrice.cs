using System.Collections.Generic;

namespace proto;

public class DrawShopPrice
{
	public EDrawShop.PurChaseType purchase_type;

	public uint gems;

	public List<ExchangeItemNum> items;

	public uint coins;
}
