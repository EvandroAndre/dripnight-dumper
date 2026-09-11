using TsiU;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCBTreeNode : IBridgingEntity
{
	TBTAction GetNode();

	void AddChild(IUGCBTreeNode child);

	bool Check();

	int Tick();

	void InterruptCurrent();

	void OnLogicEntityDestroy();

	object GetParam(string key);
}
