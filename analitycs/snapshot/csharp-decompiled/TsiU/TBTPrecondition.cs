namespace TsiU;

public abstract class TBTPrecondition : TBTTreeNode
{
	public TBTPrecondition(int maxChildCount)
		: base(0)
	{
	}

	public abstract bool IsTrue(TBTWorkingData wData);
}
