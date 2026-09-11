using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;
using UnityEngine.Playables;

namespace COW;

public class AvatarTimelineSync : MonoBehaviour
{
	private UIMaleAvatar m_LobbyAvatar;

	private Player m_Owner;

	private PlayableDirector m_PlayAble;

	private double m_PlayableUpdateTime;

	private Animator[] m_Animators;

	private readonly List<Animator> m_ResetAnimatorCache;

	private Transform[] m_InitialActiveTransforms;

	private bool[] m_InitialActiveStates;

	private float m_AniUpdateTime;

	public DirectorUpdateMode m_PlayUpdateMode;

	private bool m_EnableSync;

	private bool m_SecondEnableSync;

	public bool m_UseFraction;

	public float secondstart;

	public float secondend;

	public bool usemod1;

	public bool isLoop;

	private float m_FreezeemoteLength;

	private int m_AnimatorStateInfoNameHash;

	private float m_EmoteFreezeTime;

	private void Awake()
	{
	}

	private void CacheInitialActiveStates()
	{
	}

	private void RestoreInitialActiveStates()
	{
	}

	private void ResetAnimators()
	{
	}

	private void ResetStatus()
	{
	}

	public void SetPlayer(BHGGAEEHJCO id)
	{
	}

	public void SetTimelineTime(double time)
	{
	}

	public void SetMaleAvatar(UIMaleAvatar avatar)
	{
	}

	private void UpdateSecond()
	{
	}

	private void LateUpdate()
	{
	}

	private void TrySyncPlayAble(float currentTime, float freezeDuration = 0f)
	{
	}

	private void TrySyncAnimator(float currentTime)
	{
	}

	public void SetSyncState(bool enable)
	{
	}

	public void SetSecondSyncState(bool enable)
	{
	}

	public void SetTimelineSkip()
	{
	}
}
