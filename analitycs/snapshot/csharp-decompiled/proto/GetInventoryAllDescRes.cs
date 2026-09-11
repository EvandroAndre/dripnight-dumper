using System.Collections.Generic;

namespace proto;

public class GetInventoryAllDescRes
{
	public CSGetBundleRes bundle;

	public GetRankingItemRankConfigRes ranking_item_rank_config;

	public CSGetFullscreenItemRes full_screen_item;

	public CSGetRoleDebrisDescRes role_debris;

	public long weapon_skin_system_time;

	public CSGetOptionalBundleRes optional_bundle;

	public CSSkinTimelineDescRes skin_timeline;

	public CSGetPreviewWebDescRes preview_web;

	public List<BonusCardDesc> bonus_cards;

	public CSGetWeaponPermanentRes weapon_permanent;

	public List<RankingCardDesc> ranking_card_descs;

	public List<CSRankingCardDesc> cs_ranking_card_descs;

	public List<ItemNumLimitDesc> item_num_limit_descs;

	public List<PrivilegeConfigDesc> privilege_config;

	public List<RandomSkinSwitchDesc> random_skin_switches;

	public uint coins_limit_out_game_weekly;

	public List<InGameQuickChatItemDesc> in_game_quick_chat_items;

	public InventorySwitchDesc inventory_switch_desc;

	public WishSettingDesc wish_setting_desc;

	public List<OgTagConfigDesc> og_tag_config_descs;

	public List<OgTagItemDesc> og_tag_item_descs;

	public List<SeasonLimitedItemDesc> season_limited_items;

	public List<FirstTabDesc> first_tab_desc;

	public List<SecondTabDesc> second_tab_desc;

	public List<CollectionCustomDesc> collection_custom_descs;

	public List<CustomSortIDDesc> custom_sort_id_descs;
}
