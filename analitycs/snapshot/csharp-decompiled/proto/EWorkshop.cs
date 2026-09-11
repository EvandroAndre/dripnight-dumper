namespace proto;

public class EWorkshop
{
	public enum UnlockSlotCostType
	{
		ConsumeType_NONE,
		ConsumeType_ITEMS,
		ConsumeType_COINS,
		ConsumeType_GEMS
	}

	public enum SlotType
	{
		SlotType_ALL = 0,
		SlotType_EDIT = 1,
		SlotType_SHARE = 2,
		SlotType_SUBSCRIPTION = 3,
		SlotType_AUTHOR = 5
	}

	public enum SlotState
	{
		SlotState_EMPTY,
		SlotState_NORMAL,
		SlotState_LOCK,
		SlotState_UPDATABLE,
		SlotState_DELETED,
		SlotState_EXPIRED,
		SlotState_BAN,
		SlotState_PUBLISHED,
		SlotState_WARNING,
		SlotState_REVIEWING,
		SlotState_MAPLOCK,
		SlotState_SOFT_BAN
	}

	public enum ExpireType
	{
		ExpireType_NONE,
		ExpireType_WORKSHOP_CODE,
		ExpireType_WORKSHOP_CODE_BANNED,
		ExpireType_ACCOUNT_BANNED,
		ExpireType_WORKSHOP_CODE_PROTECT,
		ExpireType_ACCOUNT_PROTECT,
		ExpireType_WARNING_STATE
	}

	public enum TaskType
	{
		TaskType_NONE,
		TaskType_DAILY_PLAY,
		TaskType_CREATE_ROOM,
		TaskType_LIKED,
		TaskType_WSCODE_CREATE_ROOM_USED,
		TaskType_GAME_TIME
	}

	public enum MatchPoolType
	{
		MatchPoolType_RECOMMEND = 0,
		MatchPoolType_SENIOR = 1,
		MatchPoolType_MIDDLE = 2,
		MatchPoolType_JUNIOR = 3,
		MatchPoolType_ALL = 99
	}

	public enum DataAPIType
	{
		DataAPIType_NONE,
		DataAPIType_RECOMMEND,
		DataAPIType_MATCH_POOL,
		DataAPIType_HOT_MAP,
		DataAPIType_AUTO_REVIEW,
		DataAPIType_KEYWORD_QUERY,
		DataAPIType_AUTO_REVIEW_NEW,
		DataAPIType_KEYWORD_AI_QUERY,
		DataAPIType_MAP_FLOW_RECOMMEND
	}

	public enum SwitchType
	{
		SwitchType_NONE = 0,
		SwitchType_DATA_API_RECOMMEND = 1,
		SwitchType_DATA_API_MATCH_POOL = 2,
		SwitchType_DATA_API_HOT_MAP = 3,
		SwitchType_EDITOR_CHOICE = 4,
		SwitchType_MOST_POPULAR = 5,
		SwitchType_AllOW_ALL_RECREATION = 6,
		SwitchType_TEMPLATE_CONFIG = 7,
		SwitchType_DIRTY_WORD_REVIEW = 8,
		SwitchType_DIRTY_PICTURE_REVIEW = 9,
		SwitchType_EST_PLAY_TIME = 10,
		SwitchType_MAP_DETECT_REWARD = 11,
		SwitchType_WEB_AUDIT = 12,
		SwitchType_BACKEND_DIRTY_WORD_CHECK = 13,
		SwitchType_ENABLE_SUB_VIP = 14,
		SwitchType_ENABLE_SUB_WEEKLY_VIP = 15,
		SwitchType_ENABLE_SUB_MONTHLY_VIP = 16,
		Switchtype_MAP_COVER_AUDIT_DISPLAY = 17,
		SwitchType_VIP = 18,
		SwitchType_CRAFTLAND_RECOMMEND = 19,
		SwitchType_MAP_CONTENT_AUTO_TRANSLATE = 20,
		SwitchType_RESOURCE_STORE = 21,
		SwitchType_PLATFORM_LEADERBOARD = 22,
		SwitchType_ENABLE_PUBLISH_MONETIZATION_MAP = 23,
		SwitchType_MAP_COVER_AI_REVIEW = 24,
		SwitchType_ENABLE_GENERATE_SHORT_CODE = 25,
		SwitchType_MAP_COVER_PERMISSION = 26,
		SwitchType_VIRTUAL_HOT_VALUE = 27,
		SwitchType_NEWPLAYER_RECOMMENDATION_MAP = 29,
		SwitchType_CALLSIGN = 30,
		SwitchType_CREATOR_AGE_CONFIRM = 31,
		SwitchType_TUTORIAL_LEVEL = 32
	}

	public enum LikeType
	{
		LikeType_Like,
		LikeType_Dislike
	}

	public enum WordFilterType
	{
		WordFilterType_NONE,
		WordFilterType_HUD,
		WordFilterType_GRAPH,
		WordFilterType_NAME,
		WordFilterType_DESC,
		WordFilterType_GLOBAL_VAR,
		WordFilterType_LOCAL_VAR,
		WordFilterType_FUNC,
		WordFilterType_BLOCK,
		WordFilterType_OBJECT,
		WordFilterType_SHOP,
		WordFilterType_OPEN_ATTRIBUTES,
		WordFilterType_LOCALIZATION,
		WordFilterType_LEADERBOARD_NAME,
		WordFilterType_CODESCRIPT,
		WordFilterType_SCENE_OBJECT,
		WordFilterType_PLATFORM_LEADERBOARD_LOCALIZATION
	}

	public enum BanType
	{
		BanType_UNBAN,
		BanType_BAN,
		BanType_WARNING,
		BanType_SOFT_BAN,
		BanType_SOFT_UNBAN
	}

	public enum RecommendMode
	{
		RecommendMode_NONE,
		RecommendMode_ALGORITHM,
		RecommendMode_OPERATE,
		RecommendMode_HEAT
	}

	public enum RecommendPosition
	{
		RecommendPosition_NONE,
		RecommendPosition_HOTMAP,
		RecommendPosition_WEEKLIST
	}

	public enum EditorType
	{
		EditorType_CRAFTLAND,
		EditorType_FIREDITOR
	}

	public enum EditorChoiceType
	{
		EditorChoiceType_NONE = 0,
		EditorChoiceType_PRIMARY = 1,
		EditorChoiceType_SECONDARY = 2,
		EditorChoiceType_TERTIARY = 3,
		EditorChoiceType_SHOP = 10
	}

	public enum QuickJoinSwitchType
	{
		QuickJoinSwitchType_NONE,
		QuickJoinSwitchType_HOTMAP,
		QuickJoinSwitchType_ALL
	}

	public enum ReviewResult
	{
		ReviewResult_PASS,
		ReviewResult_TIME_OUT,
		ReviewResult_DIRTY_WORD,
		ReviewResult_DIRTY_PICTURE,
		ReviewResult_DIRTY_SCREENSHOT,
		ReviewResult_WEBADUIT_NOT_PASSED,
		ReviewResult_DATA_TOO_LONG
	}

	public enum LeaderboardOrderType
	{
		LeaderboardOrderType_POSITIVE,
		LeaderboardOrderType_REVERSE
	}

	public enum DataStorageEventLogActionType
	{
		DataStorageEventLogActionType_NONE,
		DataStorageEventLogActionType_WRITE,
		DataStorageEventLogActionType_READ,
		DataStorageEventLogActionType_DELETE
	}

	public enum AuthorTag
	{
		AuthorTag_NONE,
		AuthorTag_AUTHOR_PUBLIC,
		AuthorTag_AUTHOR_PRIVATE
	}

	public enum AuditUpdateType
	{
		AuditUpdateType_NONE,
		AuditUpdateType_WEB,
		AuditUpdateType_EXIT_MECHANISM
	}

	public enum AuditType
	{
		AuditType_NONE,
		AuditType_COVER
	}

	public enum VIPType
	{
		VIPType_NONE,
		VIPType_WEEKLY,
		VIPType_MONTHLY
	}

	public enum ObtainWorkshopVIPSrc
	{
		ObtainWorkshopVIPSrc_NONE,
		ObtainWorkshopVIPSrc_GENERAL_PURCHASE,
		ObtainWorkshopVIPSrc_RENEW,
		ObtainWorkshopVIPSrc_GMTOOL,
		ObtainWorkshopVIPSrc_BACKPACK,
		ObtainWorkshopVIPSrc_PURSUB
	}

	public enum WebAuditResult
	{
		WebAuditResult_NONE,
		WebAuditResult_PASS,
		WebAuditResult_BAN,
		WebAuditResult_SOFT_BAN
	}

	public enum CraftlandRecommendMode
	{
		CraftlandRecommendMode_NONE,
		CraftlandRecommendMode_FIXED,
		CraftlandRecommendMode_RECENT,
		CraftlandRecommendMode_OPERATION,
		CraftlandRecommendMode_DISCOVER
	}

	public enum ResourceStoreCmd
	{
		ResourceStoreCmd_NONE,
		ResourceStoreCmd_RES_STORE_LIST,
		ResourceStoreCmd_RES_STORE_BUY,
		ResourceStoreCmd_RES_STORE_GET_DOWNLOAD_URL,
		ResourceStoreCmd_RES_STORE_SEARCH,
		ResourceStoreCmd_UPLOAD_GET_UPLOAD_URL,
		ResourceStoreCmd_UPLOAD_REPORT_UPLOAD_SUCCESS,
		ResourceStoreCmd_UPLOAD_LIST,
		ResourceStoreCmd_UPLOAD_DETAIL,
		ResourceStoreCmd_UPLOAD_OFFLINE,
		ResourceStoreCmd_UPLOAD_DELETE,
		ResourceStoreCmd_HUB_LIST,
		ResourceStoreCmd_HUB_CANCEL_PURCHASE,
		ResourceStoreCmd_RES_STORE_LIKE,
		ResourceStoreCmd_RES_STORE_CANCEL_LIKE,
		ResourceStoreCmd_RES_STORE_SEARCH_3D,
		ResourceStoreCmd_RES_STORE_LIKE_LIST,
		ResourceStoreCmd_RES_STORE_DETAIL,
		ResourceStoreCmd_PERSONAL_INFO,
		ResourceStoreCmd_PERSONAL_LIMIT,
		ResourceStoreCmd_RES_STORE_RECOMMENDED_MENU,
		ResourceStoreCmd_RES_STORE_RECOMMENDED
	}

	public enum ResourceStoreUserType
	{
		ResourceStoreUserType_NONE,
		ResourceStoreUserType_GENERAL,
		ResourceStoreUserType_SUPERUSER
	}

	public enum MapManagementPrivilegeType
	{
		MapManagementPrivilegeType_None,
		MapManagementPrivilegeType_COVER
	}

	public enum SearchWeightType
	{
		SearchWeightType_None,
		SearchWeightType_TextMatch,
		SearchWeightType_Recommendation,
		SearchWeightType_PotentialConversion,
		SearchWeightType_SemanticWeight
	}

	public enum DataStorageSheetErrorType
	{
		DataStorageSheetErrorType_None,
		DataStorageSheetErrorType_InvalidSheetName
	}

	public enum ProductStatus
	{
		ProductStatus_None,
		ProductStatus_Offline,
		ProductStatus_PreOnline,
		ProductStatus_Online
	}

	public enum AccountMatchStateUpdateResult
	{
		AccountMatchStateUpdateResult_NONE,
		AccountMatchStateUpdateResult_OK,
		AccountMatchStateUpdateResult_REJECT
	}

	public enum LimitedPurchaseType
	{
		LimitedPurchaseType_None,
		LimitedPurchaseType_Account
	}

	public enum ItemConsumeResult
	{
		ItemConsumeResult_Success,
		ItemConsumeResult_InvalidCnt,
		ItemConsumeResult_NotEnough
	}

	public enum MapCoverAuditStatus
	{
		MapCoverAuditStatus_None,
		MapCoverAuditStatus_PASS,
		MapCoverAuditStatus_FAIL,
		MapCoverAuditStatus_AUDITING
	}
}
