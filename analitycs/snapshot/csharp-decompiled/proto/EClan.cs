namespace proto;

public class EClan
{
	public enum MemberType
	{
		MemberType_NONE,
		MemberType_NORMAL_MEMBER,
		MemberType_VICE_CAPTAIN,
		MemberType_CAPTAIN,
		MemberType_DEPUTY_CAPTAIN
	}

	public enum EntryType
	{
		EntryType_NONE,
		EntryType_MANUALLY,
		EntryType_AUTO
	}

	public enum ClanUserChangeType
	{
		ClanUserChangeType_NONE,
		ClanUserChangeType_REQUEST,
		ClanUserChangeType_APPROVE_APPLICATION,
		ClanUserChangeType_INVITE,
		ClanUserChangeType_APPROVE_INVITATION,
		ClanUserChangeType_CHANGE_MEMBER_TYPE,
		ClanUserChangeType_REASSIGN_CAPTAIN,
		ClanUserChangeType_REMOVE,
		ClanUserChangeType_QUIT,
		ClanUserChangeType_REQUEST_AUTO,
		ClanUserChangeType_ADMIN_CHANGE_MEMBER_TYPE,
		ClanUserChangeType_ASSIGN_AGENT,
		ClanUserChangeType_DISMISS_AGENT,
		ClanUserChangeType_APPLY_AGENT,
		ClanUserChangeType_APPLY_AGENT_SUCCESS,
		ClanUserChangeType_CANCEL_OVERTIME_AGENT,
		ClanUserChangeType_JOIN_BY_CLAN_WAR_RECRUIT,
		ClanUserChangeType_QUIT_BY_CLAN_WAR_RECRUIT,
		ClanUserChangeType_ADMIN_APPROVE_INVITATION
	}

	public enum ClanMainType
	{
		ClanMainType_NONE,
		ClanMainType_REGION,
		ClanMainType_AREA,
		ClanMainType_PLAY_STYLE
	}

	public enum ClanSubType
	{
		ClanSubType_NONE = 0,
		ClanSubType_FIRST_CLASS = 1,
		ClanSubType_SECOND_CLASS = 2,
		ClanSubType_THIRD_CLASS = 3,
		ClanSubType_FOURTH_CLASS = 4,
		ClanSubType_UNKNOW = -1
	}

	public enum ClanHonorType
	{
		ClanHonorType_NONE,
		ClanHonorType_MATCH,
		ClanHonorType_SAME_TEAM,
		ClanHonorType_TOP_UP
	}

	public enum ClanSignInRewardStatus
	{
		ClanSignInRewardStatus_NOT_SIGNED,
		ClanSignInRewardStatus_SIGNED,
		ClanSignInRewardStatus_CLAIMED
	}

	public enum RacePointsGainType
	{
		RacePointsGainType_NONE,
		RacePointsGainType_MATCH,
		RacePointsGainType_SAME_TEAM
	}

	public enum PlayerRacePointChangeType
	{
		PlayerRacePointChangeType_NONE,
		PlayerRacePointChangeType_MATCH,
		PlayerRacePointChangeType_PLAYER_LEAVES,
		PlayerRacePointChangeType_EXCHANGE
	}

	public enum NewsType
	{
		NewsType_NONE,
		NewsType_JOIN,
		NewsType_CHANGE_TYPE,
		NewsType_EP_BUNDLE,
		NewsType_IAP,
		NewsType_LEVEL_UP,
		NewsType_OTHERS,
		NewsType_BIG_LUCKY_BAG,
		NewsType_CSRANKING_DIAMOND,
		NewsType_CSRANKING_GRANDMASTER,
		NewsType_RANKING_DIAMOND,
		NewsType_RANKING_GRANDMASTER,
		NewsType_WEEKLY_MEMBERSHIP,
		NewsType_MONTHLY_MEMBERSHIP,
		NewsType_TOPUP,
		NewsType_SPECIAL_OFFER,
		NewsType_GROWUP_BUNDLE
	}

	public enum CreateLuckyBagEventType
	{
		CreateLuckyBagEventType_NONE,
		CreateLuckyBagEventType_EPBUNDLE,
		CreateLuckyBagEventType_IAP,
		CreateLuckyBagEventType_CSRANKING_END_MATCH,
		CreateLuckyBagEventType_RANKING_END_MATCH,
		CreateLuckyBagEventType_SUBSCRIPTE_MEMBERSHIP,
		CreateLuckyBagEventType_TOPUP,
		CreateLuckyBagEventType_SPECIAL_OFFER,
		CreateLuckyBagEventType_GROWUP_BUNDLE
	}

	public enum CreateLuckyBagCdtType
	{
		CreateLuckyBagCdtType_NONE = 0,
		CreateLuckyBagCdtType_EPBUNDLE = 1,
		CreateLuckyBagCdtType_IAP = 2,
		CreateLuckyBagCdtType_CSRANKING_DIAMOND = 3,
		CreateLuckyBagCdtType_CSRANKING_GRANDMASTER = 4,
		CreateLuckyBagCdtType_RANKING_DIAMOND = 5,
		CreateLuckyBagCdtType_RANKING_GRANDMASTER = 6,
		CreateLuckyBagCdtType_WEEKLY_MEMBERSHIP = 7,
		CreateLuckyBagCdtType_MONTHLY_MEMBERSHIP = 8,
		CreateLuckyBagCdtType_CREATE_BIG_LUCKY_BAG = 999,
		CreateLuckyBagCdtType_TOPUP = 9,
		CreateLuckyBagCdtType_SPECIAL_OFFER = 10,
		CreateLuckyBagCdtType_GROWUP_BUNDLE = 11
	}

	public enum ClanBadgeTriggerType
	{
		ClanBadgeTriggerType_NONE,
		ClanBadgeTriggerType_LEVEL_UP,
		ClanBadgeTriggerType_ITEM_EXCHANGE
	}

	public enum ActivenessType
	{
		ActivenessType_NONE,
		ActivenessType_CLAN,
		ActivenessType_PERSONAL
	}

	public enum ClanMsgType
	{
		ClanMsgType_NONE,
		ClanMsgType_JOIN_CLAN,
		ClanMsgType_RANK_HEORIC,
		ClanMsgType_RANK_MASTER,
		ClanMsgType_LOTTERY_BIG_REWARD,
		ClanMsgType_BP,
		ClanMsgType_PURCHASE_PRIVILEGE
	}

	public enum TagClassType
	{
		TagClassType_NONE,
		TagClassType_ACTIVENESS,
		TagClassType_SKILL,
		TagClassType_SOCIAL,
		TagClassType_GUILD_TYPE
	}

	public enum InvitationStatus
	{
		InvitationStatus_NONE,
		InvitationStatus_NEED_INVITEE_APPROVE,
		InvitationStatus_NEED_ADMIN_APPROVE
	}

	public enum ActivenessSourceType
	{
		ActivenessSourceType_NONE,
		ActivenessSourceType_MATCH,
		ActivenessSourceType_MISSION,
		ActivenessSourceType_GUILD_WAR,
		ActivenessSourceType_COST_GEM,
		ActivenessSourceType_QUIT_CLAN
	}

	public enum GuildWarPhaseType
	{
		GuildWarPhaseType_NONE,
		GuildWarPhaseType_PREHEAT,
		GuildWarPhaseType_MATCHMAKING,
		GuildWarPhaseType_SUBMITTING
	}

	public enum GuildWarSeasonType
	{
		GuildWarSeasonType_NONE,
		GuildWarSeasonType_CS,
		GuildWarSeasonType_BR,
		GuildWarSeasonType_LW
	}

	public enum TournamentPhaseType
	{
		TournamentPhaseType_NONE,
		TournamentPhaseType_PREHEAT,
		TournamentPhaseType_MATCHMAKING,
		TournamentPhaseType_SUBMITTING
	}

	public enum TournamentRoundType
	{
		TournamentRoundType_NONE,
		TournamentRoundType_QUALIFICATION,
		TournamentRoundType_ELIMINATION
	}

	public enum HighLightType
	{
		HighLightType_NONE,
		HighLightType_BR_RANK,
		HighLightType_CS_RANK,
		HighLightType_BR_STREAK_WINS,
		HighLightType_CS_STREAK_WINS
	}

	public enum LogoType
	{
		LogoType_NONE,
		LogoType_BADGE,
		LogoType_FRAME
	}

	public enum InvitationType
	{
		InvitationType_NONE,
		InvitationType_PERSONAL_WINDOW,
		InvitationType_MEMBER_RECURITE,
		InvitationType_RECOMMEND_RECURITE
	}

	public enum ApplicationType
	{
		ApplicationType_NONE,
		ApplicationType_PROMOTION,
		ApplicationType_LEADERBOARD,
		ApplicationType_PERSONAL_MSG,
		ApplicationType_PERSONAL_WINDOW,
		ApplicationType_QRCODE
	}

	public enum AreaLevel
	{
		AreaLevel_NONE,
		AreaLevel_COUNTRY,
		AreaLevel_PROVINCE,
		AreaLevel_CITY,
		AreaLevel_EMPTY
	}

	public enum EventLogActChgReason
	{
		EventLogActChgReason_NONE,
		EventLogActChgReason_INHERITEF,
		EventLogActChgReason_WEEKLY_SETTLE,
		EventLogActChgReason_PLAY_TOGETHER,
		EventLogActChgReason_MISSION,
		EventLogActChgReason_COST_GEM
	}

	public enum EventLogSetClanLocationType
	{
		EventLogSetClanLocationType_NONE,
		EventLogSetClanLocationType_CLANINFO,
		EventLogSetClanLocationType_CLANLEADERBOARD,
		EventLogSetClanLocationType_ADMIN
	}

	public enum BanType
	{
		BanType_NONE,
		BanType_MODIFY_CLAN_INFO,
		BanType_Guild_WAR,
		BanType_Tournament
	}

	public enum AccountBanType
	{
		AccountBanType_NONE,
		AccountBanType_JOIN_CLAN
	}

	public enum MemberPrivilegeChangeReason
	{
		MemberPrivilegeChangeReason_NONE,
		MemberPrivilegeChangeReason_CLAIM,
		MemberPrivilegeChangeReason_EXTEND,
		MemberPrivilegeChangeReason_QUIT
	}

	public enum PunishReason
	{
		PunishReason_NONE,
		PunishReason_CLAN_NAME_VIOLATED,
		PunishReason_CLAN_SLOGAN_VIOLATED
	}

	public enum PunishType
	{
		PunishType_NONE,
		PunishType_RENAME,
		PunishType_CLEAR_SLOGAN,
		PunishType_DISMISS
	}
}
