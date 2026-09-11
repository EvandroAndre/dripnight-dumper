namespace proto;

public class ECloudStorage
{
	public enum ObjectType
	{
		ObjectType_WORKSHOP_EXPORT_SETTINGS = 0,
		ObjectType_WORKSHOP_PROJECT_SETTINGS = 1,
		ObjectType_MATCH_REPLAY = 2,
		ObjectType_WORKSHOP_OPEN_ATTRIBUTES_EXT = 3,
		ObjectType_WORKSHOP_MAP_COVER = 4,
		ObjectType_CUSTOMIZE_RESOURCE = 5,
		ObjectType_WORKSHOP_MAP_SCREENSHOT = 6,
		ObjectType_CLIENT_DEBUGGER_LOG = 7,
		ObjectType_CLIENT_DEBUGGER_REPLAY = 8,
		ObjectType_UGC_AI_ASSISTANT_DATA = 9,
		ObjectType_WORKSHOP_CUSTOMIZE_RESOURCE_SCREENSHOT = 10,
		ObjectType_LIMITED_EVENT_FLAME25B_DATA = 11,
		ObjectType_MATCH_REVIEW = 12,
		ObjectType_PHOTO_WALL = 13,
		ObjectType_WORKSHOP_CREATOR_FEEDBACK_SCREENSHOT = 14,
		ObjectType_WORKSHOP_CREATOR_FEEDBACK_VIDEO = 15,
		ObjectType_WORKSHOP_CREATOR_FEEDBACK_PROJECT_FILE = 16,
		ObjectType_MAX = 99
	}

	public enum TempDataType
	{
		TempDataType_WORKSHOP,
		TempDataType_CUSTOMIZE_RESOURCE,
		TempDataType_MAP_COVER,
		TempDataType_LIMITED_EVENT_DATA,
		TempDataType_PHOTO_WALL
	}

	public enum ClientDebuggerType
	{
		ClientDebuggerType_LOG,
		ClientDebuggerType_REPLAY
	}

	public enum BucketType
	{
		BucketType_DEFAULT,
		BucketType_NON_REPORT,
		BucketType_TOXIC,
		BucketType_AI
	}
}
