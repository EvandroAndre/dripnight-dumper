using System.Collections.Generic;

namespace proto;

public class BigEventPassSettingDesc
{
	public uint event_id;

	public uint big_event_badge_id;

	public EInventory.AwardType badge_exchange_item_type;

	public uint badge_exchange_item_id;

	public uint badge_exchange_rate;

	public uint cost_gems;

	public uint show_gem_price;

	public uint show_discount;

	public List<BigEventEPAward> rewards;

	public string default_reward_cdn;

	public uint show_grand_reward;

	public string show_special_reward;

	public uint max_badge_exchange;

	public string show_ep_reward_cdn_url;

	public EInventory.AwardType big_event_badge_type;
}
