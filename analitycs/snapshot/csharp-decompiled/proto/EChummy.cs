namespace proto;

public class EChummy
{
	public enum RequestType
	{
		RequestType_NONE = 0,
		RequestType_DISMISS_MENTORING_GRADUATE = 1,
		RequestType_DISMISS_MENTORING_UNDERGRADUATE = 2,
		RequestType_DISMISS_MENTORING_AUTO_BREAK = 3,
		RequestType_Create_MENTORING_APPRENTICE = 1024,
		RequestType_Create_MENTORING_ENROLL_STUDENT = 1025
	}

	public enum MultiRelationType
	{
		MultiRelationType_NONE,
		MultiRelationType_MENTORING
	}

	public enum Role
	{
		Role_NONE,
		Role_MENTORING_MENTOR,
		Role_MENTORING_STUDENT
	}

	public enum RelationState
	{
		RelationState_NONE,
		RelationState_DISMISS_WAIT,
		RelationState_DISMISS_DECLINED,
		RelationState_DISMISS_GRADUATE
	}

	public enum AddIntimacyEventType
	{
		AddIntimacyEventType_NONE,
		AddIntimacyEventType_ENDMATCH,
		AddIntimacyEventType_SENDGIFT,
		AddIntimacyEventType_BR_SEASONEND,
		AddIntimacyEventType_CS_SEASONEND
	}
}
