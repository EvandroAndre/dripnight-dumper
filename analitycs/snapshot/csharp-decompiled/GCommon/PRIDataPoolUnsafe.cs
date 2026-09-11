namespace GCommon;

public class PRIDataPoolUnsafe : ReplicationDataPoolUnsafe, IPRIDataPool, IRepDataPool
{
	protected ReplicationEntity m_Owner;

	protected LReplicationEntity m_LOwner;

	protected uint m_ReplicationID;

	public PRIDataPoolUnsafe(ReplicationEntity owner, uint repID, int maxVarCount)
		: base(0)
	{
	}

	public PRIDataPoolUnsafe(LReplicationEntity owner, uint repID, int maxVarCount)
		: base(0)
	{
	}

	public uint GetReplicationID()
	{
		return 0u;
	}
}
