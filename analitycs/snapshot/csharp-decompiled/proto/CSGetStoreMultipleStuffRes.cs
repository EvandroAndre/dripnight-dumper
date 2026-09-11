using ProtoBuf;

namespace proto;

public class CSGetStoreMultipleStuffRes : IMessage
{
	public CSGetStoreRes store_res;

	public CSGetGiftStoreRes gift_store_res;

	public CSGetGiftStoreDetailsRes gift_store_details_res;

	public CSGetExchangeStoreRes exchange_store_res;

	public CSGetDiscountStoreDescRes discount_store_desc_res;

	public CSGetVeteranStoreDescRes veteran_store_desc_res;

	public CSGetStarterStoreDescRes starter_store_desc_res;

	public CSGetPrimeStoreRes prime_store_res;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
