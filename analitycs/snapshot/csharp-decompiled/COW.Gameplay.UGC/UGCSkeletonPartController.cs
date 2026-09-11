using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

public class UGCSkeletonPartController
{
	protected EntityIndex m_entityIndex;

	public UGCSkeletonBoneOwner SkeletonOwner;

	protected UGCSkeletonPartControllerModule m_skeletonModule;

	public bool IsDestroyed;

	public virtual int SortValue => 0;

	public virtual void AttachUGCRuntime(UGCSkeletonPartControllerModule skeletonModule, EntityIndex entityIndex)
	{
	}

	public virtual void LateUpdateController()
	{
	}

	public virtual void DestroyController()
	{
	}
}
