namespace proto;

public class EMiniGame
{
	public enum MiniGame
	{
		MiniGame_NONE,
		MiniGame_BOOYAH_CHESS,
		MiniGame_MONOPOLY,
		MiniGame_BOOYAHGO,
		MiniGame_WinterFestStrategy,
		MiniGame_FFWSMANAGER,
		MiniGame_RAMPAGE4B
	}

	public enum HexagonStatus
	{
		HexagonStatus_NONE,
		HexagonStatus_PLAYER,
		HexagonStatus_ENEMY,
		HexagonStatus_CHEST,
		HexagonStatus_BOOYAH
	}

	public enum GameStatus
	{
		GameStatus_NONE,
		GameStatus_INGAME
	}

	public enum MonopolyNodeType
	{
		MonopolyNodeType_NONE,
		MonopolyNodeType_BOX,
		MonopolyNodeType_DICE,
		MonopolyNodeType_FORWWARD,
		MonopolyNodeType_BACKWARD,
		MonopolyNodeType_BUFF,
		MonopolyNodeType_TOKEN,
		MonopolyNodeType_EVENT,
		MonopolyNodeType_START
	}

	public enum MonopolyEventResultType
	{
		MonopolyEventResultType_NONE,
		MonopolyEventResultType_TOKEN,
		MonopolyEventResultType_ACTIVITY
	}

	public enum MonopolyPlayerStatus
	{
		MonopolyPlayerStatus_NONE,
		MonopolyPlayerStatus_WAITINGEVENT
	}

	public enum BooyahgoNodeType
	{
		BooyahgoNodeType_NONE,
		BooyahgoNodeType_BOX,
		BooyahgoNodeType_DICE,
		BooyahgoNodeType_FORWARD,
		BooyahgoNodeType_TRAP,
		BooyahgoNodeType_BUFF,
		BooyahgoNodeType_TOKEN,
		BooyahgoNodeType_START,
		BooyahgoNodeType_SKULLKING,
		BooyahgoNodeType_END
	}

	public enum BuildingType
	{
		BuildingType_NONE,
		BuildingType_ALLOY,
		BuildingType_BATTERY,
		BuildingType_CRYSTAL,
		BuildingType_PLASTIC,
		BuildingType_MAIN
	}

	public enum FFWS03ManagerStageType
	{
		FFWS03ManagerStageType_NONE,
		FFWS03ManagerStageType_HIGHEST_LEVEL_COUNT,
		FFWS03ManagerStageType_MATCH_SCORE,
		FFWS03ManagerStageType_TEAM_KILL_COUNT,
		FFWS03ManagerStageType_BOOYAH_COUNT
	}

	public enum FFWS03ManagerMatchID
	{
		FFWS03ManagerMatchID_NONE,
		FFWS03ManagerMatchID_AUDITION,
		FFWS03ManagerMatchID_QUALIFIER,
		FFWS03ManagerMatchID_UNLIMITED,
		FFWS03ManagerMatchID_FINAL,
		FFWS03ManagerMatchID_TEAM_TRAINING
	}

	public enum FFWS03ManagerMatchType
	{
		FFWS03ManagerMatchType_NONE,
		FFWS03ManagerMatchType_SWORD,
		FFWS03ManagerMatchType_POLICY
	}
}
