namespace tcp;

public class EProfile
{
	public enum Proto
	{
		Proto_NONE,
		Proto_NEW_PROFILE_NTF,
		Proto_NEW_SKILL_NTF,
		Proto_PROFILE_CHANGE_NTF,
		Proto_AWAKEN_TASK_CHANGE_NTF,
		Proto_AWARD_GAME_LINK_NTF,
		Proto_PROFICIENCY_CHANGE_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
