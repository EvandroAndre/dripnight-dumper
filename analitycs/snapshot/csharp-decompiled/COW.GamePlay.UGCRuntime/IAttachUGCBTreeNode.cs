namespace COW.GamePlay.UGCRuntime;

public interface IAttachUGCBTreeNode
{
	void InitUGC(UGCRuntime ugcRuntime, UGCBtNodeData nodeData, UGCBTreeBlackboard blackboard, string entityID);

	void OnNodeDestroy();
}
