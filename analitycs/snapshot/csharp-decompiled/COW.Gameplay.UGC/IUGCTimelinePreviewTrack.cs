using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

public interface IUGCTimelinePreviewTrack
{
	void Init(UGCTimelinePreviewMgr previewMgr, IUGCTimelineTrack track);

	IUGCTimelineTrack GetTrack();

	bool TryRestoreTrackControlValue(float lastPlayProgress);

	void Destroy();
}
