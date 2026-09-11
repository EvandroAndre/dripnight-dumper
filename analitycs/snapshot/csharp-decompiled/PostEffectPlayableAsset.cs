using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class PostEffectPlayableAsset : PlayableAsset
{
	public BlackWhiteOverrideSettings blackWhiteOverrideSetting;

	public DistortOverrideSettings distortOverrideSetting;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	private void UpdateEffectParams(float overrideWeight, PostEffectManager activeMng)
	{
	}

	private void OnEffectEnd(PostEffectManager activeMng)
	{
	}
}
