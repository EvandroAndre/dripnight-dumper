using COW.GamePlay;

namespace COW.Gameplay.UGC;

public class UGCLevelBotGenerator : BaseLevelObject
{
	protected override string GetObjectTag()
	{
		return null;
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
