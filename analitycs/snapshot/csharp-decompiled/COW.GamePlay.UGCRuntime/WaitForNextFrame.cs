namespace COW.GamePlay.UGCRuntime;

public class WaitForNextFrame : BaseWaitFor, IIterator, IUGCObjectPoolItem
{
	private uint waitEndTick;

	private StackContext stackContext;

	public IIterator Create(StackContext stackContext)
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
