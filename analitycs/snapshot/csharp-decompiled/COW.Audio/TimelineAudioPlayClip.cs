using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.Audio;

[Serializable]
public class TimelineAudioPlayClip : PlayableAsset, ITimelineClipAsset
{
	public string soundID;

	public string audioSourceID;

	public int audioMixerGroup;

	public bool isAuto3D;

	public bool seekOnLoop;

	public ClipCaps clipCaps => ClipCaps.None;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
