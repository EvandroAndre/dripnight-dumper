using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using message;

namespace TsiU;

public class TBTActionUGCCustom : GSTBTActionLeaf, IAttachUGCBTreeNode
{
	private UGCRuntime m_UGCRuntime;

	private ScriptScope m_ScriptScope;

	private DOMDODOIOBI m_TickFunc;

	private IIterator m_LastWaitFuncState;

	private StackContext m_StackContext;

	private List<UGCSimpleValue> m_ParamList;

	private object[] m_UGCEventArgs;

	private string m_EntityID;

	private bool m_Debug;

	protected override void onEnter(TBTWorkingData wData)
	{
	}

	protected override void onExit(TBTWorkingData wData, int runningStatus)
	{
	}

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
}
