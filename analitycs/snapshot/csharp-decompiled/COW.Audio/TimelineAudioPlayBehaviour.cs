using UnityEngine;
using UnityEngine.Playables;

namespace COW.Audio;

public class TimelineAudioPlayBehaviour : PlayableBehaviour
{
	public string SoundID;

	public string AudioSourceID;

	public int AudioMixerGroup;

	public bool IsAuto3D;

	public bool SeekOnLoop;

	public GameObject Emitter;

	private uint m_PlayingID;

	private double m_PreviousTime;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	private void SeekTimelineAudio(float timelineTime)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBehaviourPlay(Playable P0, FrameData P1)
	{
	}

	public void _003C_003EiFixBaseProxy_PrepareFrame(Playable P0, FrameData P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBehaviourPause(Playable P0, FrameData P1)
	{
	}
}
