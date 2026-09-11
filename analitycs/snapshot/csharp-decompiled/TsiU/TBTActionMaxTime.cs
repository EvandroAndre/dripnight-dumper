using COW.GamePlay.UGCRuntime;

namespace TsiU;

public class TBTActionMaxTime : GSTBTAction, IAttachUGCBTreeNode
{
	protected class TBTActionMaxTimeContext : TBTActionContext
	{
		internal long startTime;
	}

	private int _maxTime;

	public TBTActionMaxTime()
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

	protected override void OnOpen(TBTWorkingData wData)
	{
	}

	protected override void OnClose(TBTWorkingData wData)
	{
	}
}
