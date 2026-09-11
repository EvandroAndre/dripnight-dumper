namespace COW;

public class AutoTaskPetLevelUp : AutoPopupTask
{
	private UIPetLevelUpController m_PetLevelUpUI;

	public override int[] NeedHttpRequests()
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
}
