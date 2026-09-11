namespace COW;

internal class AutoTaskVeteranReturn : AutoPopupTask
{
	private UIVeteranReturnController m_VeteranReturn;

	private UIVeteranV3MainController m_VeteranV3MainCtrl;

	private UIVeteranV3ShortTermController m_VeteranShortTermCtrl;

	private UIModelVeteran m_ModelVeteran;

	private bool isVeteranReturn;

	private bool isLongTerm;

	public static string VeteranReturnFirstPopUpDone;

	public static string VeteranReturnControllerPopUp;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	private bool IsAutoOpenVeteranMain()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
