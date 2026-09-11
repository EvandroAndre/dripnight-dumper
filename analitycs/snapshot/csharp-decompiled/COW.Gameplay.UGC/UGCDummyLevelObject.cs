using COW.GamePlay;

namespace COW.Gameplay.UGC;

public class UGCDummyLevelObject : BaseLevelObject
{
	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override void SetUGCStatic(bool isStatic)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUGCStatic(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
