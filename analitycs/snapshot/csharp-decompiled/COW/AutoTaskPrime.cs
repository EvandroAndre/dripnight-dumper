namespace COW;

public class AutoTaskPrime : AutoPopupTask
{
	private UIPrimeIntroductionController m_IntroCtrl;

	private UIPrimeLevelUpController m_levelUpCtrl;

	private UISettingController m_CurrentSettingCtrl;

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
