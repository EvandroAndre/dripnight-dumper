using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

public interface IUGCTimelinePreviewEntity
{
	bool Init(UGCRuntime ugcRuntime, string entityID);

	void Destroy();

	IUGCValue GetPreviewRepItemData(long propId);
}
