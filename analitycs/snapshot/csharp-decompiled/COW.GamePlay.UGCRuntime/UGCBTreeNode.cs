using TsiU;

namespace COW.GamePlay.UGCRuntime;

public class UGCBTreeNode : IUGCBTreeNode, IBridgingEntity
{
	private readonly UGCRuntime m_UGCRuntime;

	private readonly TBTAction m_Node;

	private readonly UGCBtNodeData m_NodeData;

	private readonly UGCBTreeBlackboard m_Blackboard;

	private string m_UGCEntityID;

	private UGCLogicEntity m_UGCEntity;

	public UGCBTreeNode(UGCRuntime ugcRuntime, UGCBTreeBlackboard blackboard, TBTAction node, UGCBtNodeData nodeData)
	{
	}

	public TBTAction GetNode()
	{
		return null;
	}

	public void AddChild(IUGCBTreeNode child)
	{
	}

	public void OnLogicEntityDestroy()
	{
	}

	public object GetParam(string key)
	{
		return null;
	}

	public int Tick()
	{
		return 0;
	}

	public void InterruptCurrent()
	{
	}

	public bool Check()
	{
		return false;
	}

	public int BridgingTypeID()
	{
		return 0;
	}

	public string UGCEntityID()
	{
		return null;
	}

	public void OnLogicEntityCreated(string entityID)
	{
	}

	public IUGCValue BridgingPropGetter(long bridgingProp)
	{
		return null;
	}

	public bool BridgingPropSetter(long bridgingProp, UGCSimpleValue value)
	{
		return false;
	}
}
