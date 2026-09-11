namespace proto;

public class ECup
{
	public enum MemberType
	{
		MemberType_NONE,
		MemberType_NORMAL_MEMBER,
		MemberType_CAPTAIN
	}

	public enum TeamUserChangeType
	{
		TeamUserChangeType_NONE,
		TeamUserChangeType_REQUEST,
		TeamUserChangeType_APPROVE_APPLICATION,
		TeamUserChangeType_INVITE,
		TeamUserChangeType_APPROVE_INVITATION,
		TeamUserChangeType_REMOVE,
		TeamUserChangeType_QUIT,
		TeamUserChangeType_WORLD_INVITATION
	}
}
