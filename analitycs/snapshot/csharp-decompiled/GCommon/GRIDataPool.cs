namespace GCommon;

public class GRIDataPool : ReplicationDataPool, IGRIDataPool, IRepDataPool
{
	public GRIDataPool(int maxVarCount)
		: base(0)
	{
	}
}
