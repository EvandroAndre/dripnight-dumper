using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AdditiveEffectTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}
}
