using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PostEffectTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}
}
