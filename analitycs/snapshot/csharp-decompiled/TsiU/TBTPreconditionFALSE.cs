namespace TsiU;

public class TBTPreconditionFALSE : TBTPreconditionLeaf
{
	public override bool IsTrue(TBTWorkingData wData)
	{
		return false;
	}
}
