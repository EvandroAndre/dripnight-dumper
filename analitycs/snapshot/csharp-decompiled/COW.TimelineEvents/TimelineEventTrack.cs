using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.TimelineEvents;

public class TimelineEventTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	public Playable _003C_003EiFixBaseProxy_CreateTrackMixer(PlayableGraph P0, GameObject P1, int P2)
	{
		return default(Playable);
	}
}
