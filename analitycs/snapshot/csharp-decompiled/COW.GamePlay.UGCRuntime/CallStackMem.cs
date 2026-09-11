using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class CallStackMem : IUGCObjectPoolItem
{
	public QuickObjectPoolMap objPoolMgr;

	public List<PCaller> callStack;

	public CallStackMem Create(QuickObjectPoolMap quickObjectPoolMap)
	{
		return null;
	}

	public void Reset()
	{
	}

	public PCaller TopStack()
	{
		return null;
	}

	public PCaller PushStack(DOMDODOIOBI target, bool popLayerWhenPop)
	{
		return null;
	}

	public PCaller PopStack(out bool needPopLayer)
	{
		needPopLayer = default(bool);
		return null;
	}

	public void ResetLoopCount()
	{
	}
}
