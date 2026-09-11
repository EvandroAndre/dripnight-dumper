namespace COW.GamePlay.UGCRuntime;

public interface IUGCBehaviourTreeModule : IUGCModule
{
	IUGCBTree CreateBTreeByID(string treeID, string targetEntityID);
}
