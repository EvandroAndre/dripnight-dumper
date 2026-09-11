using GCommon;

namespace COW.GamePlay;

public abstract class MCEOPOOHDEK : LReplicationEntity
{
	public override void OnRelease()
	{
	}

	protected override bool IsLocalEntity()
	{
		return false;
	}

	protected override void RegisterEntity()
	{
	}

	protected override void UnRegisterEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRelease()
	{
	}
}
