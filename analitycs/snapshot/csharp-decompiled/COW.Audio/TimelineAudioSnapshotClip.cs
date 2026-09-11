using System;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.Audio;

[Serializable]
public class TimelineAudioSnapshotClip : PlayableAsset, ITimelineClipAsset
{
	public EAudioMixerSnapshotType snapshotType;

	public EAudioSnapshotPriorityLayer priorityLayer;

	public float transitionTime;

	public ClipCaps clipCaps => ClipCaps.None;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
