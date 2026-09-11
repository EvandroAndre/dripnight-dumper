namespace TsiU;

public class TBTPreconditionAND : TBTPreconditionBinary
{
	public TBTPreconditionAND(TBTPrecondition lhs, TBTPrecondition rhs)
		: base(null, null)
	{
	}

	public override bool IsTrue(TBTWorkingData wData)
	{
		return false;
	}
}
