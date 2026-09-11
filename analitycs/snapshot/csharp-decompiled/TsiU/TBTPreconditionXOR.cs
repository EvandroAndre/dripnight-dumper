namespace TsiU;

public class TBTPreconditionXOR : TBTPreconditionBinary
{
	public TBTPreconditionXOR(TBTPrecondition lhs, TBTPrecondition rhs)
		: base(null, null)
	{
	}

	public override bool IsTrue(TBTWorkingData wData)
	{
		return false;
	}
}
