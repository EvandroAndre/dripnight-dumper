namespace TsiU;

public class TBTPreconditionNOT : TBTPreconditionUnary
{
	public TBTPreconditionNOT(TBTPrecondition lhs)
		: base(null)
	{
	}

	public override bool IsTrue(TBTWorkingData wData)
	{
		return false;
	}
}
