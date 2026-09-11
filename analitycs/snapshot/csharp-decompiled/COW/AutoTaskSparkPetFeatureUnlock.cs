using proto;

namespace COW;

public class AutoTaskSparkPetFeatureUnlock : AutoPopupTask
{
	private UISparkPetLevelUpAnnounceController m_LevelUpAnnounceUI;

	private UIModelSparkPet m_ModelSparkPet;

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

	private bool CheckShouldShowFeatureUnlock()
	{
		return false;
	}

	private bool HasFeatureUnlock(SparkLevelAwardDesc awardDesc)
	{
		return false;
	}

	private SparkLevelAwardDesc FindNextFeatureUnlockLevelAwardDesc(uint currentLevel)
	{
		return null;
	}
}
