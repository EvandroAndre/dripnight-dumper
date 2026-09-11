using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.Audio;

[Serializable]
public class TimelineEmoteAudioPlayClip : PlayableAsset, ITimelineClipAsset
{
	public string soundID;

	public bool seekOnLoop;

	private TimelineEmoteAudioPlayBehaviour m_Behaviour;

	public ClipCaps clipCaps => ClipCaps.None;

	private void OnDestroy()
	{
	}

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
