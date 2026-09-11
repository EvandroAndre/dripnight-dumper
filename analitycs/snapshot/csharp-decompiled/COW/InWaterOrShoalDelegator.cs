using UnityEngine;

namespace COW;

public class InWaterOrShoalDelegator : StatedTaggedTriggerDelegator
{
	protected override bool CheckCollider(Collider other)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CheckCollider(Collider P0)
	{
		return false;
	}
}
