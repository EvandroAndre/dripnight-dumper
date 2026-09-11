using message;

namespace COW.GamePlay.UGCRuntime;

public class PCaller : IUGCObjectPoolItem
{
	public DOMDODOIOBI target;

	public int runIndex;

	public int intCache1;

	public int intCache2;

	public int intCache3;

	public int loopCntInOneFrame;

	public string stringCache1;

	public string stringCache2;

	public object interfaceCache1;

	public object interfaceCache2;

	public bool PopLayerWhenPop;

	public PCaller Create(DOMDODOIOBI target, bool popLayerWhenPop)
	{
		return null;
	}

	public void Reset()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Move2End(StackContext stackContext)
	{
	}

	public DOMDODOIOBI MoveNext(StackContext stackContext)
	{
		return null;
	}

	private void moveNextForIndex(StackContext stackContext)
	{
	}

	private static bool IsInLoop(int start, int end, int step)
	{
		return false;
	}

	private void moveNextForRange(StackContext stackContext)
	{
	}

	private void moveNextWhile(StackContext stackContext)
	{
	}
}
