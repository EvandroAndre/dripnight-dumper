using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay;

internal class AIAnimEventHandle : MonoBehaviour
{
	private Transform m_CacheTransform;

	protected NetworkAIPawn m_Owner;

	public void Register(NetworkAIPawn owner)
	{
	}

	private void Start()
	{
	}

	private void PlayEventEffect(AnimationEvent evt)
	{
	}

	private void PlayEventSound(AnimationEvent evt)
	{
	}

	protected virtual void InternalPlayEventSound(AnimationEvent evt)
	{
	}

	private void PlayEventShadowEffect(AnimationEvent evt)
	{
	}

	private void EventSetModelVisibleState(AnimationEvent evt)
	{
	}

	private void EventSetColliderActiveState(AnimationEvent evt)
	{
	}
}
