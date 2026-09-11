namespace TsiU;

public class TBTPreconditionOR : TBTPreconditionBinary
{
	public TBTPreconditionOR(TBTPrecondition lhs, TBTPrecondition rhs)
		: base(null, null)
	{
	}

	public override bool IsTrue(TBTWorkingData wData)
	{
		return false;
	}
}
