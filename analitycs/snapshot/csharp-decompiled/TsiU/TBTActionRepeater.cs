using COW.GamePlay.UGCRuntime;

namespace TsiU;

public class TBTActionRepeater : GSTBTAction, IAttachUGCBTreeNode
{
	protected class TBTActionRepeaterContext : TBTActionContext
	{
		internal int curLoop;
	}

	private int _maxLoop;

	public TBTActionRepeater()
		: base(0)
	{
	}

	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}

	protected override int onUpdate(TBTWorkingData wData)
	{
		return 0;
	}

	public void InitUGC(UGCRuntime ugcRuntime, UGCBtNodeData nodeData, UGCBTreeBlackboard blackboard, string entityID)
	{
	}

	public void OnNodeDestroy()
	{
	}

	protected override void OnClose(TBTWorkingData wData)
	{
	}
}
