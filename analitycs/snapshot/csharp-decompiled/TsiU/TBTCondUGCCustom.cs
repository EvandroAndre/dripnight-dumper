using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using message;

namespace TsiU;

public class TBTCondUGCCustom : GSTBTActionLeaf, IAttachUGCBTreeNode
{
	private UGCRuntime m_UGCRuntime;

	private ScriptScope m_ScriptScope;

	private DOMDODOIOBI m_CheckFunc;

	private StackContext m_StackContext;

	private List<UGCSimpleValue> m_ParamList;

	private bool m_Debug;

	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}

	public void InitUGC(UGCRuntime ugcRuntime, UGCBtNodeData nodeData, UGCBTreeBlackboard blackboard, string entityID)
	{
	}

	public void OnNodeDestroy()
	{
	}
}
