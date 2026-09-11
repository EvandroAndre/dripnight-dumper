using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay;

internal class AIDragonAnimEventHandle : AIAnimEventHandle
{
	public NetworkAIPawnAnimComponent_BossDragon DragonAnim;

	protected override void InternalPlayEventSound(AnimationEvent evt)
	{
	}

	private void EventDragonHeadRebornStart(AnimationEvent evt)
	{
	}

	private void EventDragonHeadRebornEnd(AnimationEvent evt)
	{
	}

	public void _003C_003EiFixBaseProxy_InternalPlayEventSound(AnimationEvent P0)
	{
	}
}
