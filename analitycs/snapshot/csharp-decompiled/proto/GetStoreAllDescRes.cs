using System.Collections.Generic;

namespace proto;

public class GetStoreAllDescRes
{
	public CSGetGiftStoreRes gift_store;

	public CSGetStoreTabRes store_tab;

	public CSGetIPTagConfigRes ip_tag_config;

	public CSGetExchangeCurrencyAllDescRes exchange_currency;

	public CSGetPayLevelConfigRes pay_level_config_res;

	public CSGetExchangeCurrencyLocalRes exchange_currency_local;

	public NewbieBundleDesc newbie_bundle_config;

	public CSGetIAPStoreDescRes iap_store_desc;

	public List<RebateCardDesc> rebate_card_descs;

	public GiftStoreCDNDesc gift_store_cdn_desc;
}
