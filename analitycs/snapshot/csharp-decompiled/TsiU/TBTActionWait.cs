using COW.GamePlay.UGCRuntime;

namespace TsiU;

public class TBTActionWait : GSTBTActionLeaf, IAttachUGCBTreeNode
{
	protected class TBTActionWaitData
	{
		internal long startTime;
	}

	private int _waitTime;

	protected override int onExecute(TBTWorkingData wData)
	{
		return 0;
	}

	public void InitUGC(UGCRuntime ugcRuntime, UGCBtNodeData nodeData, UGCBTreeBlackboard blackboard, string entityID)
	{
	}

	public void OnNodeDestroy()
	{
	}

	protected override void OnOpen(TBTWorkingData wData)
	{
	}
}
