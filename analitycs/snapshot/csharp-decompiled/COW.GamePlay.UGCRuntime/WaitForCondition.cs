namespace COW.GamePlay.UGCRuntime;

public class WaitForCondition : BaseWaitFor, IIterator, IUGCObjectPoolItem
{
	private uint startWaitTimeMs;

	private WaitForConditionFunc conditionFunc;

	public IIterator Create(WaitForConditionFunc condition)
	{
		return null;
	}

	public override void Reset()
	{
	}

	public bool Next()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Reset()
	{
	}
}
