using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PostProcessingEffectsPlayableBehaviour : PlayableBehaviour
{
	private List<PostEffectProfile> m_BlackWhites;

	public GameObject TargetObject;

	public bool tint;

	public bool invert;

	public float minInput;

	public float maxInput;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void OnGraphStart(Playable playable)
	{
	}
}
