namespace proto;

public class EGameServerManager
{
	public enum Proto
	{
		Proto_NONE = 0,
		Proto_REPORT = 1,
		Proto_PLAYERLOGIN = 2,
		Proto_PLAYERLOGOUT = 3,
		Proto_ENDMATCH = 4,
		Proto_CUSTOMROOM_MATCHSTATS = 5,
		Proto_UPDATE_INGAMEITEMS = 6,
		Proto_GS_READY = 7,
		Proto_UGC_DEBUG_GS_READY = 8,
		Proto_GS_START_GAME_READY = 9,
		Proto_GS_JOIN_READY = 10,
		Proto_GS_CLOSE_GAME = 15,
		Proto_ROOM_MATCHSTATS = 16,
		Proto_START_CROSS_MAP_MATCHMAKING = 17,
		Proto_CANCEL_CROSS_MAP_MATCHMAKING = 18,
		Proto_CROSS_MAP_SETTLEMENT_COMPLETE = 19,
		Proto_SET_REMATCH_TEAM = 20
	}

	public enum ErrCode
	{
		ErrCode_SUSS = 0,
		ErrCode_ROOMFULL = 8
	}

	public enum HandleGSLoad
	{
		HandleGSLoad_NONE,
		HandleGSLoad_UPDATE,
		HandleGSLoad_DELETE
	}

	public enum NotifyGameServerType
	{
		NotifyGameServerType_NONE,
		NotifyGameServerType_DROP_MATCH,
		NotifyGameServerType_PUNISH_PLAYER,
		NotifyGameServerType_HIPPOABANDONMATCH,
		NotifyGameServerType_SOCIALHALL_UPDATE_PROFILE
	}
}
