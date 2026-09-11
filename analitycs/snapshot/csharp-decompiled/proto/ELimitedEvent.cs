namespace proto;

public class ELimitedEvent
{
	public enum StoreType
	{
		StoreType_NONE,
		StoreType_BRINGER,
		StoreType_LIBERI,
		StoreType_ANNIVERSARY,
		StoreType_BOOYAHDAY,
		StoreType_MVP,
		StoreType_GOLIATH,
		StoreType_FFWS,
		StoreType_FOURSYMBOLS,
		StoreType_MOCOMONTH,
		StoreType_BOOYAHDAY21,
		StoreType_FFWS03,
		StoreType_WinterFest21B,
		StoreType_DigitaluniverseB,
		StoreType_TrendAgentB
	}

	public enum EventID
	{
		EventID_NONE,
		EventID_RAMPAGE,
		EventID_ANNIVERSARY,
		EventID_MONEYHEIST,
		EventID_BOOYAHDAY,
		EventID_BOUNTY,
		EventID_BERMUDA,
		EventID_MEGAPUNCH,
		EventID_MVP,
		EventID_GOLIATH,
		EventID_FFWS,
		EventID_SUPERFIGHTER,
		EventID_SUPERCAR,
		EventID_SUTORITO,
		EventID_FOURSYMBOLS,
		EventID_MUSICFEST,
		EventID_MOCOMONTH,
		EventID_FFWS03,
		EventID_BOOYAHDAY21,
		EventID_WinterFest21B,
		EventID_JUMPSUIT,
		EventID_HOODEDKILLERB,
		EventID_HURRICANEB,
		EventID_BOYBANDB,
		EventID_RAMPAGE4B,
		EventID_DIGITALUNIVERSEB,
		EventID_POTENTIAB_OB36,
		EventID_FFWS2022B,
		EventID_NEWAGEB,
		EventID_KITCHENB,
		EventID_TRENDAGENTB,
		EventID_VILLAINB,
		EventID_SIXTHB,
		EventID_POTENTIAB,
		EventID_WINTERLAND23B,
		EventID_CHAOS24B,
		EventID_PERSONAB,
		EventID_SEVENTHB,
		EventID_GLOOWORLD,
		EventID_BOOYAHDAY24B,
		EventID_WINTERLAND24B,
		EventID_NCOLOR24B,
		EventID_CREATE25B,
		EventID_RAMADAN25B,
		EventID_CITYHEROBOY25B,
		EventID_EIGHTHB,
		EventID_PONY25B,
		EventID_NCOLOR25B,
		EventID_SF50B,
		EventID_DIWALI25B,
		EventID_FLAME25B,
		EventID_WINTERLAND25B,
		EventID_IIVSYS,
		EventID_CARNI25B,
		EventID_TREA25B,
		EventID_BLUETEARS26B,
		EventID_GBSYS,
		EventID_ECLIPSE26B,
		EventID_NINTHSYS,
		EventID_BM26SYS,
		EventID_NB1RESYS
	}

	public enum EntranceID
	{
		EntranceID_NONE = 0,
		EntranceID_DISTRIBUTE = 151,
		EntranceID_SIGNING_BOARD = 152,
		EntranceID_LINKAGE = 155,
		EntranceID_RANGOLI = 158
	}

	public enum EventState
	{
		EventState_NONE,
		EventState_WARMUP,
		EventState_PROCESS,
		EventState_SETTLE,
		EventState_SPAN,
		EventState_ICON
	}

	public enum ProcessType
	{
		ProcessType_NONE,
		ProcessType_BRINGER,
		ProcessType_LIBERI,
		ProcessType_NODE,
		ProcessType_BOUNTY_WARMUP,
		ProcessType_BOUNTY_POPULARITY,
		ProcessType_BOUNTY_MAIN_PERCENT,
		ProcessType_JUMPSUIT_STAGE,
		ProcessType_JUMPSUIT_CIRCLE,
		ProcessType_SIXTHB_WARMUP
	}

	public enum RampageFaction
	{
		RampageFaction_NONE,
		RampageFaction_BRINGER,
		RampageFaction_LIBERI
	}

	public enum NodeStatus
	{
		NodeStatus_NONE,
		NodeStatus_LOCKED,
		NodeStatus_UNLOCKED,
		NodeStatus_CLAIMED
	}

	public enum NodeType
	{
		NodeTYPE_NONE,
		NodeType_NORMAL,
		NodeType_ANNIVERSARY
	}

	public enum MoenyHeistHelp
	{
		MoenyHeistHelp_NONE,
		MoenyHeistHelp_FOR_OTHER,
		MoenyHeistHelp_FOR_SELF
	}

	public enum MoneyHeistAwardType
	{
		MoneyHeistAwardType_NONE,
		MoneyHeistAwardType_NORMAL,
		MoneyHeistAwardType_BIG
	}

	public enum MoneyHesitSpeedChangeType
	{
		MoneyHeistSpeedChangeType_NONE,
		MoneyHeistSpeedChangeType_TASK,
		MoneyHeistSpeedChangeType_TOKEN,
		MoneyHeistSpeedChangeType_FRIEND
	}

	public enum LeaderboardType
	{
		LeaderboardType_NONE,
		LeaderboardType_BOOYAH_GAME,
		LeaderboardType_BOOYAH_CHESS
	}

	public enum BooyahAwardStatus
	{
		BooyahAwardStats_INIT,
		BooyahAwardStats_AWARDED
	}

	public enum GoliathGroupJoinSource
	{
		GoliathGroupJoinSource_NONE,
		GoliathGroupJoinSource_FRIEND,
		GoliathGroupJoinSource_SEARCH,
		GoliathGroupJoinSource_WORLD,
		GoliathGroupJoinSource_SHARE,
		GoliathGroupJoinSource_ClAN
	}

	public enum SuperFighterManner
	{
		SuperFighterManner_NONE,
		SuperFighterManner_LIGHT,
		SuperFighterManner_HEAVY,
		SuperFighterManner_UNIQUE
	}

	public enum SuperFighterResult
	{
		SuperFighterResult_NONE,
		SuperFighterResult_WIN,
		SuperFighterResult_LOSE
	}

	public enum FFWSGuessingAwardStatus
	{
		FFWSGuessingAwardStats_INIT,
		FFWSGuessingAwardStats_AWARDED
	}

	public enum FFWSGuessingAwardType
	{
		FFWSGuessingAwardType_NONE,
		FFWSGuessingAwardType_WIN,
		FFWSGuessingAwardType_LOSE
	}

	public enum SutoritoManner
	{
		SutoritoManner_NONE,
		SutoritoManner_LIGHT,
		SutoritoManner_HEAVY,
		SutoritoManner_UNIQUE
	}

	public enum SutoritoResult
	{
		SutoritoResult_NONE,
		SutoritoResult_WIN,
		SutoritoResult_LOSE
	}

	public enum SutoritoCharacter
	{
		SutoritoCharacter_NONE,
		SutoritoCharacter_KELLY,
		SutoritoCharacter_SHIROU,
		SutoritoCharacter_RYU,
		SutoritoCharacter_CHUNLI
	}

	public enum FourSymbolsID
	{
		FourSymbolsID_NONE,
		FourSymbolsID_AZURE_DRAGON,
		FourSymbolsID_WHITE_TIGER,
		FourSymbolsID_BLACK_TORTOISE,
		FourSymbolsID_VERMILLION_BIRD
	}

	public enum FourSymbolsRoadNodeType
	{
		FourSymbolsRoadNodeType_NONE,
		FourSymbolsRoadNodeType_NORMAL,
		FourSymbolsRoadNodeType_AWARD
	}

	public enum JumpsuitJoinType
	{
		JumpsuitJoinType_NONE,
		JumpsuitJoinType_ACTIVE,
		JumpsuitJoinType_INVITED
	}

	public enum HoodedkillerBWeaponType
	{
		HoodedkillerBWeaponType_NONE,
		HoodedkillerBWeaponType_SLEEVEARROW,
		HoodedkillerBWeaponType_SWORD
	}

	public enum DigitaluniverseBTimeAttackStatus
	{
		DigitaluniverseBTimeAttackStatus_NONE,
		DigitaluniverseBTimeAttackStatus_INPROGRESS,
		DigitaluniverseBTimeAttackStatus_EXPIRED,
		DigitaluniverseBTimeAttackStatus_FINISHED
	}

	public enum DigitaluniverseBGateType
	{
		DigitaluniverseBGateType_NONE,
		DigitaluniverseBGateType_COLLECTION,
		DigitaluniverseBGateType_CLOTH,
		DigitaluniverseBGateType_MAP,
		DigitaluniverseBGateType_CHARACTER,
		DigitaluniverseBGateType_EVENT
	}

	public enum PotentiaBDimensionType
	{
		PotentiaBDimensionType_NONE,
		PotentiaBDimensionType_TEAM,
		PotentiaBDimensionType_DASH,
		PotentiaBDimensionType_REMOTE,
		PotentiaBDimensionType_SKILL,
		PotentiaBDimensionType_EXPLORE
	}

	public enum PotentiaBClaimRewardsType
	{
		PotentiaBClaimRewardsType_NONE,
		PotentiaBClaimRewardsType_STAR_SHARE,
		PotentiaBClaimRewardsType_FRIEND_LEADERBOARD,
		PotentiaBClaimRewardsType_STAR_ONE_CLICK_COLLECTION
	}

	public enum FFWS2022BClaimRewardsType
	{
		FFWS2022BClaimRewardsType_NONE,
		FFWS2022BClaimRewardsType_BOX,
		FFWS2022BClaimRewardsType_CARD_COLLECTION
	}

	public enum ProgressRewardType
	{
		ProgressRewardType_NONE,
		ProgressRewardType_MANUAL,
		ProgressRewardType_AUTO
	}

	public enum Flame25BPlayerEventType
	{
		Flame25BPlayerEventType_NONE,
		Flame25BPlayerEventType_PROGRESS,
		Flame25BPlayerEventType_BADGE,
		Flame25BPlayerEventType_BR_MVP,
		Flame25BPlayerEventType_CS_MVP,
		Flame25BPlayerEventType_ACE,
		Flame25BPlayerEventType_STREAK_WINS,
		Flame25BPlayerEventType_BR_HEROIC,
		Flame25BPlayerEventType_BR_ELITE_HEROIC,
		Flame25BPlayerEventType_BR_MASTER,
		Flame25BPlayerEventType_BR_ELITE_MASTER,
		Flame25BPlayerEventType_CS_HEROIC,
		Flame25BPlayerEventType_CS_ELITE_HEROIC,
		Flame25BPlayerEventType_CS_MASTER,
		Flame25BPlayerEventType_CS_ELITE_MASTER,
		Flame25BPlayerEventType_CS_PEAK_MVP,
		Flame25BPlayerEventType_CS_PEAK_ACE,
		Flame25BPlayerEventType_CS_PEAK_POINT
	}

	public enum Flame25BGlobalEventType
	{
		Flame25BGlobalEventType_NONE,
		Flame25BGlobalEventType_PROGRESS,
		Flame25BGlobalEventType_BR_MVP,
		Flame25BGlobalEventType_CS_MVP,
		Flame25BGlobalEventType_ACE,
		Flame25BGlobalEventType_CS_PEAK_MVP,
		Flame25BGlobalEventType_CS_PEAK_ACE
	}

	public enum Flame25BPropType
	{
		Flame25BPropType_NONE = 0,
		Flame25BPropType_SURVIVAL_TIME = 1,
		Flame25BPropType_BOOYAH_COUNT = 2,
		Flame25BPropType_DAMAGE = 3,
		Flame25BPropType_KILLS = 4,
		Flame25BPropType_ASSISTS = 5,
		Flame25BPropType_HEALING_AMOUNT = 6,
		Flame25BPropType_REVIVAL_COUNT = 7,
		Flame25BPropType_MVP_COUNT = 8,
		Flame25BPropType_HEADSHOT_COUNT = 9,
		Flame25BPropType_ACE_COUNT = 10,
		Flame25BPropType_RESTORE_COUNT = 11,
		Flame25BPropType_REVIVAL_N_COUNT = 12,
		Flame25BPropType_RESTORE_N_COUNT = 13,
		Flame25BPropType_DONATED = 14,
		Flame25BPropType_LIKED = 15,
		Flame25BPropType_TOTAL_LIKE = 16,
		Flame25BPropType_TOTAL_GAME_COUNT = 17,
		Flame25BPropType_DEATHS = 18,
		Flame25BPropType_MATCH_POINT = 19,
		Flame25BPropType_WIN_RATING = 100,
		Flame25BPropType_AVG_POINT = 101,
		Flame25BPropType_AVG_SURVIVAL_TIME = 102,
		Flame25BPropType_KDA = 103,
		Flame25BPropType_HEADSHOT_RATING = 104
	}

	public enum Flame25BClanType
	{
		Flame25BClanType_NONE = 0,
		Flame25BClanType_CHOOSE_DEFAULT = 998,
		Flame25BClanType_CHOOSE_CLAN = 999
	}

	public enum LimitedEventRankType
	{
		LimitedEventRankType_NONE,
		LimitedEventRankType_HEROIC,
		LimitedEventRankType_ELITE_HEROIC,
		LimitedEventRankType_MASTER,
		LimitedEventRankType_ELITE_MASTER
	}

	public enum Carni25BPlayerEventType
	{
		Carni25BPlayerEventType_NONE,
		Carni25BPlayerEventType_ENTRY,
		Carni25BPlayerEventType_MESSAGE,
		Carni25BPlayerEventType_BASIC_CONSUME,
		Carni25BPlayerEventType_VIP_CONSUME
	}

	public enum BlueTears26BFishColor
	{
		BlueTears26BFishColor_NONE,
		BlueTears26BFishColor_NORMAL,
		BlueTears26BFishColor_COLORFUL,
		BlueTears26BFishColor_RARE,
		BlueTears26BFishColor_ELITERARE
	}

	public enum BlueTears26BFishFigure
	{
		BlueTears26BFishFigure_NONE,
		BlueTears26BFishFigure_SMALL,
		BlueTears26BFishFigure_MID,
		BlueTears26BFishFigure_BIG
	}
}
