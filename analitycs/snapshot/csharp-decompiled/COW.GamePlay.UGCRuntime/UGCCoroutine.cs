using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCCoroutine : IIterator, IUGCObjectPoolItem
{
	public StackContext stackContext;

	public UGCCoroutine Create(StackContext stackContext, DOMDODOIOBI target)
	{
		return null;
	}

	public void Reset()
	{
	}

	public bool Next()
	{
		return false;
	}

	public bool IsDone()
	{
		return false;
	}
}
