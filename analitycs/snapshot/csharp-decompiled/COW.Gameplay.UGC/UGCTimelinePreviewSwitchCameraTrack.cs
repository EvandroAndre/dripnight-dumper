using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

public class UGCTimelinePreviewSwitchCameraTrack : UGCTimelinePreviewTrackBase
{
	private UGCPlayerRepItem m_UGCPlayerRepItem;

	private bool m_IsRemovePlayerEntity;

	public override void Init(UGCTimelinePreviewMgr previewMgr, IUGCTimelineTrack track)
	{
	}

	private void OnCurrentNewCameraChangeEvent(string currentNewCamera)
	{
	}

	public override void Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Init(UGCTimelinePreviewMgr P0, IUGCTimelineTrack P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}
}
