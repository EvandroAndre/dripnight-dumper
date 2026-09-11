namespace proto;

public class EChampionship
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
		TeamUserChangeType_AUTO_QUIT
	}

	public enum ChampionshipPhase
	{
		ChampionshipPhase_NONE,
		ChampionshipPhase_TRIAL,
		ChampionshipPhase_FINAL
	}

	public enum TeamScaleType
	{
		TeamScaleType_NONE,
		TeamScaleType_SOLO,
		TeamScaleType_TRIO,
		TeamScaleType_QUINTET
	}
}
