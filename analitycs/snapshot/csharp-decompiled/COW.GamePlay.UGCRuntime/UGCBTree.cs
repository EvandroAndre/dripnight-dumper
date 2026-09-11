using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCBTree : IUGCBTree, IBridgingEntity
{
	private UGCRuntime m_UGCRuntime;

	private string m_UGCEntityID;

	private string m_AttachableEntityID;

	private IUGCBTreeNode m_Root;

	private UGCBTreeBlackboard m_Blackboard;

	private Dictionary<string, IUGCBTreeNode> m_Nodes;

	public UGCBTree Create(UGCRuntime ugcRuntime, UGCBtTreeData treeData, string attachableEntityID)
	{
		return null;
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

	public void OnLogicEntityDestroy()
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

	public void InterruptCurrent()
	{
	}

	public void SetBlackboardValue(string key, object value)
	{
	}

	public IUGCValue GetBlackboardValue(string key)
	{
		return null;
	}

	public void OnUGCPropertyChanged(long propID, IUGCValue value)
	{
	}

	public bool Check()
	{
		return false;
	}

	public bool IsEnabled()
	{
		return false;
	}

	public void Tick()
	{
	}

	private void Initialize()
	{
	}

	private void LoadFromData(UGCBtTreeData data)
	{
	}
}
