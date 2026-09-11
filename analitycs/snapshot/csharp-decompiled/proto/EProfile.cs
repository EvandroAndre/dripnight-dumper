namespace proto;

public class EProfile
{
	public enum TaskState
	{
		TaskState_RECEIVED,
		TaskState_FINISHED,
		TaskState_AWARDED
	}

	public enum TaskType
	{
		TaskType_NONE,
		TaskType_MOVE_DISTANCE,
		TaskType_KILL,
		TaskType_WIN,
		TaskType_GROUP_WITH_FRIEND,
		TaskType_TASK_FINISHED_CUMU,
		TaskType_ITEM_COLLECT,
		TaskType_WEAPON_DAMAGE,
		TaskType_WEAPON_KILL,
		TaskType_REVIVAL_COUNT,
		TaskType_WEAPON_TYPE_KILL,
		TaskType_LOW_HP_KILL,
		TaskType_CS_ACHIEVED_KILL,
		TaskType_THROWING_COUNT
	}

	public enum UnlockType
	{
		UnlockType_NONE,
		UnlockType_LINK
	}

	public enum LinkProfileTagType
	{
		LinkProfileTagType_NONE,
		LinkProfileTagType_NEW,
		LinkProfileTagType_POPULAR
	}

	public enum EquipSource
	{
		EquipSource_SELF,
		EquipSource_CONFIDANT_FRIEND
	}

	public enum ProficiencyChangeReason
	{
		ProficiencyChangeReason_NONE,
		ProficiencyChangeReason_ENDMATCH,
		ProficiencyChangeReason_GMTOOL,
		ProficiencyChangeReason_LEVELTURN
	}
}
