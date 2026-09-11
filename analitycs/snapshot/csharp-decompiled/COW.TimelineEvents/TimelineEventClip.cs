using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.TimelineEvents;

[Serializable]
public class TimelineEventClip : PlayableAsset, ITimelineClipAsset
{
	public TimelineEventBehaviour template;

	private GameObject _003CTrackTargetObject_003Ek__BackingField;

	[NonSerialized]
	public string DirectorName;

	public bool EvaluateInvokeFunc;

	public GameObject TrackTargetObject
	{
		get
		{
			return _003CTrackTargetObject_003Ek__BackingField;
		}
		set
		{
			_003CTrackTargetObject_003Ek__BackingField = value;
		}
	}

	public ClipCaps clipCaps => ClipCaps.None;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}
}
