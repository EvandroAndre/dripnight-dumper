using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class PostProcessingEffectsPlayableAsset : PlayableAsset
{
	public bool tint;

	public bool invert;

	public float minInput;

	public float maxInput;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
