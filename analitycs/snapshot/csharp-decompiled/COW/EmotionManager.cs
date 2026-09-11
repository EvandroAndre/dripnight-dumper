using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class EmotionManager
{
	private Animator m_Animator;

	private Action<AnimationClip> m_OnOverrideClip;

	public event Action<AnimationClip> OnOverrideClip
	{
		add
		{
		}
		remove
		{
		}
	}

	public EmotionManager(Animator animator)
	{
	}

	public float PlayEmotionAnimation(uint emotionID, bool isFemale, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, bool isPreview = false)
	{
		return 0f;
	}

	public void PlayFreezeEmotionAnimation(uint emotionID, bool isFemale, EDuoEmoteStage duoEmoteStage, bool isPreview = false)
	{
	}

	public float PlaySuperEmotionAnimation(uint superEmoteId, bool isFemale)
	{
		return 0f;
	}

	public float PlayFinishMoveAnimation(uint finishMoveId, bool isFemale)
	{
		return 0f;
	}

	public void PlayGroupFreezeAnim(ResourceID groupAnimID, ResourceID groupFreezeAnimId)
	{
	}

	public void PlayAnimClip(ResourceID animResId)
	{
	}

	public void StopEmotionAnimation()
	{
	}

	public void SetOverrideAnim(AnimationClip clip, string clipName)
	{
	}

	private AnimationClip GetAnimClip(RuntimeAnimatorController controller, bool baseClip, string clipName)
	{
		return null;
	}

	private static AnimationClip LoadAnimClip(ResourceID id)
	{
		return null;
	}
}
