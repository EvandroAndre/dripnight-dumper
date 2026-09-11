namespace GCommon;

public class PRIDataPool : ReplicationDataPool, IPRIDataPool, IRepDataPool
{
	protected ReplicationEntity m_Owner;

	protected LReplicationEntity m_LOwner;

	protected uint m_ReplicationID;

	public PRIDataPool(ReplicationEntity owner, uint repID, int maxVarCount)
		: base(0)
	{
	}

	public PRIDataPool(LReplicationEntity owner, uint repID, int maxVarCount)
		: base(0)
	{
	}

	public uint GetReplicationID()
	{
		return 0u;
	}
}
