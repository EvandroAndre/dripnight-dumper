namespace COW;

public class AutoTaskVeteranFromInGame : AutoPopupTask
{
	private UIVeteranFirstGameLobbyEnterWndController m_VeteranGuideLobbyEnterWnd;

	public static string VeteranReturnFirstGameReward;

	public static string VeteranSkillExperienceRecommendPopKey;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public static bool VeteranFromInGame(out UIVeteranFirstGameLobbyEnterWndController popWnd)
	{
		popWnd = null;
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
