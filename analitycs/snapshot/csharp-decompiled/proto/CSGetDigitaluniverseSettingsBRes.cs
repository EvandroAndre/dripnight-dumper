using System.Collections.Generic;

namespace proto;

public class CSGetDigitaluniverseSettingsBRes
{
	public DigitaluniverseBSettingDesc main_setting;

	public List<DigitaluniverseBCharMissionDesc> charactergate_missions;

	public List<DigitaluniverseBCharStoryDesc> charactergate_storys;

	public List<DigitaluniverseBMissionRewardDesc> mission_awards;

	public List<DigitaluniverseBMapMissionDesc> mapgate_missions;

	public List<DigitaluniverseBStoreRecommendDesc> store_recommends;

	public List<DigitaluniverseBSpecialEntranceDesc> special_entrances;

	public List<DigitaluniverseBCoreRulesDesc> core_rules;

	public List<DigitaluniverseBThreeDesc> three_descs;

	public List<DigitaluniverseBPostcardDesc> postcards;

	public List<DigitaluniverseBStarCraftValueDesc> star_craft_value_descs;

	public DigitaluniverseBStarCraftConfigDesc star_craft_config_desc;

	public List<DigitaluniverseBStarCraftCdFreshDesc> star_craft_cd_fresh_descs;

	public List<DigitaluniverseBStarCraftTargetDesc> star_craft_target_descs;
}
