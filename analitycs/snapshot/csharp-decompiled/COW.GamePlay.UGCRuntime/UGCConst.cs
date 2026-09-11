using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public static class UGCConst
{
	public const int EUGCModuleType_StdLibrary = 10000;

	public const int EUGCModuleType_List = 10001;

	public const int EUGCModuleType_Map = 10002;

	public const int EUGCModuleType_Math = 10003;

	public const int EUGCModuleType_Strings = 10004;

	public const int EUGCModuleType_Convert = 10005;

	public const int EUGCModuleType_Football = 10006;

	public const int EUGCModuleType_Camera = 10007;

	public const int EUGCModuleType_AI = 10008;

	public const int EUGCModuleType_Other = 10009;

	public const int EUGCModuleType_Player = 10010;

	public const int EUGCModuleType_Buff = 10011;

	public const int EUGCModuleType_Scene = 10012;

	public const int EUGCModuleType_FF_Platform = 10013;

	public const int EUGCModuleType_Items = 10014;

	public const int EUGCModuleType_Combat = 10016;

	public const int EUGCModuleType_Collection = 10017;

	public const int EUGCModuleType_Offline = 10018;

	public const int EUGCModuleType_CSVData = 10019;

	public const int EUGCModuleType_Matchmaking = 10020;

	public const int EUGCModuleType_AntiHack = 10021;

	public const int EUGCModuleType_Workflow = 1;

	public const int EUGCModuleType_RoundBlackboard = 2;

	public const int EUGCModuleType_ScoreBlackboard = 5;

	public const int EUGCModuleType_RankBlackboard = 7;

	public const int EUGCModuleType_SafeZone = 9;

	public const int EUGCModuleType_GenerateSpawnPosMgr = 10;

	public const int EUGCModuleType_EntityRepDataBlackboard = 11;

	public const int EUGCModuleType_CheckPoint = 13;

	public const int EUGCModuleType_Team = 14;

	public const int EUGCModuleType_MatchResult = 15;

	public const int EUGCModuleType_HudPrefabMgr = 16;

	public const int EUGCModuleType_StatisticalReport = 17;

	public const int EUGCModuleType_PropertyFormulaMgr = 18;

	public const int EUGCModuleType_ShopMgr = 19;

	public const int EUGCModuleType_WalletModule = 20;

	public const int EUGCModuleType_LevelObjectMgr = 21;

	public const int EUGCModuleType_MorphMgr = 22;

	public const int EUGCModuleType_ArchTypeMgr = 23;

	public const int EUGCModuleType_ChatChannelMgr = 24;

	public const int EUGCModuleType_Faction = 25;

	public const int EUGCModuleType_Hostility = 26;

	public const int EUGCModuleType_KDA = 27;

	public const int EUGCModuleType_Transform = 28;

	public const int EUGCModuleType_Playable = 29;

	public const int EUGCModuleType_Database = 30;

	public const int EUGCModuleType_InternalHudMgr = 31;

	public const int EUGCModuleType_Dyeing = 32;

	public const int EUGCModuleType_Physics = 33;

	public const int EUGCModuleType_MiniMap = 34;

	public const int EUGCModuleType_Animation = 35;

	public const int EUGCModuleType_BehaviourTree = 36;

	public const int EUGCModuleType_PathFinding = 37;

	public const int EUGCModuleType_Avatar = 38;

	public const int EUGCModuleType_Profile = 39;

	public const int EUGCModuleType_AirDrop = 40;

	public const int EUGCModuleType_Time = 41;

	public const int EUGCModuleType_Premium = 42;

	public const int EUGCModuleType_LLM = 43;

	public const int EUGCModuleType_TimeLine = 44;

	public const int EUGCModuleType_Plot = 45;

	public const int EUGCModuleType_Skeleton = 46;

	public const int EUGCModuleType_Device = 47;

	public const int EUGCModuleType_CommerceIAP = 48;

	public const int EUGCModuleType_MapResource = 49;

	public const string PROFILE_GETREPITEM = "Runtime GetRepItem";

	public const string PROFILE_SETREPITEM = "Runtime SetRepItem";

	public const string PROFILE_DISPATCH = "Runtime DispatchHandler";

	private static Dictionary<long, string> PROPERTY_NAME;

	public const int ENTITY_CUSTOM_REPDATA_MAX = 1000;

	public const int CUSTOM_TYPE_ID_START = 100000;

	public const int CUSTOM_EVENT_START = 100000;

	public static bool PROFILER_ENABLE;

	public static bool TRS_LOG_ENABLE;

	public const string PHASE_ENTITY_ID_FORMAT = "PhaseIndex-{0}";

	public const string CurrentItemCountInMatch = "CreateItemCountInTheMatch";

	public const string MaxItemCountInMatch = "CreateItemCountMaxPerMatch";

	public const string EUGCInternalEntityID_Global = "global";

	public const string EUGCInternalEntityID_ForType = "forType";

	public const int SIZE_FLOAT = 4;

	public const int SIZE_INT64 = 8;

	public const int SIZE_INT = 4;

	public const string GLOBAL_TERRAIN_ENTITY_ID = "GlobalTerrain";

	public static string API_PROFILE(DOMDODOIOBI funcValue, bool detail = false)
	{
		return null;
	}

	public static string PROPERTY_PROFILE(long propertyIndex, IUGCTypeMap typeMap)
	{
		return null;
	}

	public static string PLAYABLE_PROFILE(IUGCPlayable playable)
	{
		return null;
	}
}
