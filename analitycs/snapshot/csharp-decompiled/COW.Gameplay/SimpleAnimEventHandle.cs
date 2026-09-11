using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay;

internal class SimpleAnimEventHandle : MonoBehaviour
{
	private Transform m_CacheTransform;

	private ActionSkillPawn ownerSkillPawn;

	private void Start()
	{
	}

	private void OnTransformParentChanged()
	{
	}

	private void PlayEventEffect(AnimationEvent evt)
	{
	}

	private void PlayEventSound(AnimationEvent evt)
	{
	}

	public void PlayShakeCamera(AnimationEvent evt)
	{
	}
}
