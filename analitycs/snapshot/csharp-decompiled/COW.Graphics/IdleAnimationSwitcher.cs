using UnityEngine;

namespace COW.Graphics;

public class IdleAnimationSwitcher : MonoBehaviour
{
	public AnimationClip IdleClip;

	public AnimationClip SpecialIdleClip;

	public GameObject[] IdleStateObjects;

	public GameObject[] SpecialIdleStateObjects;

	public float TriggerInterval;

	public float IntervalVariance;

	public bool AvoidBreakingIdleClip;

	private Animation m_Animation;

	private bool m_IsPlayingSpecial;

	private float m_AccumulatedTime;

	private float m_CurrentThreshold;

	private float m_IdleLength;

	private float m_SpecialIdleLength;

	public bool IsPlayingSpecialIdle => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void SetupClips()
	{
	}

	private void CacheClipLengths()
	{
	}

	private void ResetThreshold()
	{
	}

	private void PlayIdleInternal()
	{
	}

	private void PlaySpecialIdleInternal()
	{
	}

	private void SetObjectsActive(GameObject[] objects, bool active)
	{
	}

	public void TriggerSpecialIdle()
	{
	}

	public void ForceReturnToIdle()
	{
	}
}
