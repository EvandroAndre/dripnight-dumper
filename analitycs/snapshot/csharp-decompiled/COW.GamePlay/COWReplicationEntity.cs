using GCommon;

namespace COW.GamePlay;

public abstract class COWReplicationEntity : ReplicationEntity
{
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
}
