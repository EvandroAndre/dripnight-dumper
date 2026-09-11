using UnityEngine;

namespace COW;

internal class RecyleAnimationRoot
{
	public RecyleFeedbackItem PlayingItemCtrl;

	public Animation OutAnimation;

	public Transform Root;

	public AnimationState State;

	public bool IsUsing;

	public uint DelayID;

	public float AniEndTime;

	public int Index;

	public TweenAlpha UseTweenAlpha;

	public float DefaultTweenDelay;

	public float Duration;

	public RecyleAnimationRoot(Animation outAni2, Transform preNode2, TweenAlpha tween, AnimationState state, int index)
	{
	}
}
