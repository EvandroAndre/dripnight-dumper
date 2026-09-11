using UnityEngine.Playables;

public class PostEffectOverridePlayableBehaviour : PlayableBehaviour
{
	public bool enableBlackWhite;

	public bool tint;

	public float minInput;

	public float maxInput;

	public UpdateParamsDelegate UpdateEffectParams;

	public OnEffectEndDelegate OnEffectEnd;

	private PostEffectManager _cachedManager;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}
}
