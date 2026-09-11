using COW.GamePlay;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.Audio;

public class TimelineEmoteAudioPlayBehaviour : PlayableBehaviour
{
	public string SoundID;

	public bool SeekOnLoop;

	public GameObject Emitter;

	private uint m_EmotePlayingID;

	private double m_PreviousTime;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	private ResourceID ResolveTimelineEmoteResourceId(Player ownerPlayer)
	{
		return default(ResourceID);
	}

	private Player ResolveEmitterOwnerPlayer(GameObject emitter)
	{
		return null;
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public void StopEmoteSound()
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
