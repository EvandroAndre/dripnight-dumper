namespace COW;

public class AutoTaskClanPrivilegeClaim : AutoPopupTask
{
	private UIClanPrivilegeClaimWindowController m_Ctrl;

	public static string GetClanPrivilegeClaimKey()
	{
		return null;
	}

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
