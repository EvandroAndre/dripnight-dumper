namespace GCommon;

public class GRIDataPoolUnsafe : ReplicationDataPoolUnsafe, IGRIDataPool, IRepDataPool
{
	public GRIDataPoolUnsafe(int maxVarCount)
		: base(0)
	{
	}
}
