using UnityEngine.Playables;

namespace COW.Audio;

public class TimelineAudioSnapshotBehaviour : PlayableBehaviour
{
	private TimelineAudioSnapshotClip m_Clip;

	private bool m_SnapshotPushed;

	public void InitFromClip(TimelineAudioSnapshotClip clip)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBehaviourPlay(Playable P0, FrameData P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBehaviourPause(Playable P0, FrameData P1)
	{
	}
}
