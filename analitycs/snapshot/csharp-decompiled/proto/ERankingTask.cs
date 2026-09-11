namespace proto;

public class ERankingTask
{
	public enum PreConditionType
	{
		PreConditionType_NONE,
		PreConditionType_DAMAGE,
		PreConditionType_KILLS,
		PreConditionType_ASSIST_AND_KILLS,
		PreConditionType_SURVIVAL_TIME,
		PreConditionType_MAP,
		PreConditionType_RANKING_PERCENTILE
	}

	public enum ConditionType
	{
		ConditionType_NONE,
		ConditionType_SURVIVAL_TIME,
		ConditionType_FINISH_ROUNDS_TIMES,
		ConditionType_DAMAGE,
		ConditionType_ASSIST_AND_KILLS,
		ConditionType_KILLS,
		ConditionType_RP_PROTECT,
		ConditionType_BR_SHOP_COST,
		ConditionType_CS_SHOP_COST,
		ConditionType_MOVING_DISTANCE,
		ConditionType_HEAL,
		ConditionType_USE_GRENADE,
		ConditionType_WINS,
		ConditionType_POSITIVE_PLAY,
		ConditionType_RANKING_PERCENTILE_TIMES
	}

	public enum State
	{
		State_RECEIVED,
		State_FINISHED
	}

	public enum Type
	{
		Type_DAILY,
		Type_SPECIAL
	}

	public enum SpecialTaskEvent
	{
		Event_TRIGGER,
		Event_FINISH
	}
}
