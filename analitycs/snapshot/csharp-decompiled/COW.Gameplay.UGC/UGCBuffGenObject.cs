using COW.GamePlay;

namespace COW.Gameplay.UGC;

public class UGCBuffGenObject : BaseLevelObject
{
	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
