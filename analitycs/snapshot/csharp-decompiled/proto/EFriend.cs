namespace proto;

public class EFriend
{
	public enum FriendMainType
	{
		FriendMainType_NONE,
		FriendMainType_REGION
	}

	public enum IntimacyType
	{
		IntimacyType_NONE,
		IntimacyType_ENDMATCH,
		IntimacyType_SENDGIFT,
		IntimacyType_CHAT
	}

	public enum RelationType
	{
		RelationType_NONE,
		RelationType_CONFIDANT
	}

	public enum IntimacyRankAwardStatus
	{
		IntimacyRankAwardStatus_INIT,
		IntimacyRankAwardStatus_AWARDED
	}

	public enum SpecialFriendState
	{
		SpecialFriendState_NONE,
		SpecialFriendState_WAIT_CREATE,
		SpecialFriendState_ALREADY_BE,
		SpecialFriendState_WAIT_DISMISS,
		SpecialFriendState_DECLINED
	}

	public enum SpecialFriendSendApplyResult
	{
		SpecialFriendSendApplyResult_NONE,
		SpecialFriendSendApplyResult_SUCCESS,
		SpecialFriendSendApplyResult_TARGET_APPLY_MAX,
		SpecialFriendSendApplyResult_TARGET_SPECIAL_FRIEND_MAX
	}

	public enum SpecialFriendReplyResult
	{
		SpecialFriendReplyResult_REJECT,
		SpecialFriendReplyResult_AGREE
	}

	public enum FriendAliasAction
	{
		FriendAliasAction_NONE,
		FriendAliasAction_SET,
		FriendAliasAction_UPDATE,
		FriendAliasAction_REMOVE
	}

	public enum IntimacyAwardType
	{
		IntimacyAwardType_ITEM,
		IntimacyAwardType_SHARE_SKILLS
	}

	public enum InteractionType
	{
		InteractionType_NONE,
		InteractionType_ENDMATCH,
		InteractionType_LIKE,
		InteractionType_SENDGIFT,
		InteractionType_SPECTATEGIFT
	}

	public enum SeasonReplayFriendTag
	{
		SeasonReplayFriendTag_NONE,
		SeasonReplayFriendTag_MOST_BOOYAH,
		SeasonReplayFriendTag_MOST_REVIVE,
		SeasonReplayFriendTag_MOST_SHORT_LIVED,
		SeasonReplayFriendTag_MOST_CS_MVP,
		SeasonReplayFriendTag_MOST_CS_LOSE,
		SeasonReplayFriendTag_MOST_WIN_RATE,
		SeasonReplayFriendTag_MOST_GAMES_PLAYED,
		SeasonReplayFriendTag_MOST_MATCH_LIKE,
		SeasonReplayFriendTag_HIGHEST_RANK,
		SeasonReplayFriendTag_HIGHEST_ONE_GAME_DAMAGE,
		SeasonReplayFriendTag_HIGHEST_ONE_GAME_KILLs,
		SeasonReplayFriendTag_MOST_STREAK_WINS,
		SeasonReplayFriendTag_MOST_MVP,
		SeasonReplayFriendTag_CS_AVERAGE_ROUNDS,
		SeasonReplayFriendTag_MOST_MVP_RATE,
		SeasonReplayFriendTag_MOST_MATCH_BE_LIKED,
		SeasonReplayFriendTag_AVERAGE_KILLS,
		SeasonReplayFriendTag_MOST_BE_REVIVED,
		SeasonReplayFriendTag_MOST_MONEY_SEPND,
		SeasonReplayFriendTag_MOST_MONEY_BE_SEPNT,
		SeasonReplayFriendTag_LEAST_WIN_RATE,
		SeasonReplayFriendTag_MOST_TOP_10_PERCENT_RATE,
		SeasonReplayFriendTag_MOST_RESTORE,
		SeasonReplayFriendTag_IN_ELECTRIC_ZONE_TOGETHER,
		SeasonReplayFriendTag_CARRY_ON_VEHICLE_DISTANCE,
		SeasonReplayFriendTag_MOST_BUY_HITLIST,
		SeasonReplayFriendTag_MOST_COLLECT_TOKEN,
		SeasonReplayFriendTag_MOST_BE_RESTORED
	}

	public enum CallbackTaskEvent
	{
		CallbackTaskEvent_NONE,
		CallbackTaskEvent_LEVEL_UP,
		CallbackTaskEvent_LOGIN,
		CallbackTaskEvent_END_MATCH,
		CallbackTaskEvent_BRRANKING,
		CallbackTaskEvent_CSRANKING,
		CallbackTaskEvent_INVITE_FRIEND_RETURN
	}

	public enum CallbackTaskCdtType
	{
		CallbackTaskCdtType_NONE,
		CallbackTaskCdtType_LEVEL_UP,
		CallbackTaskCdtType_LOGIN_DAYS,
		CallbackTaskCdtType_CONTINUOUS_LOGIN_DAYS,
		CallbackTaskCdtType_MATCH_PLAYED,
		CallbackTaskCdtType_BRRANKING_RANK_UP,
		CallbackTaskCdtType_CSRANKING_STAR_RANK_UP,
		CallbackTaskCdtType_INVITE_FRIEND_RETURN,
		CallbackTaskCdtType_PLAY_WITH_CALLBACK_INVITER
	}

	public enum CallbackTaskState
	{
		CallbackTaskState_INIT,
		CallbackTaskState_FINISHED,
		CallbackTaskState_CLAIMED
	}

	public enum CallbackRelation
	{
		CallbackRelation_RETURNER,
		CallbackRelation_INVITER
	}

	public enum CallbackRequestRelation
	{
		CallbackRequestRelation_SEND,
		CallbackRequestRelation_RECEIVE
	}

	public enum SeasonReplayRecommendFriendType
	{
		SeasonReplayRecommendFriendType_NONE,
		SeasonReplayRecommendFriendType_COMMON_FIRNED,
		SeasonReplayRecommendFriendType_CLAN_MEMBER,
		SeasonReplayRecommendFriendType_RANDOM
	}

	public enum RemoveBlacklistType
	{
		RemoveBlacklistType_NONE,
		RemoveBlacklistType_MATCHMAKING_BLACKLIST,
		RemoveBlacklistType_APPLICATION_BLACKLIST
	}

	public enum SparkState
	{
		SparkState_NONE,
		SparkState_ACTIVE,
		SparkState_DORMANT,
		SparkState_EXTINGUISHED
	}

	public enum SparkFeatureUnlockType
	{
		SparkFeatureUnlockType_NONE,
		SparkFeatureUnlockType_TEMPER,
		SparkFeatureUnlockType_PERSONAL_SHOW,
		SparkFeatureUnlockType_COLLAB,
		SparkFeatureUnlockType_ACHIEVEMENT,
		SparkFeatureUnlockType_CHANGE_APPEARANCE,
		SparkFeatureUnlockType_GACHA_POOL
	}

	public enum SparkCondition
	{
		SparkCondition_NONE,
		SparkCondition_ACTIVE_TO_DORMANT,
		SparkCondition_DORMANT_TO_ACTIVE,
		SparkCondition_DORMANT_TO_EXTINGUISHED,
		SparkCondition_EXTINGUISHED_TO_ACTIVE
	}

	public enum SparkStateTransitionType
	{
		SparkStateTransitionType_NONE,
		SparkStateTransitionType_ACTIVE_TO_DORMANT,
		SparkStateTransitionType_ACTIVE_TO_EXTINGUISHED,
		SparkStateTransitionType_DORMANT_TO_EXTINGUISHED,
		SparkStateTransitionType_DORMANT_TO_ACTIVE,
		SparkStateTransitionType_EXTINGUISHED_TO_ACTIVE
	}

	public enum FreshPlayerRecommendSource
	{
		FreshPlayerRecommendSource_NONE,
		FreshPlayerRecommendSource_PERSONAL_POOL,
		FreshPlayerRecommendSource_PUBLIC_POOL
	}
}
