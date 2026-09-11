namespace COW.GamePlay;

public class BaseAutoGenIDLevelObject : BaseLevelObject
{
	protected override string GetObjectTag()
	{
		return null;
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	public virtual bool NeedRegenIDWhenDelete()
	{
		return false;
	}
}
