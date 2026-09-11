using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopDescRes
{
	public List<WorkshopCustomModeTemplateRuleDesc> template_rule_desc;

	public EWorkshop.QuickJoinSwitchType quick_join_switch;

	public List<WorkshopModeSwitchDesc> mode_switch_desc;

	public List<WorkshopTagMatchDesc> tag_match_desc;

	public WorkshopTagMatchDefaultOptionDesc tag_match_default_option_desc;

	public List<WorkshopEditLevelDesc> edit_level_desc;

	public List<WorkshopCategoryPageDesc> category_page_desc;

	public List<WorkshopRecommendSeriesDesc> recommend_series_desc;

	public List<WorkshopEditorChoiceDesc> editor_choice_descs;

	public WorkshopForbiddenResAndAPI forbidden_res_and_api;

	public List<WorkshopMapSurveyUrlDesc> survey_url_desc;

	public List<WorkshopTemplateConfigDesc> template_config_desc;

	public WorkshopServerConfigDesc workshop_server_config;

	public List<ResourceDownloadInfo> resource_download_infos;

	public List<WorkshopTimeLimitedModeRuleTagDesc> time_limited_tag_desc;

	public WorkshopDataStorageAwardDesc data_storage_award_desc;

	public List<WorkshopHotSearchConfigDesc> hot_search_config_desc;

	public WorkshopSearchConfigDesc search_config_desc;

	public List<ContentPublishChecklistDesc> content_publish_checklist_desc;

	public List<PublishChecklistStatusDesc> publish_checklist_status;

	public List<WorkshopMapPoolSortOptionDesc> map_pool_sort_option_desc;

	public List<WorkshopCreatorPrivilegeDesc> workshop_creator_privilege;

	public List<WorkshopLeaderboardConfigDesc> leaderboard_config_desc;

	public WorkshopCreatorFeedbackConfig creator_feedback_config;

	public List<WorkshopCreatorRewardDesc> creator_reward;

	public List<WorkshopLevelExpDesc> workshop_level_exp_desc;
}
