namespace proto;

public class SubscribeStoreDesc
{
	public uint store_id;

	public uint sort_id;

	public long added_time;

	public long expire_time;

	public ESubscription.SubscribeType subscribe_type;

	public uint item_id;

	public string item_name;

	public uint price_item_id;

	public uint price_rebate_id;

	public float price;

	public ESubscription.PriceType price_type;

	public ESubscription.TagType tag_type;

	public string icon_url;

	public string preview_url;

	public uint subscribe_bonus;

	public string language;

	public string real_icon_url;

	public string real_preview_url;

	public float intro_price;

	public uint intro_time;

	public uint ep_value_gems;

	public uint ep_award_id1;

	public uint ep_award_id2;

	public uint ep_award_id3;

	public uint ep_award_id4;

	public uint ep_award_id5;

	public uint ep_award_id6;

	public bool is_half_open;
}
