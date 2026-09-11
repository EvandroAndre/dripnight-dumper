namespace COW.GamePlay.UGCRuntime;

public interface IUGCLevelObject : IBridgingEntity, IUGCTransform
{
	uint GetID();

	string GetName();

	string GetTag();

	void SetItemID(int itemID);

	void SetCustomName(string name);

	void SetNavMeshStatic(bool isStatic);

	void SetPhysxEnable(bool enable);

	void RegisterCollisionEventHander();
}
