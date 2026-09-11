namespace COW.GamePlay.UGCRuntime;

public class UGCWaitForSecondsV2 : BaseWaitFor, IIterator, IUGCObjectPoolItem
{
	private uint waitEndTimeMs;

	private StackContext stackContext;

	public IIterator Create(uint waitMSeconds, StackContext stackContext)
	{
		return null;
	}

	public bool Next()
	{
		return false;
	}

	public override void Reset()
	{
	}

	public void _003C_003EiFixBaseProxy_Reset()
	{
	}
}
