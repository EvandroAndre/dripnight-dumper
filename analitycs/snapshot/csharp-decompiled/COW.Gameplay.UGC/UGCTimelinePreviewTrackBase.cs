using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

public class UGCTimelinePreviewTrackBase : IUGCTimelinePreviewTrack
{
	protected UGCTimelinePreviewMgr m_PreviewMgr;

	protected IUGCTimelineTrack m_Track;

	public virtual void Init(UGCTimelinePreviewMgr previewMgr, IUGCTimelineTrack track)
	{
	}

	public virtual IUGCTimelineTrack GetTrack()
	{
		return null;
	}

	public virtual bool TryRestoreTrackControlValue(float lastPlayProgress)
	{
		return false;
	}

	public virtual void Destroy()
	{
	}
}
