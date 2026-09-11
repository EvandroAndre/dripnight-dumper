using COW.GamePlay;

public class UGCLevelBounceTire : BaseAutoGenIDLevelObject
{
	protected override string GetObjectTag()
	{
		return null;
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}
}
