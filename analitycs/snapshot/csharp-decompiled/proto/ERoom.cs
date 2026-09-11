namespace proto;

public class ERoom
{
	public enum Cmd
	{
		Cmd_NONE,
		Cmd_SEND_ALL_ROOMS,
		Cmd_OK
	}

	public enum ChangeMatchInfoEvent
	{
		ChangeMatchInfoEvent_NONE,
		ChangeMatchInfoEvent_CHOOSELOADOUTS,
		ChangeMatchInfoEvent_CHOOSECLOTHES,
		ChangeMatchInfoEvent_EQUIPSKILLS,
		ChangeMatchInfoEvent_ROOMCARD,
		ChangeMatchInfoEvent_SELECTPROFILE,
		ChangeMatchInfoEvent_SELECTPETSKILL,
		ChangeMatchInfoEvent_SELECTPET,
		ChangeMatchInfoEvent_UPGRADEPET,
		ChangeMatchInfoEvent_RENAMEPET,
		ChangeMatchInfoEvent_SELECTPETSKIN,
		ChangeMatchInfoEvent_CHOOSEEMOTE,
		ChangeMatchInfoEvent_CHOOSESLOTS,
		ChangeMatchInfoEvent_CHOOSESHOWS,
		ChangeMatchInfoEvent_CHOOSEBANNER,
		ChangeMatchInfoEvent_CHOOSEPIN,
		ChangeMatchInfoEvent_CHOOSEHEADPIC,
		ChangeMatchInfoEvent_CHOOSEGAMEBAGSHOW,
		ChangeMatchInfoEvent_CHOOSERANDOMSLOTS,
		ChangeMatchInfoEvent_CHOOSELEADERBOARDTITLE,
		ChangeMatchInfoEvent_CHANGEEVOGUNSKINPROPERTY,
		ChangeMatchInfoEvent_CHANGEWORKSHOPTOKENINFO,
		ChangeMatchInfoEvent_CHOOSECOLLECTIONACTIONS,
		ChangeMatchInfoEvent_CHOOSEQUICKMSG,
		ChangeMatchInfoEvent_CHOOSECOLLECTIONSKILLSKINS,
		ChangeMatchInfoEvent_CHOOSELOADOUTV2,
		ChangeMatchInfoEvent_UPDATEOCCUPATION,
		ChangeMatchInfoEvent_CHOOSECOLLECTIONFINALSHOTS,
		ChangeMatchInfoEvent_CHOOSEWEAPONSKINCUSTOMS,
		ChangeMatchInfoEvent_ENDMATCH,
		ChangeMatchInfoEvent_GLOOWORLD,
		ChangeMatchInfoEvent_WORKSHOPVIP,
		ChangeMatchInfoEvent_CHOOSECOLLECTIONSUPEREMOTE,
		ChangeMatchInfoEvent_CHANGEAFKPUNISHENDTIME,
		ChangeMatchInfoEvent_CHANGEHIPPOEQUIP,
		ChangeMatchInfoEvent_CHANGEBADGE,
		ChangeMatchInfoEvent_RANDOMSKINS,
		ChangeMatchInfoEvent_CHOOSETITLE,
		ChangeMatchInfoEvent_CHOOSECOLLECTIONFINISHMOVE,
		ChangeMatchInfoEvent_UPDATECOLLECTIONCUSTOMS,
		ChangeMatchInfoEvent_UPDATEPRESETS,
		ChangeMatchInfoEvent_UPDATESOCIALHALLTITLE
	}

	public enum DropPresetState
	{
		DropPresetState_DEFAULT_OFF_FUNC_OPEN,
		DropPresetState_DEFAULT_ON_FUNC_OPEN,
		DropPresetState_DEFAULT_OFF_FUNC_CLOSE,
		DropPresetState_DEFAULT_ON_FUNC_CLOSE
	}

	public enum WeatherType
	{
		WeatherType_NONE,
		WeatherType_DAY,
		WeatherType_NIGHT
	}

	public enum CustomRoomSetting
	{
		CustomRoomSetting_HIDEKILLINFO = 0,
		CustomRoomSetting_UNLIMITEDAMMO = 1,
		CustomRoomSetting_NOFALLINGDAMAGE = 2,
		CustomRoomSetting_NOLOADOUT = 3,
		CustomRoomSetting_NOAIRDROP = 4,
		CustomRoomSetting_NOSKILL = 5,
		CustomRoomSetting_NOVEHICLE = 6,
		CustomRoomSetting_PLAYERHP_START = 8,
		CustomRoomSetting_PLAYERHP_END = 10,
		CustomRoomSetting_PLAYEREP_START = 11,
		CustomRoomSetting_PLAYEREP_END = 13,
		CustomRoomSetting_PLAYERSPEED_START = 14,
		CustomRoomSetting_PLAYERSPEED_END = 16,
		CustomRoomSetting_PLAYERJUMPHEIGHT_START = 21,
		CustomRoomSetting_PLAYERJUMPHEIGHT_END = 23,
		CustomRoomSetting_ACCTOTALSTATS = 24,
		CustomRoomSetting_ROUNDNUM_START = 25,
		CustomRoomSetting_ROUNDNUM_END = 26,
		CustomRoomSetting_INITCOIN_START = 27,
		CustomRoomSetting_INITCOIN_END = 28,
		CustomRoomSetting_NOPOWERGUN = 29
	}

	public enum CustomRoomSetting2
	{
		CustomRoomSetting2_NOUAV,
		CustomRoomSetting2_NOBOMB
	}

	public enum CustomRoomSetting3
	{
		CustomRoomSetting3_BRWeaponBox = 0,
		CustomRoomSetting3_PrivilegeVoice = 1,
		CustomRoomSetting3_ItemGenerator = 2,
		CustomRoomSetting3_DROPLIST_START = 3,
		CustomRoomSetting3_DROPLIST_END = 7,
		CustomRoomSetting3_GameAffix = 8
	}

	public enum Type
	{
		Type_NONE = 0,
		Type_CASUAL = 1,
		Type_LEAGUE_NORMAL = 2,
		Type_LEAGUE_BATCH = 6,
		Type_WEREWOLVES = 7,
		Type_WORKSHOP = 8,
		Type_RUSHING_PETS = 9,
		Type_CLAN = 10
	}

	public enum CardType
	{
		CardType_FREE,
		CardType_NORMAL,
		CardType_ADVANCED,
		CardType_WEREWOLVES,
		CardType_WORKSHOP,
		CardType_RUSHING_PETS,
		CardType_CLAN,
		CardType_ADVANCED_PRIVILEGE
	}

	public enum CardConsumeType
	{
		CardConsuemType_NONE,
		CardConsumeType_TIMELIMITED,
		CardConsumeType_COUNT,
		CardConsumeType_WORKSHOP_GENERAL_TIMES,
		CardConsumeType_WORKSHOP_FREE,
		CardConsumeType_WORKSHOP_AUTO_CREATE,
		CardConsumeType_CLAN,
		CardConsumeType_WORKSHOP_VIP,
		CardConsumeType_ADVANCED_PRIVILEGE
	}

	public enum RoomMmClosedReason
	{
		RoomMmClosedReason_NONE,
		RoomMmClosedReason_CLOSED_BY_ROOM_OWNER,
		RoomMmClosedReason_MM_TIMEOUT,
		RoomMmClosedReason_MM_FAILED,
		RoomMmClosedReason_NO_GAMESERVER_AVAILABLE,
		RoomMmClosedReason_CANCELED_BY_ROOM_MEMBER,
		RoomMmClosedReason_CANCELED_BY_MATCHMAKING_PLAYER
	}

	public enum InteractionItem
	{
		InteractionItem_NONE,
		InteractionItem_RAMEN_SHOP,
		InteractionItem_WEAPON_BOX,
		InteractionItem_VENDING_MACHINE,
		InteractionItem_MUSHROOM,
		InteractionItem_PICKUP_INFINITE_AIR_DROP,
		InteractionItem_ONEMORE_INFINITE_AIR_DROP,
		InteractionItem_INFINITE_CAKE,
		InteractionItem_WOODENMAN_BOX,
		InteractionItem_GLASS_BRIDGE_BUFF,
		InteractionItem_BISCUIT_STAND,
		InteractionItem_GRAFFITI,
		InteractionItem_GHOST,
		InteractionItem_OIL_LAMP_PEAK,
		InteractionItem_OIL_LAMP_DARK,
		InteractionItem_BUNNY_WARRIOR,
		InteractionItem_OIL_LAMP_NORMAL,
		InteractionItem_MOBILE_ISLAND,
		InteractionItem_MOBILE_ISLAND_WISH,
		InteractionItem_MOBILE_ISLAND_DEER,
		InteractionItem_DA_MUSHROOM,
		InteractionItem_TREASURE_LOCATION,
		InteractionItem_TREASURE_TROVE,
		InteractionItem_SURPRISE_CHEST,
		InteractionItem_TRUCK,
		InteractionItem_DISCOBALL,
		InteractionItem_FISHING,
		InteractionItem_FESTIVAL_SHARD,
		InteractionItem_KNIGHT_SWORD,
		InteractionItem_PLATFORM_COINS,
		InteractionItem_DEATH_BOX,
		InteractionItem_SKY_BUBBLE,
		InteractionItem_BM_CIRCLE,
		InteractionItem_BM_ALPHA_WOLF
	}

	public enum BagItemInteractionType
	{
		BagItemInteractionType_NONE,
		BagItemInteractionType_USE,
		BagItemInteractionType_GET,
		BagItemInteractionType_EQUIP,
		BagItemInteractionType_BUY,
		BagItemInteractionType_MOVE,
		BagItemInteractionType_DASH
	}

	public enum EnterPlaceType
	{
		EnterPlaceType_NONE,
		EnterPlaceType_UNDERWATER_POI,
		EnterPlaceType_WATER_CIRCLE
	}

	public enum AirDropType
	{
		AirDropType_NONE,
		AirDropType_NORMAL,
		AirDropType_BUBBLE
	}

	public enum SwitchFunc
	{
		SwitchFunc_NONE,
		SwitchFunc_ENABLE_DETAILED_PRESENCE,
		SwitchFunc_LEAGUE_ROOM_HIDDEN_MAP
	}

	public enum CrossMapMatchmakingErrCode
	{
		CrossMapMatchmakingErrCode_NONE,
		CrossMapMatchmakingErrCode_REACH_MAX_MEMBERS_LIMIT,
		CrossMapMatchmakingErrCode_MATCHMAKING_TIMEOUT,
		CrossMapMatchmakingErrCode_INVALID_ACCOUNT_ID,
		CrossMapMatchmakingErrCode_AUTO_CREATE_ROOM_FAILED,
		CrossMapMatchmakingErrCode_HALF_JOIN_MATCH_FAILED,
		CrossMapMatchmakingErrCode_START_MATCH_FAILED
	}
}
